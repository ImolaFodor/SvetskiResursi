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
    public partial class tabelaEtiketa : Form
    {
        
        public tabelaEtiketa()
        {
            InitializeComponent();
        }

        private void prikazUtabeli()
        {
            List<Etiketa> et = new List<Etiketa>();

            //Ucitavanje resursa iz fajla.
            using (Stream stream = File.Open("Etikete.bin", FileMode.Open))
            {
                var formatter = new BinaryFormatter();
                stream.Position = 0;
                while (stream.Position != stream.Length)//potrebno proci od pocetka do kraja fajla!!!
                    et.Add((Etiketa)formatter.Deserialize(stream));
                stream.Close();
            }

            foreach (Etiketa etik in et)
            {
                
                dataGridView1.Rows.Add(new object[] {etik.oznaka, etik.opis});

            }
        }

        private void tabelaEtiketa_Load(object sender, EventArgs e)
        {
            prikazUtabeli();
        }


        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Etiketa et1 = new Etiketa();
            
            if (!dataGridView1.AreAllCellsSelected(true))
            {
                oz.Text = "";
                boja.BackColor = Color.White;
                op.Text = "";
                
            }

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[0].Value != null)
                {
                    string TabOz = row.Cells[0].Value.ToString();

                    using (Stream stream = File.Open("Etikete.bin", FileMode.Open))
                    {
                        var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                        while (stream.Position != stream.Length)
                        {
                            et1 = ((Etiketa)formatter.Deserialize(stream));
                            if (et1.oznaka.Equals(TabOz))
                            {
                                oz.Text = et1.oznaka;
                                boja.BackColor = et1.boja;
                                op.Text = et1.opis;                                

                            }

                        }
                        stream.Close();
                    }
                }
            }
        }

        private void Izmeni_Click(object sender, EventArgs e)
        {
            List<Etiketa> et = new List<Etiketa>();

            using (Stream stream = File.Open("Etikete.bin", FileMode.Open))
            {
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                
                while (stream.Position != stream.Length)
                {
                    et.Add(((Etiketa)formatter.Deserialize(stream)));

                }

               stream.SetLength(0); //valjda ce ovo izbrisati sve iz datoteke :O

                //sada u LISTI trazim zeljeni resurs i menjam ga.
                foreach (Etiketa tr in et)
                {
                    if (tr.oznaka.Equals(oz.Text))
                    {
                        try
                        {
                            
                         tr.opis = op.Text;
                         tr.boja = boja.BackColor;
                            
                        }
                        catch (Exception ex)
                        {
                            Console.Write("Greska");
                        }
                    }
                }

                dataGridView1.Rows.Clear(); //brisanje prethodnog sadrzaja, zbog novog upisa
                foreach (Etiketa etiketa in et)
                {
                    dataGridView1.Rows.Add(etiketa.oznaka, etiketa.opis);

                }

                foreach (Etiketa etiketa in et)
                {
                    formatter.Serialize(stream, etiketa); //nadam se da ga upisuje na isto mesto, a ne na kraj :O

                }

                stream.Close();
            }
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            List<Etiketa> et2 = new List<Etiketa>();

            dodajEtiketu dr = new dodajEtiketu();//Form1.getInstance());
            dr.ShowDialog();

            //Ucitavanje resursa iz fajla.
            using (Stream stream = File.Open("Etikete.bin", FileMode.Open))
            {
                var formatter = new BinaryFormatter();
                stream.Position = 0;
                while (stream.Position != stream.Length)//potrebno proci od pocetka do kraja fajla!!!
                    et2.Add((Etiketa)formatter.Deserialize(stream));
                stream.Close();
            }

            dataGridView1.Rows.Clear(); //brisanje prethodnog sadrzaja, zbog novog upisa
            foreach(Etiketa etiketa in et2)
            {

                dataGridView1.Rows.Add(etiketa.oznaka, etiketa.opis);

            }
        }

        private void Brisi_Click(object sender, EventArgs e)
        {
            List<Etiketa> ee = new List<Etiketa>();

            using (Stream stream = File.Open("Etikete.bin", FileMode.Open))
            {
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                while (stream.Position != stream.Length)
                {
                    ee.Add(((Etiketa)formatter.Deserialize(stream)));

                }

                stream.SetLength(0); //valjda ce ovo izbrisati sve iz datoteke :O

                //sada u LISTI trazim zeljenu etiketu i brisemo.
                foreach (Etiketa etiketa in ee)
                {
                    if (etiketa.oznaka.Equals(oz.Text))
                    {
                        ee.Remove(etiketa);
                        break;
                    }
                }

                dataGridView1.Rows.Clear(); //brisanje prethodnog sadrzaja, zbog novog upisa
                foreach (Etiketa etiketa in ee)
                {
                    
                    dataGridView1.Rows.Add(etiketa.oznaka, etiketa.opis );

                }

                foreach (Etiketa tr in ee)
                {
                    formatter.Serialize(stream, tr); //nadam se da ga upisuje na isto mesto, a ne na kraj :O
                }

                stream.Close();
            }   
        }

        private void boja_MouseClick(object sender, MouseEventArgs e)
        {
            ColorDialog clc = new ColorDialog();
            if (clc.ShowDialog() == DialogResult.OK)
                boja.BackColor = clc.Color;
        }

        private void trazi_TextChanged(object sender, EventArgs e)
        {
            List<Etiketa> et = new List<Etiketa>();

            using (Stream stream = File.Open("Etikete.bin", FileMode.Open))
            {
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                while (stream.Position != stream.Length)
                {
                    et.Add(((Etiketa)formatter.Deserialize(stream)));

                }
                stream.Close();
            }

            dataGridView1.ClearSelection();

            for (int i = 0; i < et.Count(); i++)
                if (et.ElementAt(i).oznaka.Equals(trazi.Text))
                {
                    dataGridView1.Rows[i].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1[0, i];
                }
                else
                    if (trazi.Text.Equals(""))
                        dataGridView1.ClearSelection();
        
        }
    }
}
