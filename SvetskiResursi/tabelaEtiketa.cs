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
        List<Etiketa> et = new List<Etiketa>();

        public tabelaEtiketa()
        {
            InitializeComponent();
        }

        private void prikazUtabeli()
        {
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
            Etiketa et = new Etiketa();

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
                            et = ((Etiketa)formatter.Deserialize(stream));
                            if (et.oznaka.Equals(TabOz))
                            {
                                oz.Text = et.oznaka;
                                boja.BackColor = et.boja;
                                op.Text = et.opis;                                

                            }

                        }
                        stream.Close();
                    }
                }
            }
        }
    }
}
