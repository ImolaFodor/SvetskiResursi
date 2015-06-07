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
        private bool formIsValid = true;


        public dodajEtiketu(tabelaEtiketa ebet)
        {
            List<Etiketa> et = new List<Etiketa>();
            Etiketa etik = new Etiketa();
            
            InitializeComponent();
            tbEtiketa = ebet;

      /*      using (Stream stream = File.Open("Etikete.bin", FileMode.Open))
            {
                var formatter = new BinaryFormatter();
                stream.Position = 0;
                while (stream.Position != stream.Length)//potrebno proci od pocetka do kraja fajla!!!
                    et.Add((Etiketa)formatter.Deserialize(stream));

                stream.SetLength(0);

                etik.oznaka = "default";
                etik.boja = Color.White;
                etik.opis = "";


                if (!et.Contains(etik))
                    et.Add(etik);

                foreach (Etiketa etiketa in et)
                {
                    formatter.Serialize(stream, etiketa);

                }

                stream.Close();

            }*/
          }

        public dodajEtiketu()
        {
            List<Etiketa> et = new List<Etiketa>();
            Etiketa etik = new Etiketa();
            //this.BackColor = System.Drawing.ColorTranslator.FromHtml("#7A7F01");
            InitializeComponent();

         /*   using (Stream stream = File.Open("Etikete.bin", FileMode.Open))
            {
                var formatter = new BinaryFormatter();
                stream.Position = 0;
                while (stream.Position != stream.Length)//potrebno proci od pocetka do kraja fajla!!!
                    et.Add((Etiketa)formatter.Deserialize(stream));

                stream.SetLength(0);

                etik.oznaka = "default";
                etik.boja = Color.White;
                etik.opis = "";


                if (!et.Contains(etik))
                    et.Add(etik);

                foreach (Etiketa etiketa in et)
                {
                    formatter.Serialize(stream, etiketa);

                }
 
                stream.Close();

            }*/
        }

        private void izborBoje(object sender, EventArgs e)
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

        private void iscitajEtikete(List<Etiketa> et2)
        {

            using (Stream stream = File.Open("Etikete.bin", FileMode.Open))
            {
                var formatter = new BinaryFormatter();
                stream.Position = 0;
                while (stream.Position != stream.Length)//potrebno proci od pocetka do kraja fajla!!!
                    et2.Add((Etiketa)formatter.Deserialize(stream));
                stream.Close();
            }
        }

        private void potvrdi_Click(object sender, EventArgs e)
        {
            tabelaEtiketa tbE = new tabelaEtiketa();

            if (!tabelaEtiketa.pritisnutoIzmena)
            {
                Etiketa et = new Etiketa();

                //Provera da li je uneta oznaka
                if (oznaka.Text.Equals(""))
                {
                    obavE.Text = "Oznaka je obavezna!";
                    obavE.ForeColor = Color.Red;
                    formIsValid = false;
                }
                else if(!oznaka.Text.Equals("") && formIsValid == true)
                {
                    obavE.Text = "";
                }

                et.oznaka = oznaka.Text;
                et.opis = opis.Text;
                et.boja = lBoja.BackColor;

                //provera da li su uneta obavezna polja
                this.ValidateChildren();
                if (formIsValid)
                {

                    SvetskiResursi.Etikete.getInstance().Dodaj(et);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    //SvetskiResursi.Form1.getInstance().Refresh();
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

        private void oznaka_TextChanged(object sender, EventArgs e)
        {
            List<Etiketa> etk = new List<Etiketa>();

            obavE.Text = "";
            formIsValid = true;
            oznaka.Text = Regex.Replace(oznaka.Text, @"\s+", "");//da bi se izbacili razmaci


           iscitajEtikete(etk);

           foreach(Etiketa ek in etk)
               if (ek.oznaka.Equals(oznaka.Text) && oznaka.Enabled == true)
                  {
                    obavE.Text = "Oznaka vec postoji, unesite novu.";
                    obavE.ForeColor = Color.Red;
                    formIsValid = false;
                  }
         }      

    }
}
