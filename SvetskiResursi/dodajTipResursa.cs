using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;



namespace SvetskiResursi
{
    public partial class dodajTipResursa : Form
    {
        private tabelaTipova tbTipova;
        private OpenFileDialog ofd = new OpenFileDialog();
        private bool formIsValid = true;
        private bool vecPostoji = false;
        Form1 form = null;

        public dodajTipResursa(Form1 form1, tabelaTipova tb)
        {
            InitializeComponent();
            this.tbTipova = tb;
            form = form1;
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";

         }

        public dodajTipResursa()
        {
            InitializeComponent();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";

        }

        private void iscitajTipResurs(List<tipResursa> Lr)
        {
            using (Stream stream = File.Open("Tipovi.bin", FileMode.Open))
            {
                var formatter = new BinaryFormatter();

                while (stream.Position != stream.Length)
                    Lr.Add(((tipResursa)formatter.Deserialize(stream)));
                stream.Close();
            }
        }

        private void izborSlike_Click(object sender, EventArgs e)
        {
            DialogResult d = ofd.ShowDialog();
            if (d == DialogResult.OK)
            {
                string fname = ofd.FileName;
                Image img = new Bitmap(fname);
                ikonica.BackgroundImage = img;
                obavSl.Text = "";

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void potvrdi_Click(object sender, EventArgs e)
        {
            tabelaTipova tbtp = new tabelaTipova();

            if (!tabelaTipova.pritisnutoIzmeni)
            {
                //data
                tipResursa tipRes = new tipResursa();

                //Provera da li su obavezna polja popunjena
                if(!oznaka_tip.Text.Equals("") && formIsValid == true) //ukoliko postoji neka oznaka i forma nije validna
                    vecPostoji = false;                                 //znaci da ta oznaka vec postoji

                if (oznaka_tip.Text.Equals(""))
                {
                    obavOz.Text = "Oznaka je obavezna!";
                    obavOz.ForeColor = Color.Red;
                    formIsValid = false;
                }
                
                
                if (ime_tip.Text.Equals(""))
                {     
                    obavIm.Text = "Ime je obavezno!";
                    obavIm.ForeColor = Color.Red;
                    formIsValid = false;
                }
                else
                {
                    obavIm.Text = "";
                }

                if (ikonica.BackgroundImage == null)
                {
                    obavSl.Text = "Slika je obavezna!";
                    obavSl.ForeColor = Color.Red;
                    formIsValid = false;
                }
                else
                {
                    obavSl.Text = "";
                }

                if (!oznaka_tip.Text.Equals("") && vecPostoji == false && !ime_tip.Text.Equals("") && ikonica.BackgroundImage != null)
                    formIsValid = true;
                else
                    formIsValid = false;
                

                tipRes.oznaka = oznaka_tip.Text;
                tipRes.ime = ime_tip.Text;
                tipRes.opis = opis_tip.Text;
                tipRes.ikonica = (Image)ikonica.BackgroundImage;

                //provera da li su uneta obavezna polja
                this.ValidateChildren();
                if (formIsValid)
                {
                    SvetskiResursi.tipoviResursa.getInstance().Dodaj(tipRes);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    SvetskiResursi.Form1.getInstance().Refresh();
                }
            }
            else
            {
                tabelaTipova.pritisnutoIzmeni = false;

                List<tipResursa> Lr = new List<tipResursa>();

                using (Stream stream = File.Open("Tipovi.bin", FileMode.Open))
                {
                    var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    while (stream.Position != stream.Length)
                    {
                        Lr.Add(((tipResursa)formatter.Deserialize(stream)));

                    }

                    stream.SetLength(0);

                    //sada u LISTI trazim zeljeni tip i menjam ga.
                    foreach (tipResursa tr in Lr)
                    {
                        if (tr.oznaka.Equals(oznaka_tip.Text))
                        {
                                tr.ime = ime_tip.Text;
                                tr.opis = opis_tip.Text;
                                tr.ikonica = ikonica.BackgroundImage;
                        }
                    }

                    tbTipova.dataGridView1.Rows.Clear(); //brisanje prethodnog sadrzaja, zbog novog upisa
                    foreach (tipResursa tip in Lr)
                    {
                        tabelaTipova.upis(tip, tbTipova.dataGridView1);
                    }

                    foreach (tipResursa tip in Lr)
                    {
                        formatter.Serialize(stream, tip);
                    }

                    stream.Close();
                }

                tbtp.ocisti_filter();
                
                this.Close();

            }
            form.RefreshList();
        }

        private void oznaka_tip_TextChanged(object sender, EventArgs e)
        {
            List<tipResursa> tri = new List<tipResursa>();

            obavOz.Text = "";
            formIsValid = true;
            oznaka_tip.Text = Regex.Replace(oznaka_tip.Text, @"\s+", ""); //da se izbace razmaci

            iscitajTipResurs(tri);

               foreach(tipResursa tip in tri)
                   if (tip.oznaka.Equals(oznaka_tip.Text) && oznaka_tip.Enabled == true)
                        {
                            obavOz.Text = "Oznaka vec postoji, unesite novu!";
                            obavOz.ForeColor = Color.Red;
                            formIsValid = false;
                            vecPostoji = true;
                        }
        }

        private void ime_tip_TextChanged(object sender, EventArgs e)
        {
            obavIm.Text = "";
        }
    }
}