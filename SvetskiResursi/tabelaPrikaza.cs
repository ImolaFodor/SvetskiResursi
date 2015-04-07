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
using System.Windows.Forms;

namespace SvetskiResursi
{
    public partial class tabelaPrikaza : Form
    {
        public string etikete;
        List<Resurs> r = new List<Resurs>();
        public tabelaPrikaza()   
        {
            InitializeComponent();
            
            
        }

        private void tabelaPrikaza_Load(object sender, EventArgs e)
        {
            
            //Ucitavanje resursa iz fajla.
            using (Stream stream = File.Open("Resursi.bin", FileMode.Open))
            {
                var formatter = new BinaryFormatter();
                while(stream.Position != stream.Length)//potrebno proci od pocetka do kraja fajla!!!
                    r.Add((Resurs)formatter.Deserialize(stream));
                stream.Close();
            }

            foreach (Resurs resurs in r)
               {
                   etikete = string.Join(",", resurs.oz_etiketa.ToArray());

                   dataGridView1.Rows.Add(new object[] {resurs.oznaka, resurs.ime, resurs.tipResursa, resurs.opis, resurs.ikonica,
                    resurs.jedinica_mere, resurs.cena, resurs.datum_kao, etikete});

               }

        }

        private void tblI_Click(object sender, EventArgs e)
        {

        }

        private void tblD_Click(object sender, EventArgs e)
        {

        }

        private void tblB_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Resurs tr = new Resurs();

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string TabOz = row.Cells[0].Value.ToString();

                using (Stream stream = File.Open("Resursi.bin", FileMode.Open))
                {
                    var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    while (stream.Position != stream.Length)
                    {
                        tr = ((Resurs)formatter.Deserialize(stream));
                        if (tr.oznaka.Equals(TabOz))
                        {
                            ttOz.Text = tr.oznaka;
                            ttIm.Text = tr.ime;
                            ttTip.Text = tr.tipResursa;
                            ttOp.Text = tr.opis;
                            ttObn.Text = tr.obnovljivo;
                            ttStv.Text = tr.strateska_vaznost;
                            ttEkspl.Text = tr.eksploatacija;
                            ttF.Text = tr.pojavljivanje;
                            ttCen.Text = tr.cena;
                            ttJm.Text = tr.jedinica_mere;
                            ttEtik.Text = tr.oz_etiketa.ToString();
                            tabIm.Image = tr.ikonica;
                            
                        }

                    }
                    stream.Close();
                }
            }

        }

        private void tbTip_Click(object sender, EventArgs e)
        {

        }

        private void ttDatum_TextChanged(object sender, EventArgs e)
        {

        }

        private void ttObn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
