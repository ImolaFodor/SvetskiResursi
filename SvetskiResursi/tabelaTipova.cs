using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace SvetskiResursi
{
    public partial class tabelaTipova : Form
    {
        List<tipResursa> tp = new List<tipResursa>();
        List<tipResursa> tp2 = new List<tipResursa>();
        
        public tabelaTipova()
        {
            InitializeComponent();
        }

        private void prikazUtabeli()
        {
            //Ucitavanje resursa iz fajla.
            using (Stream stream = File.Open("Tipovi.bin", FileMode.Open))
            {
                var formatter = new BinaryFormatter();
                stream.Position = 0;
                while (stream.Position != stream.Length)//potrebno proci od pocetka do kraja fajla!!!
                    tp.Add((tipResursa)formatter.Deserialize(stream));
                stream.Close();
            }

            foreach (tipResursa tip in tp)
            {
                dataGridView1.Rows.Add(new object[] { tip.oznaka, tip.ime, tip.ikonica, tip.opis, });

            }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Brisi_Click(object sender, EventArgs e)
        {
            List<tipResursa> Lr = new List<tipResursa>();

            using (Stream stream = File.Open("Tipovi.bin", FileMode.Open))
            {
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                while (stream.Position != stream.Length)
                {
                    Lr.Add(((tipResursa)formatter.Deserialize(stream)));

                }

                stream.SetLength(0); //valjda ce ovo izbrisati sve iz datoteke :O

                //sada u LISTI trazim zeljeni resurs i menjam ga.
                foreach (tipResursa tip in Lr)
                {
                    if (tip.oznaka.Equals(ozDT.Text))
                    {
                        Lr.Remove(tip);
                        break;
                    }
                }

                dataGridView1.Rows.Clear(); //brisanje prethodnog sadrzaja, zbog novog upisa
                foreach (tipResursa tip in Lr)
                {
                    dataGridView1.Rows.Add(new object[] { tip.oznaka, tip.ime, tip.ikonica, tip.opis, });

                }

                foreach (tipResursa tp in Lr)
                {
                    formatter.Serialize(stream, tp); //nadam se da ga upisuje na isto mesto, a ne na kraj :O
                }

                stream.Close();
            }   

        }

        private void tabelaTipova_Load(object sender, EventArgs e)
        {
            prikazUtabeli();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            tipResursa tr = new tipResursa();

            if (!dataGridView1.AreAllCellsSelected(true))
            {
                ozDT.Text = "";
                imeDT.Text = "";
                imDT.Image = null;
                opDT.Text = "";
            }

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[0].Value != null)
                {
                    string TabOz = row.Cells[0].Value.ToString();

                    using (Stream stream = File.Open("Tipovi.bin", FileMode.Open))
                    {
                        var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                        while (stream.Position != stream.Length)
                        {
                            tr = ((tipResursa)formatter.Deserialize(stream));
                            if (tr.oznaka.Equals(TabOz))
                            {
                                ozDT.Text = tr.oznaka;
                                imeDT.Text = tr.ime;
                                imDT.Image = tr.ikonica;
                                opDT.Text = tr.opis;

                            }

                        }
                        stream.Close();
                    }
                }
            }
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            dodajTipResursa dr = new dodajTipResursa();//Form1.getInstance());
            dr.ShowDialog();

            //Ucitavanje resursa iz fajla.
            using (Stream stream = File.Open("Tipovi.bin", FileMode.Open))
            {
                var formatter = new BinaryFormatter();
                stream.Position = 0;
                while (stream.Position != stream.Length)//potrebno proci od pocetka do kraja fajla!!!
                    tp2.Add((tipResursa)formatter.Deserialize(stream));
                stream.Close();
            }

            dataGridView1.Rows.Clear(); //brisanje prethodnog sadrzaja, zbog novog upisa
            foreach (tipResursa tip in tp2)
            {

                dataGridView1.Rows.Add( tip.oznaka, tip.ime, tip.ikonica, tip.opis );

            }
        }

        private void Izmeni_Click(object sender, EventArgs e)
        {
             List<tipResursa> Lr = new List<tipResursa>();

             using (Stream stream = File.Open("Tipovi.bin", FileMode.Open))
             {
                 var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                 while (stream.Position != stream.Length)
                 {
                     Lr.Add(((tipResursa)formatter.Deserialize(stream)));

                 }

                 stream.SetLength(0); //valjda ce ovo izbrisati sve iz datoteke :O

                 //sada u LISTI trazim zeljeni resurs i menjam ga.
                 foreach (tipResursa tr in Lr)
                 {
                     if (tr.oznaka.Equals(ozDT.Text))
                     {
                         try
                         {
                             tr.ime = imeDT.Text;
                             tr.opis = opDT.Text;
                             // Ikonica se ne moze menjati
                             // tr.oz_etiketa = string.Join(",", tr.oz_etiketa.ToArray());

                         }
                         catch (Exception ex)
                         {
                             Console.Write("Greska");
                         }
                     }
                 }

                 dataGridView1.Rows.Clear(); //brisanje prethodnog sadrzaja, zbog novog upisa
                 foreach (tipResursa tip in Lr)
                 {
                     dataGridView1.Rows.Add( tip.oznaka, tip.ime, tip.ikonica, tip.opis );

                 }

                 foreach (tipResursa tip in Lr)
                 {
                     formatter.Serialize(stream, tip); //nadam se da ga upisuje na isto mesto, a ne na kraj :O

                 }

                 stream.Close();
             }
        }

        private void trazi_TextChanged(object sender, EventArgs e)
        {
            List<tipResursa> Lr = new List<tipResursa>();

             using (Stream stream = File.Open("Tipovi.bin", FileMode.Open))
             {
                 var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                 while (stream.Position != stream.Length)
                 {
                     Lr.Add(((tipResursa)formatter.Deserialize(stream)));

                 }
                 stream.Close();
             }

             dataGridView1.ClearSelection();

             for (int i = 0; i < Lr.Count(); i++)
                 if (Lr.ElementAt(i).oznaka.Equals(trazi.Text))
                 {
                     dataGridView1.Rows[i].Selected = true;
                     dataGridView1.CurrentCell = dataGridView1[0,i];
                 }
                 else
                     if (trazi.Text.Equals(""))
                         dataGridView1.ClearSelection();
        
        }
    }
}
