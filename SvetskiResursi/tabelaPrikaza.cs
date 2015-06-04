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
    public partial class TabelaPrikaza : Form
    {
        public string etikete;
        public static bool pritusnutoIzmeni = false;
        Form1 form = null;

        public TabelaPrikaza(Form1 form1)   
        {
            InitializeComponent();
            form = form1;
            
        }

        private void prikazUtabeli()
        {
            List<Resurs> r = new List<Resurs>();

            //Ucitavanje resursa iz fajla.
            iscitajResurs(r);

            foreach (Resurs resurs in r)
            {
                etikete = string.Join(",", resurs.oz_etiketa.ToArray());

                dataGridView1.Rows.Add(new object[] {resurs.oznaka, resurs.ime, resurs.tipResursa, resurs.opis,
                    resurs.jedinica_mere, resurs.cena, resurs.datum_kao, etikete});

            }
        }


        private void tabelaPrikaza_Load(object sender, EventArgs e)
        {

            prikazUtabeli();

        }

        public void ocisti_filter()
        {
            if (!cbFilter.Text.Equals(""))
                cbFilter.Text = "";
        }

        private void iscitajResurs(List<Resurs> Lr){

             using (Stream stream = File.Open("Resursi.bin", FileMode.Open))
            {
                var formatter = new BinaryFormatter();

                while (stream.Position != stream.Length)
                    Lr.Add(((Resurs)formatter.Deserialize(stream)));

                stream.Close();
            }
        }

        public static void upis(Resurs resurs, DataGridView dgw)
        {
            String etikete = string.Join(",", resurs.oz_etiketa.ToArray());

            dgw.Rows.Add(resurs.oznaka, resurs.ime, resurs.tipResursa, resurs.opis,
                resurs.jedinica_mere, resurs.cena, resurs.datum_kao, etikete);

        }

       
        // ispis selektovanog reda
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            List<Resurs> rss = new List<Resurs>();

            if (!dataGridView1.AreAllCellsSelected(true))
            {
                ttOz.Text = "";
                ttIm.Text = "";
                ttTip.Text = "";
                ttOp.Text = "";
                ttObn.Text = "";
                ttStv.Text = "";
                ttEkspl.Text = "";
                ttFv.Text = "";
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

                    iscitajResurs(rss);

                    foreach(Resurs tr in rss)
                       if (tr.oznaka.Equals(TabOz))
                          {
                            ttOz.Text = tr.oznaka;
                            ttIm.Text = tr.ime;
                            ttTip.Text = tr.tipResursa;
                            ttOp.Text = tr.opis;
                            ttObn.Text = tr.obnovljivo;
                            ttStv.Text = tr.strateska_vaznost;
                            ttEkspl.Text = tr.eksploatacija;
                            ttFv.Text = tr.pojavljivanje;
                            ttCen.Text = tr.cena;
                            ttJm.Text = tr.jedinica_mere;
                            ttEtik.Text = string.Join(",", tr.oz_etiketa.ToArray());
                            tabIm.Image = tr.ikonica;
                            ttDatum.Text = tr.datum_kao;

                         }

               }
          }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.getInstance().RefreshList();
            Close();
        }

        //Dodavanje novog resursa
        private void tblD_Click(object sender, EventArgs e)
        {
            List<Resurs> r2 = new List<Resurs>();
            DodajResurs dr = new DodajResurs(Form1.getInstance(),this);
            dr.ShowDialog();

            
                //Ucitavanje resursa iz fajla.
                iscitajResurs(r2);

                this.dataGridView1.Rows.Clear(); //brisanje prethodnog sadrzaja, zbog novog upisa
                foreach (Resurs resurs in r2)
                {
                    upis(resurs,dataGridView1);
                }

                ocisti_filter();
            
        }

        //Izmena sadrzaja
        private void tblI_Click(object sender, EventArgs e)
        {
            pritusnutoIzmeni = true;
            List<Resurs> tri = new List<Resurs>();

            DodajResurs dr = new DodajResurs(Form1.getInstance(), this);
            dr.oznaka.Enabled = false;
            dr.Text = "Izmena resursa";

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[0].Value != null)
                {
                    string TabOz = row.Cells[0].Value.ToString();

                    iscitajResurs(tri);

                    foreach (Resurs tr in tri)
                    {
                        if (tr.oznaka.Equals(TabOz))
                        {
                            dr.oznaka.Text = tr.oznaka;
                            dr.ime.Text = tr.ime;
                            dr.comboTipResursa.Text = tr.tipResursa;
                            dr.opis.Text = tr.opis;
                            dr.frPon.Text = tr.pojavljivanje;
                            dr.cen.Text = tr.cena;
                            dr.cbMera.Text = tr.jedinica_mere;
                            dr.ikonica.Image = tr.ikonica;
                            dr.vreme.Text = tr.datum_kao;

                            if (tr.eksploatacija.Equals("DA"))
                                dr.rbEkp1.Checked = true;
                            else
                                dr.rbEksp2.Checked = true;

                            if (tr.strateska_vaznost.Equals("DA"))
                                dr.rbSV1.Checked = true;
                            else
                                dr.rbSV2.Checked = true;

                            if (tr.obnovljivo.Equals("DA"))
                                dr.rbObn1.Checked = true;
                            else
                                dr.rbObn2.Checked = true;

                            for (int j = 0; j < dr.etik.Items.Count; j++)
                                for (int i = 0; i < tr.oz_etiketa.Count; i++)
                                    if (dr.etik.Items[j].Equals(tr.oz_etiketa[i]))
                                        dr.etik.SetItemChecked(j, true);
                        }
                    }

                }
            }
            dr.ShowDialog();

        }

        //Brisanje resursa
        private void tblB_Click(object sender, EventArgs e)
        {
            UpitBrisanje bris = new UpitBrisanje();
            if (bris.ShowDialog() == DialogResult.OK)
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
                        upis(resurs, dataGridView1);
                    }

                    foreach (Resurs tr in Lr)
                    {
                        formatter.Serialize(stream, tr);
                    }

                    stream.Close();
                }

                

                ocisti_filter();
                //form.pbMapa_Fill();
            
            }
            else //if(bris.ShowDialog()== DialogResult.Cancel)
                bris.Close();

        }

        //Pretraga
        private void tbTrazi_TextChanged(object sender, EventArgs e)
        {
             List<Resurs> Lr = new List<Resurs>();

             iscitajResurs(Lr);

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
            List<Resurs> r = new List<Resurs>();

            dataGridView1.Rows.Clear(); //brisanje prethodnog sadrzaja, zbog novog upisa
            foreach (Resurs resurs in r)
            {
                upis(resurs,dataGridView1);
            }
        }


        //Filtriranje
        private void cbFilter_TextChanged(object sender, EventArgs e)
        {
            List<Resurs> Lr = new List<Resurs>();

            iscitajResurs(Lr); //napravila gore funkciju

            dataGridView1.ClearSelection();
            dataGridView1.Rows.Clear();

            for (int i = 0; i < Lr.Count(); i++)
                if (Lr.ElementAt(i).oznaka.Substring(0, 1).Equals(cbFilter.Text) || Lr.ElementAt(i).oznaka.Equals(cbFilter.Text)) // ||
                   // Lr.ElementAt(i).ime.Substring(0, 1).Equals(cbFilter.Text) || Lr.ElementAt(i).ime.Equals(cbFilter.Text))
                {

                    upis(Lr.ElementAt(i),dataGridView1);
                   
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
                            upis(resurs,dataGridView1);
                            cbFilter.Items.Remove(resurs.oznaka);
                        }
                    }
        }


        private void ttOp_MouseHover(object sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();
            tp.SetToolTip(ttOp, ttOp.Text);
        }

        }
    }

