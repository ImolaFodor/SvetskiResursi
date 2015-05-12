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
        private tabelaEtiketa tbEtiketa;
        private Regex rx_oz = null;
        private bool formIsValid = true;

        Dictionary<object, bool> errorRepeat = new Dictionary<object, bool>();

        public dodajEtiketu(tabelaEtiketa ebet)
        {
            InitializeComponent();
            tbEtiketa = ebet;

            rx_oz = new Regex("^\\w+$");

            errorRepeat.Add(oznaka, false);
        }

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
                lBoja.BackColor = colorDialog1.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void potvrdi_Click(object sender, EventArgs e)
        {
            tabelaEtiketa tbE = new tabelaEtiketa();

            if (!tabelaEtiketa.pritisnutoIzmena)
            {
                Etiketa et = new Etiketa();
                DialogObavestenja db = new DialogObavestenja();

                et.oznaka = oznaka.Text;
                et.opis = opis.Text;
                et.boja = lBoja.BackColor;

                //provera da li su uneta obavezna polja
                formIsValid = true;
                this.ValidateChildren();
                if (formIsValid)
                {

                    SvetskiResursi.Etikete.getInstance().Dodaj(et);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    SvetskiResursi.Form1.getInstance().Refresh();
                }
            }
            else
            {
                 tabelaEtiketa.pritisnutoIzmena = false;   
                 List<Etiketa> et = new List<Etiketa>();


            using (Stream stream = File.Open("Etikete.bin", FileMode.Open))
            {
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                
                while (stream.Position != stream.Length)
                {
                    et.Add(((Etiketa)formatter.Deserialize(stream)));

                }

               stream.SetLength(0); //na ovaj nacin se sve brise iz liste

                //sada u LISTI trazim zeljenu etiektu i menjamo je.
                foreach (Etiketa tr in et)
                {
                    if (tr.oznaka.Equals(oznaka.Text))
                    {
     
                         tr.opis = opis.Text;
                         tr.boja = lBoja.BackColor;
                      
                    }
                }

                tbEtiketa.dataGridView1.Rows.Clear(); //brisanje prethodnog sadrzaja, zbog novog upisa

                foreach (Etiketa etiketa in et)
                {
                    tabelaEtiketa.upis(etiketa,tbEtiketa.dataGridView1);

                }

                foreach (Etiketa etiketa in et)
                {
                    formatter.Serialize(stream, etiketa); //nadam se da ga upisuje na isto mesto, a ne na kraj :O

                }

                stream.Close();
            }

            tbE.ocisti_filter();
            Close();
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
