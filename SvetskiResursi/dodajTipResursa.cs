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
        private OpenFileDialog ofd = new OpenFileDialog();
        private Regex rx_oz = null;
        private Regex rx_ime = null;
        private bool formIsValid = true;
        
        Dictionary<object, bool> errorRepeat = new Dictionary<object, bool>();


        public dodajTipResursa()
        {
            InitializeComponent();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";

            rx_oz = new Regex("^\\w+$");
            rx_ime = new Regex("^\\w+$");

            errorRepeat.Add(oznaka_tip, false);
            errorRepeat.Add(ime_tip, false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d = ofd.ShowDialog();
            if (d == DialogResult.OK)
            {
                string fname = ofd.FileName;
                Image img = new Bitmap(fname);
                pictureBox1.BackgroundImage = img;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //data
            tipResursa tipRes = new tipResursa();

            tipRes.oznaka = oznaka_tip.Text;
            tipRes.ime = ime_tip.Text;
            tipRes.opis = opis_tip.Text;
            tipRes.ikonica = (Image)pictureBox1.BackgroundImage;

            //provera da li su uneta obavezna polja
            formIsValid = true;
            this.ValidateChildren();
            if (formIsValid)
            {
                SvetskiResursi.tipoviResursa.getInstance().Dodaj(tipRes);

                this.DialogResult = DialogResult.OK;
                this.Close();
                SvetskiResursi.Form1.getInstance().Refresh();
            }

        }

        private void oznaka_tip_Validating(object sender, CancelEventArgs e)
        {
            tipResursa tip = new tipResursa();

            if (rx_oz.Match(oznaka_tip.Text).Success)
            {
                errorProviderOz.SetError(oznaka_tip, ""); //Ovako se postavlja da se greška isključi
                errorRepeat[sender] = false; // Ovo resetuje brojanje ponavljanje greške
            }
            else
            {
                //Ovim se podešava da se ispisuje greška.
                errorProviderOz.SetError(oznaka_tip, "Oznaka je obavezna");
                formIsValid = false;
                if (!errorRepeat[sender]) //Ovo je način da zabranimo korisnku da izađe iz kontrole prvi put, ali ne drugi put
                {
                    e.Cancel = true; //Prelazak iz kontrole je zabranjen
                }
                errorRepeat[sender] = !errorRepeat[sender]; //Promenimo stanje vođenja računa o preskakanju iz kontrole u kontrolu
            }


         using (Stream stream = File.Open("Tipovi.bin", FileMode.Open))
            {

                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                while (stream.Position != stream.Length)
                {
                    tip = (tipResursa)formatter.Deserialize(stream);
            
                    //Ovo je događaj validiranja koji se okida kada polje _izgubi_ fokus. 
                    if (!tip.oznaka.Equals(oznaka_tip.Text))
                    {
                        errorProviderOz.SetError(oznaka_tip, ""); //Ovako se postavlja da se greška isključi
                        errorRepeat[sender] = false; // Ovo resetuje brojanje ponavljanje greške
                    }
                    else
                    {
                        //Ovim se podešava da se ispisuje greška.
                        errorProviderOz.SetError(oznaka_tip, "Upisite novu");
                        formIsValid = false;
                        if (!errorRepeat[sender]) //Ovo je način da zabranimo korisnku da izađe iz kontrole prvi put, ali ne drugi put
                        {
                            e.Cancel = true; //Prelazak iz kontrole je zabranjen
                        }
                        errorRepeat[sender] = !errorRepeat[sender]; //Promenimo stanje vođenja računa o preskakanju iz kontrole u kontrolu
                    }
                }
                stream.Close();
            }
        }

        private void ime_tip_Validating(object sender, CancelEventArgs e)
        {
            //Ovo je događaj validiranja koji se okida kada polje _izgubi_ fokus. 
            if (rx_ime.Match(ime_tip.Text).Success)
            {
                errorProviderIm.SetError(ime_tip, ""); //Ovako se postavlja da se greška isključi
                errorRepeat[sender] = false; // Ovo resetuje brojanje ponavljanje greške
            }
            else
            {
                //Ovim se podešava da se ispisuje greška.
                errorProviderIm.SetError(ime_tip, "Ime je obavezno");
                formIsValid = false;
                if (!errorRepeat[sender]) //Ovo je način da zabranimo korisnku da izađe iz kontrole prvi put, ali ne drugi put
                {
                    e.Cancel = true; //Prelazak iz kontrole je zabranjen
                }
                errorRepeat[sender] = !errorRepeat[sender]; //Promenimo stanje vođenja računa o preskakanju iz kontrole u kontrolu
            }
        }
    }
}