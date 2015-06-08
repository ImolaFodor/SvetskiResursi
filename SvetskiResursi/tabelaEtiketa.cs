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
        public static bool pritisnutoIzmena = false;

        public tabelaEtiketa()
        {
            //this.BackColor = System.Drawing.ColorTranslator.FromHtml("#7A7F01");
            InitializeComponent();
            groupBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#E6E68A");
            detalji.BackColor = System.Drawing.ColorTranslator.FromHtml("#E6E68A");
            //dataGridView1.GridColor = System.Drawing.ColorTranslator.FromHtml("#7A7F01");
            dataGridView1.BorderStyle = BorderStyle.None;
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

        public void ocisti_filter()
        {
            if (!cbFilter.Text.Equals(""))
                cbFilter.Text = "";
        }

        private void tabelaEtiketa_Load(object sender, EventArgs e)
        {
            prikazUtabeli();
        }

        private void iscitajEtikete(List<Etiketa> et2){

            using (Stream stream = File.Open("Etikete.bin", FileMode.Open))
            {
                var formatter = new BinaryFormatter();
                stream.Position = 0;
                while (stream.Position != stream.Length)//potrebno proci od pocetka do kraja fajla!!!
                    et2.Add((Etiketa)formatter.Deserialize(stream));
                stream.Close();
            }
        }

        public static void upis(Etiketa etiketa, DataGridView dgv)
        {                              
           dgv.Rows.Add(etiketa.oznaka, etiketa.opis );

        }

        //prikaz selektovanog reda
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

        //Izmena sadrzaja
        private void Izmeni_Click(object sender, EventArgs e)
        {
            pritisnutoIzmena = true;
            List<Etiketa> etk = new List<Etiketa>();

            dodajEtiketu de = new dodajEtiketu(this);
            de.oznaka.Enabled = false;
            de.Text = "Izmena etikete";

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[0].Value != null)
                {
                    string TabOz = row.Cells[0].Value.ToString();

                    iscitajEtikete(etk);

                    foreach (Etiketa et in etk)
                        if (et.oznaka.Equals(TabOz))
                        {
                            de.oznaka.Text = et.oznaka;
                            de.opis.Text = et.opis;
                            de.lBoja.BackColor = et.boja;
                        }
                }
            }
            de.ShowDialog();
        }

        //Dodavanje nove etikete
        private void Dodaj_Click(object sender, EventArgs e)
        {
            List<Etiketa> et2 = new List<Etiketa>();

            dodajEtiketu dr = new dodajEtiketu(this);//Form1.getInstance());
            dr.ShowDialog();

            //Ucitavanje resursa iz fajla.
            iscitajEtikete(et2);

            dataGridView1.Rows.Clear(); //brisanje prethodnog sadrzaja, zbog novog upisa
            foreach(Etiketa etiketa in et2)
            {

                upis(etiketa,dataGridView1);

            }

            ocisti_filter();
        }

        //Brisanje etikete
        private void Brisi_Click(object sender, EventArgs e)
        {
            UpitBrisanje bris = new UpitBrisanje();
            if (bris.ShowDialog() == DialogResult.OK)
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
                        upis(etiketa, dataGridView1);
                    }

                    foreach (Etiketa tr in ee)
                    {
                        formatter.Serialize(stream, tr); //Ponovni upis u datoteku
                    }

                    stream.Close();
                }

                ocisti_filter();
            }
            else
                bris.Close();
        }

        //Menjanje boje
        private void boja_MouseClick(object sender, MouseEventArgs e)
        {
            ColorDialog clc = new ColorDialog();
            if (clc.ShowDialog() == DialogResult.OK)
                boja.BackColor = clc.Color;
        }

        //Pretraga
        private void trazi_TextChanged(object sender, EventArgs e)
        {
            List<Etiketa> et = new List<Etiketa>();

           iscitajEtikete(et);

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

        private void cbFilter_TextChanged(object sender, EventArgs e)
        {
            List<Etiketa> Lr = new List<Etiketa>();

            iscitajEtikete(Lr); //napravila gore funkciju

            dataGridView1.ClearSelection();
            dataGridView1.Rows.Clear();

            for (int i = 0; i < Lr.Count(); i++)
                if (Lr.ElementAt(i).oznaka.Substring(0, 1).Equals(cbFilter.Text) || Lr.ElementAt(i).oznaka.Equals(cbFilter.Text))
                {
                    
                    upis(Lr.ElementAt(i),dataGridView1);
                    

                    if (!cbFilter.Items.Contains(Lr.ElementAt(i).oznaka))
                        cbFilter.Items.Add(Lr.ElementAt(i).oznaka);

                    dataGridView1.Rows[0].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1[0, 0];

                }
                else
                    if (cbFilter.Text.Equals(""))
                    {
                        dataGridView1.Rows.Clear();

                        foreach (Etiketa etik in Lr)
                        {
                            upis(etik,dataGridView1);
                            cbFilter.Items.Remove(etik.oznaka);
                        }
                    }
        }

        private void cbFilter_Leave(object sender, EventArgs e)
        {
           // cbFilter.Text = "";
        }

        private void trazi_Click(object sender, EventArgs e)
        {
            if (trazi.Text.Equals(""))
                dataGridView1.ClearSelection();

            ocisti_filter();
        }

        private void op_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(op, op.Text);
        }

        private void trazi_MouseHover(object sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();
            tp.SetToolTip(this.trazi, "Unesite celu oznaku tipa");
        
        }

        private void cbFilter_MouseHover(object sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();
            tp.SetToolTip(this.cbFilter, "Unesite oznaku tipa");
        
        }
    }
}
