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
        List<Resurs> r2 = new List<Resurs>();

        public tabelaPrikaza()   
        {
            InitializeComponent();
            
        }

        private void prikazUtabeli()
        {
            //Ucitavanje resursa iz fajla.
            using (Stream stream = File.Open("Resursi.bin", FileMode.Open))
            {
                var formatter = new BinaryFormatter();
                stream.Position = 0;
                while (stream.Position != stream.Length)//potrebno proci od pocetka do kraja fajla!!!
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


        private void tabelaPrikaza_Load(object sender, EventArgs e)
        {

            prikazUtabeli();

        }

        private void ocisti_filter()
        {
            if (!cbFilter.Text.Equals(""))
                cbFilter.Text = "";
        }

        private void iscitavanje(List<Resurs> Lr){

             using (Stream stream = File.Open("Resursi.bin", FileMode.Open))
            {
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                while (stream.Position != stream.Length)
                {
                    Lr.Add(((Resurs)formatter.Deserialize(stream)));

                }
                stream.Close();
            }
        }

        private void upis(Resurs resurs)
        {
            etikete = string.Join(",", resurs.oz_etiketa.ToArray());

            dataGridView1.Rows.Add(resurs.oznaka, resurs.ime, resurs.tipResursa, resurs.opis, resurs.ikonica,
                resurs.jedinica_mere, resurs.cena, resurs.datum_kao, etikete);


        }

       
        // ispis selektovanog reda
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Resurs tr = new Resurs();

            if (!dataGridView1.AreAllCellsSelected(true))
            {
                ttOz.Text = "";
                ttIm.Text = "";
                ttTip.Text = "";
                ttOp.Text = "";
                ttObn.Text = "";
                ttStv.Text = "";
                ttEkspl.Text = "";
                ttF.Text = "";
                ttCen.Text = "";
                ttJm.Text = "";
                ttEtik.Text = "";
                tabIm.Image = null;
                ttDatum.Text = "";
            }

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[0].Value != null)
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
                                ttEtik.Text = string.Join(",", tr.oz_etiketa.ToArray());
                                tabIm.Image = tr.ikonica;
                                ttDatum.Text = tr.datum_kao;

                            }

                        }
                        stream.Close();
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        //Dodavanje novog resursa
        private void tblD_Click(object sender, EventArgs e)
        {
            dodajResurs dr = new dodajResurs(Form1.getInstance());
            dr.ShowDialog();
            
            //Ucitavanje resursa iz fajla.
            using (Stream stream = File.Open("Resursi.bin", FileMode.Open))
            {
                var formatter = new BinaryFormatter();
                stream.Position = 0;
                while (stream.Position != stream.Length)//potrebno proci od pocetka do kraja fajla!!!
                    r2.Add((Resurs)formatter.Deserialize(stream));
                stream.Close();
            }

            dataGridView1.Rows.Clear(); //brisanje prethodnog sadrzaja, zbog novog upisa
            foreach (Resurs resurs in r2)
            {
                upis(resurs);
            }

            ocisti_filter();
        }

        //Izmena sadrzaja
        private void tblI_Click(object sender, EventArgs e)
        {
             List<Resurs> Lr = new List<Resurs>();

            using (Stream stream1 = File.Open("Resursi.bin", FileMode.Open))
            {
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                
                while (stream1.Position != stream1.Length)
                {
                    Lr.Add(((Resurs)formatter.Deserialize(stream1)));

                }

                stream1.SetLength(0); //brise se postojeci sadrzaj u datoteci

                //sada u LISTI trazim zeljeni resurs i menjam ga.
                foreach(Resurs tr in Lr){
                    if (tr.oznaka.Equals(ttOz.Text))
                    {
                        try
                        {
                            tr.ime = ttIm.Text;
                            tr.opis = ttOp.Text;
                            tr.ikonica = tabIm.Image;
                            tr.pojavljivanje = ttF.Text;
                            tr.strateska_vaznost = ttStv.Text;
                            tr.tipResursa = ttTip.Text;
                            tr.jedinica_mere = ttJm.Text;
                            tr.obnovljivo = ttObn.Text;
                            tr.cena = ttCen.Text;
                   
                        }
                        catch (Exception ex)
                        {
                            Console.Write("Greska");
                        }
                    }
                }

                dataGridView1.Rows.Clear(); //brisanje prethodnog sadrzaja, zbog novog upisa
                foreach (Resurs resurs in Lr)
                {
                    upis(resurs);
                }

                foreach (Resurs tr in Lr)
                {
                    formatter.Serialize(stream1, tr); //nadam se da ga upisuje na isto mesto, a ne na kraj :O
                }

                stream1.Close();
            }

            ocisti_filter();
        }

        //Brisanje resursa
        private void tblB_Click(object sender, EventArgs e)
        {
            List<Resurs> Lr = new List<Resurs>();

            using (Stream stream = File.Open("Resursi.bin", FileMode.Open))
            {
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                while (stream.Position != stream.Length)
                {
                    Lr.Add(((Resurs)formatter.Deserialize(stream)));

                }

                stream.SetLength(0);

                //sada u LISTI trazim zeljeni resurs i brise ga.
                foreach (Resurs tr in Lr)
                {
                    if (tr.oznaka.Equals(ttOz.Text))
                    {
                        Lr.Remove(tr);
                        break;
                    }
                }

                dataGridView1.Rows.Clear(); //brisanje prethodnog sadrzaja, zbog novog upisa
                foreach (Resurs resurs in Lr)
                {
                    upis(resurs);
                }

                foreach (Resurs tr in Lr)
                {
                    formatter.Serialize(stream, tr); 
                }

                stream.Close();
            }

            ocisti_filter();
        }

        //Pretraga
        private void tbTrazi_TextChanged(object sender, EventArgs e)
        {
             List<Resurs> Lr = new List<Resurs>();

             iscitavanje(Lr);

             dataGridView1.ClearSelection();

             for (int i = 0; i < Lr.Count(); i++)
                 if (Lr.ElementAt(i).oznaka.Equals(tbTrazi.Text) || Lr.ElementAt(i).ime.Equals(tbTrazi.Text))
                 {
                     dataGridView1.Rows[i].Selected = true;
                     dataGridView1.CurrentCell = dataGridView1[0,i];
                 }
                 else
                     if (tbTrazi.Text.Equals(""))
                         dataGridView1.ClearSelection();

             
        }

        //Deselektovanje
        private void tbTrazi_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbTrazi.Text.Equals(""))
                dataGridView1.ClearSelection();

            ocisti_filter();
        }


        public void OsveziTabelu()
        {

            dataGridView1.Rows.Clear(); //brisanje prethodnog sadrzaja, zbog novog upisa
            foreach (Resurs resurs in r)
            {
                upis(resurs);
            }
        }

        //izmena slike
        private void tabIm_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fname = ofd.FileName;
                Image img = new Bitmap(fname);
                tabIm.Image = img;
            }
        }

        //Filtriranje
        private void cbFilter_TextChanged(object sender, EventArgs e)
        {
            List<Resurs> Lr = new List<Resurs>();

            iscitavanje(Lr); //napravila gore funkciju

            dataGridView1.ClearSelection();
            dataGridView1.Rows.Clear();

            for (int i = 0; i < Lr.Count(); i++)
                if (Lr.ElementAt(i).oznaka.Substring(0, 1).Equals(cbFilter.Text) || Lr.ElementAt(i).oznaka.Equals(cbFilter.Text)) // ||
                   // Lr.ElementAt(i).ime.Substring(0, 1).Equals(cbFilter.Text) || Lr.ElementAt(i).ime.Equals(cbFilter.Text))
                {

                    upis(Lr.ElementAt(i));
                   
                    if(!cbFilter.Items.Contains(Lr.ElementAt(i).oznaka))
                        cbFilter.Items.Add(Lr.ElementAt(i).oznaka);
                    dataGridView1.Rows[0].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1[0, 0];
                   
                }
                else
                    if (cbFilter.Text.Equals(""))
                    {
                        dataGridView1.Rows.Clear();
                        
                        foreach (Resurs resurs in Lr)
                        {
                            upis(resurs);
                            cbFilter.Items.Remove(resurs.oznaka);
                        }
                    }
        }

        //Da kad izadjem iz polja ne ostane nista upisano
        private void cbFilter_Leave(object sender, EventArgs e)
        {
            //cbFilter.Text = "";
        }

        }
    }

