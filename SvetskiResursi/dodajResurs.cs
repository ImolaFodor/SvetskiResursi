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
    public partial class dodajResurs : Form
    {
        private OpenFileDialog ofd = new OpenFileDialog();
        List<tipResursa> tr = new List<tipResursa>();
        List<Etiketa> et = new List<Etiketa>();
        Resurs resur;

        private Regex rx_oz = null;
        private Regex rx_ime = null;
        private Regex rx_tip = null;
        private bool formIsValid = true;
        Dictionary<object, bool> errorRepeat = new Dictionary<object, bool>();

        public dodajResurs()
        {
            InitializeComponent();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";

            //za proveru upisa obaveznih polja
            rx_oz = new Regex("^\\w+$");
            rx_ime = new Regex("^\\w+$");
            rx_tip = new Regex("^\\w+$");

            errorRepeat.Add(oznaka, false);
            errorRepeat.Add(ime, false);
            errorRepeat.Add(comboTipResursa, false);

            using (Stream stream = File.Open("Tipovi.bin", FileMode.Open))
            {
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                while(stream.Position != stream.Length)
                    tr.Add((tipResursa)formatter.Deserialize(stream));
                stream.Close();
            }

            using (Stream stream = File.Open("Etikete.bin", FileMode.Open))
            {
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                while (stream.Position != stream.Length)
                    et.Add((Etiketa)formatter.Deserialize(stream));
                stream.Close();
            }
           
            foreach (tipResursa tip in tr)
             {
                 comboTipResursa.Items.Add(tip.oznaka);

             }

            foreach (Etiketa etiketa in et)
             {
                 checkedListBox1.Items.Add(etiketa.oznaka);

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            Resurs res = new Resurs();
            resur = new Resurs();
            DialogObavestenja db = new DialogObavestenja();
            ObavestenjeZaOznaku ozo = new ObavestenjeZaOznaku();

            //provera da li vec postoji resurs sa odredjenom oznakom
            using (Stream stream = File.Open("Resursi.bin", FileMode.Open))
            {
                             
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                while (stream.Position != stream.Length)
                {
                    resur = (Resurs)formatter.Deserialize(stream);

                    if (resur.oznaka != null)
                        if (resur.oznaka.Equals(oznaka.Text))
                        {
                            Console.Write("Oznaka vec postoji.");
                            oznaka.Text = "UNESITE NOVU OZNAKU";
                            return;
                        }
                }

                stream.Close();


                //kad se klikne ok, prvo se u promenjive smestaju sve unete vrednosti, a ako neka obavezna vred. fali, ide dalja provera
                res.oznaka = oznaka.Text;
                res.ime = ime.Text;
                res.opis = opis.Text;
                res.tipResursa = comboTipResursa.Text;

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
                res.cena = textBox3.Text;
                res.datum_kao = dateTimePicker1.ToString().Split(' ')[2]; // "Datum";//datum
                res.pojavljivanje = comboBox6.Text;
                List<string> cekirani = checkedListBox1.CheckedItems.OfType<string>().ToList();
                res.oz_etiketa = cekirani;


                //provera da li su uneta obavezna polja
                formIsValid = true;
                this.ValidateChildren();
                if (formIsValid)
                {
                    SvetskiResursi.Resursi.getInstance().Dodaj(res);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    SvetskiResursi.Form1.getInstance().Refresh();
                }
            }
        }

        private void FormV_Load(object sender, EventArgs e)
        {

        }

        private void oznaka_Validating(object sender, CancelEventArgs e)
        {
            //Ovo je događaj validiranja koji se okida kada polje _izgubi_ fokus. 
            if (rx_oz.Match(oznaka.Text).Success)
            {
                errorProviderOz.SetError(oznaka, ""); //Ovako se postavlja da se greška isključi
                errorRepeat[sender] = false; // Ovo resetuje brojanje ponavljanje greške
            }
            else
            {
                //Ovim se podešava da se ispisuje greška.
                errorProviderOz.SetError(oznaka, "Oznaka je obavezna");
                formIsValid = false;
                if (!errorRepeat[sender]) //Ovo je način da zabranimo korisnku da izađe iz kontrole prvi put, ali ne drugi put
                {
                    e.Cancel = true; //Prelazak iz kontrole je zabranjen
                }
                errorRepeat[sender] = !errorRepeat[sender]; //Promenimo stanje vođenja računa o preskakanju iz kontrole u kontrolu
            }

        }

        private void ime_Validating(object sender, CancelEventArgs e)
        {
            //Ovo je događaj validiranja koji se okida kada polje _izgubi_ fokus. 
            if (rx_oz.Match(ime.Text).Success)
            {
                errorProviderIm.SetError(ime, ""); //Ovako se postavlja da se greška isključi
                errorRepeat[sender] = false; // Ovo resetuje brojanje ponavljanje greške
            }
            else
            {
                //Ovim se podešava da se ispisuje greška.
                errorProviderIm.SetError(ime, "Ime je obavezno");
                formIsValid = false;
                if (!errorRepeat[sender]) //Ovo je način da zabranimo korisnku da izađe iz kontrole prvi put, ali ne drugi put
                {
                    e.Cancel = true; //Prelazak iz kontrole je zabranjen
                }
                errorRepeat[sender] = !errorRepeat[sender]; //Promenimo stanje vođenja računa o preskakanju iz kontrole u kontrolu
            }
        }

        private void comboTipResursa_Validating(object sender, CancelEventArgs e)
        {
            //Ovo je događaj validiranja koji se okida kada polje _izgubi_ fokus. 
            if (rx_oz.Match(comboTipResursa.Text).Success)
            {
                errorProviderTp.SetError(comboTipResursa, ""); //Ovako se postavlja da se greška isključi
                errorRepeat[sender] = false; // Ovo resetuje brojanje ponavljanje greške
            }
            else
            {
                //Ovim se podešava da se ispisuje greška.
                errorProviderTp.SetError(comboTipResursa, "Tip je obavezan");
                formIsValid = false;
                if (!errorRepeat[sender]) //Ovo je način da zabranimo korisnku da izađe iz kontrole prvi put, ali ne drugi put
                {
                    e.Cancel = true; //Prelazak iz kontrole je zabranjen
                }
                errorRepeat[sender] = !errorRepeat[sender]; //Promenimo stanje vođenja računa o preskakanju iz kontrole u kontrolu
            }
        }

        private void dodajResurs_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
