using SvetskiResursi;
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
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SvetskiResursi
{
    public partial class DodajResurs : Form
    {
        private OpenFileDialog ofd = new OpenFileDialog();
        
        private TabelaPrikaza tabelaPrikaza;
        private bool formIsValid = true;
        private bool vecPostoji = false;

        Resurs resur;
        Dictionary<object, bool> errorRepeat = new Dictionary<object, bool>();

        Form1 form = null;

        public DodajResurs(Form1 form1, TabelaPrikaza tabela)
        {
            InitializeComponent();

            List<tipResursa> tr = new List<tipResursa>();
            List<Etiketa> et = new List<Etiketa>();

            form = form1;
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";

            ucitajTip(tr);
            ucitajEt(et);

            foreach (tipResursa tip in tr)
            {
                comboTipResursa.Items.Add(tip.oznaka);

            }

            foreach (Etiketa etiketa in et)
            {
                etik.Items.Add(etiketa.oznaka);

            }

            this.tabelaPrikaza = tabela;
        }

        public DodajResurs(Form1 form1)
        {
            InitializeComponent();
            List<tipResursa> tr = new List<tipResursa>();
            List<Etiketa> et = new List<Etiketa>();
        

           // groupBox1.Paint += PaintBorderlessGroupBox;
            form = form1;
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";

            ucitajTip(tr);
            ucitajEt(et);
           
            foreach (tipResursa tip in tr)
             {
                 comboTipResursa.Items.Add(tip.oznaka);

             }

            foreach (Etiketa etiketa in et)
             {
                 etik.Items.Add(etiketa.oznaka);

             }
        }

        private void ucitajTip(List<tipResursa> tr)
        {
            using (Stream stream = File.Open("Tipovi.bin", FileMode.Open))
            {
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                while(stream.Position != stream.Length)
                    tr.Add((tipResursa)formatter.Deserialize(stream));
                stream.Close();
            }
        }

        private void ucitajEt(List<Etiketa> et)
        {
            using (Stream stream = File.Open("Etikete.bin", FileMode.Open))
            {
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                while (stream.Position != stream.Length)
                    et.Add((Etiketa)formatter.Deserialize(stream));
                stream.Close();
            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult d = ofd.ShowDialog();
            if (d == DialogResult.OK)
            {
                string fname = ofd.FileName;
                Image image1 = new Bitmap(fname);

                ikonica.BackgroundImage = image1;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Metod za dodelu vrednosti radiobutton-a u promenjivu
        public String oznaceno(String res, RadioButton rb1, RadioButton rb2)
        {
            bool oz = rb1.Checked;
            if (oz)
                res = rb1.Text;
            else
                res = rb2.Text;

            return res;
        }

        private void PotvrdiClick(object sender, EventArgs e)
        {
            Resurs res = new Resurs();
            resur = new Resurs();
            DialogObavestenja db = new DialogObavestenja();
            ObavestenjeZaOznaku ozo = new ObavestenjeZaOznaku();
            List<tipResursa> tr = new List<tipResursa>();
            TabelaPrikaza tbl = new TabelaPrikaza();

            if (!TabelaPrikaza.pritusnutoIzmeni)
            {

                //Provera da li su obavezna polja popunjena
                if (!oznaka.Text.Equals("") && formIsValid == true) //ukoliko postoji neka oznaka i forma nije validna
                    vecPostoji = false;                                 //znaci da ta oznaka vec postoji

                if (oznaka.Text.Equals(""))
                {
                    obavOZ.Text = "Oznaka je obavezna!";
                    obavOZ.ForeColor = Color.Red;
                    formIsValid = false;
                }

                if (ime.Text.Equals(""))
                {
                    obavIme.Text = "Ime je obavezno!";
                    obavIme.ForeColor = Color.Red;
                    formIsValid = false;
                }
                else
                {
                    obavIme.Text = "";
                }

                if (comboTipResursa.Text.Equals(""))
                {
                    obavTip.Text = "Tip je obavezna!";
                    obavTip.ForeColor = Color.Red;
                    formIsValid = false;
                }
                else
                {
                    obavTip.Text = "";
                }

                if (!oznaka.Text.Equals("") && vecPostoji == false && !ime.Text.Equals("") && !comboTipResursa.Text.Equals(""))
                    formIsValid = true;
                else
                    formIsValid = false;

                //kad se klikne ok, prvo se u promenjive smestaju sve unete vrednosti, a ako neka obavezna vred. fali, ide dalja provera
                res.oznaka = oznaka.Text;
                res.ime = ime.Text;
                res.opis = opis.Text;
                res.tipResursa = comboTipResursa.Text;

                ucitajTip(tr);

                //ukoliko nismo uneli sliku resursku, iskoristicemo sliku iz tipa resursa
                foreach (tipResursa tip in tr)
                {
                    if (ikonica.BackgroundImage == null && comboTipResursa.Text.Equals(tip.oznaka))
                        res.ikonica = tip.ikonica;
                    else
                        res.ikonica = (Image)ikonica.BackgroundImage;
                }


                res.obnovljivo = oznaceno(res.obnovljivo, rbObn1, rbObn2);
                res.eksploatacija = oznaceno(res.eksploatacija, rbEkp1, rbEksp2);
                res.strateska_vaznost = oznaceno(res.strateska_vaznost, rbSV1, rbSV2);
                res.jedinica_mere = cbMera.Text;
                res.cena = cen.Text;
                res.datum_kao = vreme.ToString().Split(' ')[2]; // "Datum";//datum
                res.pojavljivanje = frPon.Text;
                List<string> cekirani = etik.CheckedItems.OfType<string>().ToList();
                res.oz_etiketa = cekirani;


                //provera da li su uneta obavezna polja
               // formIsValid = true;
                this.ValidateChildren();
                if (formIsValid)
                {
                    SvetskiResursi.Resursi.getInstance().Dodaj(res);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    SvetskiResursi.Form1.getInstance().Refresh();
                }
            }
            else
            {
                TabelaPrikaza.pritusnutoIzmeni = false;
                List<Resurs> Lr = new List<Resurs>();

                using (Stream stream1 = File.Open("Resursi.bin", FileMode.Open))
                {
                    var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    while (stream1.Position != stream1.Length)
                    {
                        Lr.Add(((Resurs)formatter.Deserialize(stream1)));

                    }

                    stream1.SetLength(0); //brise se postojeci sadrzaj u datoteci

                    //sada u LISTI trazim zeljeni resurs i menjam ga.
                    foreach (Resurs rs in Lr)
                    {
                        if (rs.oznaka.Equals(oznaka.Text))
                        {
                                rs.ime = ime.Text;
                                rs.tipResursa = comboTipResursa.Text;
                                rs.opis = opis.Text;
                                rs.ikonica = ikonica.Image;
                                rs.pojavljivanje = frPon.Text;
                                rs.jedinica_mere = cbMera.Text;
                                // rs.ikonica = (Image)ikonica.BackgroundImage; 
                                rs.cena = cen.Text;
                                res.datum_kao = vreme.ToString().Split(' ')[2];
                                rs.obnovljivo = oznaceno(rs.obnovljivo, rbObn1, rbObn2);
                                rs.eksploatacija = oznaceno(rs.eksploatacija, rbEkp1, rbEksp2);
                                rs.strateska_vaznost = oznaceno(rs.strateska_vaznost, rbSV1, rbSV2);
                                List<string> cekirani1 = etik.CheckedItems.OfType<string>().ToList();
                                res.oz_etiketa = cekirani1;

                        }
                    }

                    if (tabelaPrikaza != null)
                    {
                        tabelaPrikaza.dataGridView1.Rows.Clear(); //brisanje prethodnog sadrzaja, zbog novog upisa
                    }

                    foreach (Resurs resurs in Lr)
                    {
                        TabelaPrikaza.upis(resurs, tabelaPrikaza.dataGridView1);
                    }

                    foreach (Resurs rs in Lr)
                    {
                        formatter.Serialize(stream1, rs);
                    }

                    stream1.Close();
                }

                tbl.ocisti_filter();
                this.Close();
            }

            form.RefreshList();
            

        }
    
        private void nTip_Click(object sender, EventArgs e)
        {
            List<tipResursa> tp = new List<tipResursa>();

            dodajTipResursa trs = new dodajTipResursa();
           
            if (trs.ShowDialog() == DialogResult.OK)
            {
                comboTipResursa.Items.Clear();
                ucitajTip(tp);
                foreach (tipResursa tip in tp)
                {
                    comboTipResursa.Items.Add(tip.oznaka);

                }
            }
        }

        private void nEtik_Click(object sender, EventArgs e)
        {
            List<Etiketa> ek = new List<Etiketa>();

            dodajEtiketu et = new dodajEtiketu();
           
            if (et.ShowDialog() == DialogResult.OK)
            {
                etik.Items.Clear();
                ucitajEt(ek);
                foreach (Etiketa etiketa in ek)
                {
                    etik.Items.Add(etiketa.oznaka);

                }
            }
        }

         private void oznaka_TextChanged(object sender, EventArgs e)
        {
            Resurs rs = new Resurs();
            formIsValid = true;
            obavOZ.Text = "";
            oznaka.Text = Regex.Replace(oznaka.Text, @"\s+", ""); //da se izbace razmaci

            using (Stream stream = File.Open("Resursi.bin", FileMode.Open))
            {

                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                while (stream.Position != stream.Length)
                {
                    rs = (Resurs)formatter.Deserialize(stream);

                    if (rs.oznaka != null)
                        if (rs.oznaka.Equals(oznaka.Text) && oznaka.Enabled == true)
                        {
                            obavOZ.Text = "Oznaka vec postoji, unesite novu!";
                            obavOZ.ForeColor = Color.Red;
                            formIsValid = false;
                            vecPostoji = true;
                            // return;
                        }
                }
                stream.Close();
            }
        }

        private void ime_TextChanged(object sender, EventArgs e)
        {
            obavIme.Text = "";
        }

        private void comboTipResursa_TextChanged(object sender, EventArgs e)
        {
            obavTip.Text = "";
        }
    }
}
