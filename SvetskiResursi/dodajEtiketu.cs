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
    public partial class dodajEtiketu : Form
    {
        private Regex rx_oz = null;
        private bool formIsValid = true;

        Dictionary<object, bool> errorRepeat = new Dictionary<object, bool>();

        public dodajEtiketu()
        {
            InitializeComponent();
            rx_oz = new Regex("^\\w+$");

            errorRepeat.Add(oznaka,false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                label5.BackColor = colorDialog1.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Etiketa et = new Etiketa();
            DialogObavestenja db = new DialogObavestenja();

            et.oznaka = oznaka.Text;
            et.opis = richTextBox1.Text;
            et.boja = label5.BackColor; 

            //provera da li su uneta obavezna polja
            formIsValid = true;
            this.ValidateChildren();
            if (formIsValid) { 

                SvetskiResursi.Etikete.getInstance().Dodaj(et);
             
                this.DialogResult = DialogResult.OK;
                this.Close();
                SvetskiResursi.Form1.getInstance().Refresh();
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            Etiketa ek = new Etiketa();

            //Ovo je događaj validiranja koji se okida kada polje _izgubi_ fokus. 
            if (rx_oz.Match(oznaka.Text).Success)
            {
                errorProviderEt.SetError(oznaka, ""); //Ovako se postavlja da se greška isključi
                errorRepeat[sender] = false; // Ovo resetuje brojanje ponavljanje greške
            }
            else
            {
                //Ovim se podešava da se ispisuje greška.
                errorProviderEt.SetError(oznaka, "Oznaka je obavezna");
                formIsValid = false;
                if (!errorRepeat[sender]) //Ovo je način da zabranimo korisnku da izađe iz kontrole prvi put, ali ne drugi put
                {
                    e.Cancel = true; //Prelazak iz kontrole je zabranjen
                }
                errorRepeat[sender] = !errorRepeat[sender]; //Promenimo stanje vođenja računa o preskakanju iz kontrole u kontrolu
            }

            //provera da li vec postoji resurs sa odredjenom oznakom
            using (Stream stream = File.Open("Etikete.bin", FileMode.Open))
            {

                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                while (stream.Position != stream.Length)
                {
                    ek = (Etiketa)formatter.Deserialize(stream);

                    if (ek.oznaka != null)
                        if (ek.oznaka.Equals(oznaka.Text))
                        {
                            oznaka.Text = "OZNAKA VEC POSTOJI!";
                            oznaka.ForeColor = Color.Red;
                            return;
                        }
                }

                stream.Close();
            }

        }
    }
}
