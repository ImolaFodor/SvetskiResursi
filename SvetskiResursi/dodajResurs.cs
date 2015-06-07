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
        private bool cenaOk = true;
        private int i = 0;

        Resurs resur;
        Dictionary<object, bool> errorRepeat = new Dictionary<object, bool>();

        Form1 form = null;

        public DodajResurs(Form1 form1, TabelaPrikaza tabela)
        {
            
            InitializeComponent();
            groupBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#E6E68A");
            groupBox2.BackColor = System.Drawing.ColorTranslator.FromHtml("#E6E68A");
            Vizualizacija.BackColor = System.Drawing.ColorTranslator.FromHtml("#E6E68A");
            List<tipResursa> tr = new List<tipResursa>();
            List<Etiketa> et = new List<Etiketa>();

            form = form1;
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";

            iscitajTipResursa(tr);
            iscitajEtikete(et);

            foreach (tipResursa tip in tr)
            {
                comboTipResursa.Items.Add(tip.oznaka);

            }

            foreach (Etiketa etiketa in et)
            {
                etik.Items.Add(etiketa.oznaka);

            }

            //da default bude odmah cekiran
            for (int i = 0; i < etik.Items.Count; i++)
                if (etik.Items[i].Equals("default"))
                {
                    etik.SetItemChecked(i, true);
                }

            this.tabelaPrikaza = tabela;
        }

        public DodajResurs(Form1 form1)
        {
            //this.BackColor = System.Drawing.ColorTranslator.FromHtml("#7A7F01");
            InitializeComponent();
            groupBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#E6E68A");
            groupBox2.BackColor = System.Drawing.ColorTranslator.FromHtml("#E6E68A");
            Vizualizacija.BackColor = System.Drawing.ColorTranslator.FromHtml("#E6E68A");
            List<tipResursa> tr = new List<tipResursa>();
            List<Etiketa> et = new List<Etiketa>();
        

           // groupBox1.Paint += PaintBorderlessGroupBox;
            form = form1;
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";

            iscitajTipResursa(tr);
            iscitajEtikete(et);
           
            foreach (tipResursa tip in tr)
             {
                 comboTipResursa.Items.Add(tip.oznaka);

             }

            foreach (Etiketa etiketa in et)
             {
                 etik.Items.Add(etiketa.oznaka);

             }

            //da default bude odmah cekiran
            for (int i = 0; i < etik.Items.Count; i++)
                if (etik.Items[i].Equals("default"))
                {
                    etik.SetItemChecked(i, true);
                }
        }

        private void iscitajTipResursa(List<tipResursa> tr)
        {
            using (Stream stream = File.Open("Tipovi.bin", FileMode.Open))
            {
                var formatter = new BinaryFormatter();
                while(stream.Position != stream.Length)
                    tr.Add((tipResursa)formatter.Deserialize(stream));
                stream.Close();
            }
        }

        private void iscitajEtikete(List<Etiketa> et)
        {
            using (Stream stream = File.Open("Etikete.bin", FileMode.Open))
            {
                var formatter = new BinaryFormatter();
                while (stream.Position != stream.Length)
                    et.Add((Etiketa)formatter.Deserialize(stream));
                stream.Close();
            }
        }

        private void iscitajResurs(List<Resurs> rs)
        {
            using (Stream stream = File.Open("Resursi.bin", FileMode.Open))
            {
                var formatter = new BinaryFormatter();
                while (stream.Position != stream.Length)
                    rs.Add((Resurs)formatter.Deserialize(stream));
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
            bool oz1 = rb1.Checked;
            bool oz2 = rb2.Checked;

            if (oz1)
                res = rb1.Text;
            else
                if (oz2)
                    res = rb2.Text;
            else
                res = " ";

            return res;
        }

        private void PotvrdiClick(object sender, EventArgs e)
        {
            Resurs res = new Resurs();
            resur = new Resurs();
           
            List<tipResursa> tr = new List<tipResursa>();
            TabelaPrikaza tbl = new TabelaPrikaza(form);

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
                    obavTip.Text = "Tip je obavezan!";
                    obavTip.ForeColor = Color.Red;
                    formIsValid = false;
                }
                else
                {
                    obavTip.Text = "";
                }

                if (!oznaka.Text.Equals("") && vecPostoji == false && !ime.Text.Equals("") && !comboTipResursa.Text.Equals("") && cenaOk)
                    formIsValid = true;
                else
                    formIsValid = false;

                //kad se klikne ok, prvo se u promenjive smestaju sve unete vrednosti, a ako neka obavezna vred. fali,
                //ide dalja provera
                res.oznaka = oznaka.Text;
                res.ime = ime.Text;
                res.opis = opis.Text;
                res.tipResursa = comboTipResursa.Text;
                res.obnovljivo = oznaceno(res.obnovljivo, rbObn1, rbObn2);
                res.eksploatacija = oznaceno(res.eksploatacija, rbEkp1, rbEksp2);
                res.strateska_vaznost = oznaceno(res.strateska_vaznost, rbSV1, rbSV2);
                res.jedinica_mere = cbMera.Text;
                res.cena = cen.Text;
                res.datum_kao = vreme.ToString().Split(' ')[2]; 
                res.pojavljivanje = frPon.Text;
                List<string> cekirani = etik.CheckedItems.OfType<string>().ToList();
                res.oz_etiketa = cekirani;             

                iscitajTipResursa(tr);

                //ukoliko nismo uneli sliku resursku, iskoristicemo sliku iz tipa resursa
                foreach (tipResursa tip in tr)
                {
                    if (ikonica.BackgroundImage == null && comboTipResursa.Text.Equals(tip.oznaka))
                    {
                        res.ikonica = tip.ikonica;
                        break;
                    }
                    else
                        res.ikonica = (Image)ikonica.BackgroundImage;
                }


                //provera da li su uneta obavezna polja
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
                
                List<Resurs> Lr = new List<Resurs>();

                iscitajTipResursa(tr);
 
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
                    obavTip.Text = "Tip je obavezan!";
                    obavTip.ForeColor = Color.Red;
                    formIsValid = false;
                }
                else
                {
                    obavTip.Text = "";
                }

                if (!ime.Text.Equals("") && !comboTipResursa.Text.Equals("") && cenaOk)
                    formIsValid = true;
                else
                    formIsValid = false;

                if (formIsValid)
                {
                    TabelaPrikaza.pritusnutoIzmeni = false;
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
                                rs.ikonica = ikonica.BackgroundImage;
                                rs.pojavljivanje = frPon.Text;
                                rs.jedinica_mere = cbMera.Text;
                                rs.cena = cen.Text;
                                res.datum_kao = vreme.ToString().Split(' ')[2];
                                rs.obnovljivo = oznaceno(rs.obnovljivo, rbObn1, rbObn2);
                                rs.eksploatacija = oznaceno(rs.eksploatacija, rbEkp1, rbEksp2);
                                rs.strateska_vaznost = oznaceno(rs.strateska_vaznost, rbSV1, rbSV2);
                                List<string> cekirani1 = etik.CheckedItems.OfType<string>().ToList();
                                rs.oz_etiketa = cekirani1;

                                foreach (tipResursa tip in tr)
                                {
                                    if (ikonica.BackgroundImage == null && comboTipResursa.Text.Equals(tip.oznaka))
                                    {
                                        rs.ikonica = tip.ikonica;
                                        break;
                                    }
                                    else
                                        rs.ikonica = (Image)ikonica.BackgroundImage;
                                }

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
            }
        }
    
        private void nTip_Click(object sender, EventArgs e)
        {
            List<tipResursa> tp = new List<tipResursa>();

            dodajTipResursa trs = new dodajTipResursa();
           
            if (trs.ShowDialog() == DialogResult.OK)
            {
                comboTipResursa.Items.Clear();
                iscitajTipResursa(tp);
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
                iscitajEtikete(ek);
                foreach (Etiketa etiketa in ek)
                {
                    etik.Items.Add(etiketa.oznaka);

                }
            }
        }

         private void oznaka_TextChanged(object sender, EventArgs e)
        {
            List<Resurs> rss = new List<Resurs>();
            formIsValid = true;
            obavOZ.Text = "";
            oznaka.Text = Regex.Replace(oznaka.Text, @"\s+", ""); //da se izbace razmaci

           iscitajResurs(rss);

           foreach(Resurs rs in rss)
             if (rs.oznaka.Equals(oznaka.Text) && oznaka.Enabled == true)
                {
                   obavOZ.Text = "Oznaka vec postoji, unesite novu!";
                   obavOZ.ForeColor = Color.Red;
                   formIsValid = false;
                   vecPostoji = true;
                          
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

        private void cbMera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboTipResursa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cen_TextChanged(object sender, EventArgs e)
        {
            decimal d;
            if (!decimal.TryParse(cen.Text, out d))
            {
                //Error
                lbValCene.Text = "Cena samo u brojevima!";
                lbValCene.ForeColor = Color.Red;
                cenaOk = false;
            }
            else
            {
                lbValCene.Text = "";
                cenaOk = true;
            }

            if (cen.Text.Equals(""))
            {
                lbValCene.Text = "";
                cenaOk = true;
            }

            
        }
    }
}
