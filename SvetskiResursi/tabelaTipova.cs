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
    }
}
