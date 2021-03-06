﻿using System;
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
        public static bool pritisnutoIzmeni = false;

        public tabelaTipova()
        {
            //this.BackColor = System.Drawing.ColorTranslator.FromHtml("#7A7F01");
            InitializeComponent();
            pretr.BackColor = System.Drawing.ColorTranslator.FromHtml("#E6E68A");
            detalji.BackColor = System.Drawing.ColorTranslator.FromHtml("#E6E68A");
            dataGridView1.BorderStyle = BorderStyle.None;
        }

        private void prikazUtabeli()
        {
            List<tipResursa> tp = new List<tipResursa>();

            //Ucitavanje resursa iz fajla.
            iscitajTipResurs(tp);

            foreach (tipResursa tip in tp)
            {
                upis(tip, dataGridView1);
            }
        }

        private void tabelaTipova_Load(object sender, EventArgs e)
        {
            prikazUtabeli();
        }

        public void ocisti_filter()
        {
            if (!cbFilter.Text.Equals(""))
                cbFilter.Text = "";
        }

        private void iscitajTipResurs(List<tipResursa> Lr)
        {
            using (Stream stream = File.Open("Tipovi.bin", FileMode.Open))
            {
                var formatter = new BinaryFormatter();

                while (stream.Position != stream.Length)
                    Lr.Add(((tipResursa)formatter.Deserialize(stream)));
                stream.Close();
            }
        }

        private void iscitajResurs(List<Resurs> Lr)
        {

            using (Stream stream = File.Open("Resursi.bin", FileMode.Open))
            {
                var formatter = new BinaryFormatter();

                while (stream.Position != stream.Length)
                    Lr.Add(((Resurs)formatter.Deserialize(stream)));

                stream.Close();
            }
        }

        public static void upis(tipResursa tip, DataGridView dgv)
        {

            dgv.Rows.Add(tip.oznaka, tip.ime, tip.opis);

        }

        //Brisanje tipa
        private void Brisi_Click(object sender, EventArgs e)
        {
            UpitBrisanje bris = new UpitBrisanje();
            List<Resurs> res = new List<Resurs>();

            if (bris.ShowDialog() == DialogResult.OK)
            {
                List<tipResursa> Lr = new List<tipResursa>();

                using (Stream stream = File.Open("Tipovi.bin", FileMode.Open))
                {
                    var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    while (stream.Position != stream.Length)
                    {
                        Lr.Add(((tipResursa)formatter.Deserialize(stream)));

                    }

                    stream.SetLength(0);

                    //sada u LISTI trazim zeljeni tip i brisemo ga.
                    foreach (tipResursa tip in Lr)
                    {
                        if (tip.oznaka.Equals(ozDT.Text))
                        {
                            using (Stream stream1 = File.Open("Resursi.bin", FileMode.Open))
                            {
                                var formatter1 = new BinaryFormatter();

                                while (stream1.Position != stream1.Length)
                                    res.Add(((Resurs)formatter1.Deserialize(stream1)));

                                stream1.SetLength(0);

                                for (int i = 0; i < res.Count; i++)
                                {
                                    if (res[i].tipResursa.Equals(tip.oznaka))
                                    {
                                        res.Remove(res[i]);
                                        i = -1;
                                    }
                                }

                                    foreach (Resurs r in res)
                                        formatter1.Serialize(stream1, r);

                                stream1.Close();
                            }
                           

                            Lr.Remove(tip);
                            break;
                        }
                    }

                    dataGridView1.Rows.Clear(); //brisanje prethodnog sadrzaja, zbog novog upisa
                    foreach (tipResursa tip in Lr)
                    {
                        upis(tip, dataGridView1);
                    }

                    foreach (tipResursa tp in Lr)
                    {
                        formatter.Serialize(stream, tp);
                    }

                    stream.Close();
                }

                ocisti_filter();
            }
            else
                bris.Close();
        }

        //Prikaz selektovanog reda
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            List<tipResursa> tri = new List<tipResursa>();

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

                    iscitajTipResurs(tri);

                         foreach(tipResursa tr in tri)
                            if (tr.oznaka.Equals(TabOz))
                            {
                                ozDT.Text = tr.oznaka;
                                imeDT.Text = tr.ime;
                                imDT.Image = tr.ikonica;
                                opDT.Text = tr.opis;

                            }                        
                    }
                }
            }
        

        //Dodavanje novog tipa
        private void Dodaj_Click(object sender, EventArgs e)
        {
            List<tipResursa> tp2 = new List<tipResursa>();

            dodajTipResursa dr = new dodajTipResursa(Form1.getInstance(),this);
            dr.ShowDialog();

            //Ucitavanje resursa iz fajla.
            iscitajTipResurs(tp2);

            this.dataGridView1.Rows.Clear(); //brisanje prethodnog sadrzaja, zbog novog upisa
            foreach (tipResursa tip in tp2)
            {

                upis(tip, dataGridView1);
            }

            ocisti_filter();
        }

        //Izmena tipa
        private void Izmeni_Click(object sender, EventArgs e)
        {
            pritisnutoIzmeni = true;
            List<tipResursa> tri = new List<tipResursa>();

            dodajTipResursa dtr = new dodajTipResursa(Form1.getInstance(),this);
            dtr.oznaka_tip.Enabled = false;
            dtr.Text = "Izmena tipa resursa";

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[0].Value != null)
                {
                    string TabOz = row.Cells[0].Value.ToString();

                        iscitajTipResurs(tri);

                        foreach(tipResursa tr in tri)
                        if (tr.oznaka.Equals(TabOz))
                        {
                            dtr.oznaka_tip.Text = tr.oznaka;
                            dtr.ime_tip.Text = tr.ime;
                            dtr.opis_tip.Text = tr.opis;
                            dtr.ikonica.BackgroundImage = tr.ikonica;
                        }
                    }
                }
            dtr.ShowDialog();
        }

        //Pretraga
        private void trazi_TextChanged(object sender, EventArgs e)
        {
            List<tipResursa> Lr = new List<tipResursa>();

            iscitajTipResurs(Lr);

            dataGridView1.ClearSelection();

            for (int i = 0; i < Lr.Count(); i++)
                if (Lr.ElementAt(i).oznaka.Equals(trazi.Text))
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
            List<tipResursa> Lr = new List<tipResursa>();

            iscitajTipResurs(Lr); //napravila gore funkciju

            dataGridView1.ClearSelection();
            dataGridView1.Rows.Clear();

            for (int i = 0; i < Lr.Count(); i++)
                if (Lr.ElementAt(i).oznaka.Substring(0, 1).Equals(cbFilter.Text) || Lr.ElementAt(i).oznaka.Equals(cbFilter.Text))
                {

                    upis(Lr.ElementAt(i), dataGridView1);

                    if (!cbFilter.Items.Contains(Lr.ElementAt(i).oznaka))
                        cbFilter.Items.Add(Lr.ElementAt(i).oznaka);
                    dataGridView1.Rows[0].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1[0, 0];

                }
                else
                    if (cbFilter.Text.Equals(""))
                    {
                        dataGridView1.Rows.Clear();

                        foreach (tipResursa resurs in Lr)
                        {
                            upis(resurs, dataGridView1);
                            cbFilter.Items.Remove(resurs.oznaka);
                        }
                    }
        }

        private void trazi_Click(object sender, EventArgs e)
        {
            if (trazi.Text.Equals(""))
                dataGridView1.ClearSelection();

            ocisti_filter();
        }

        private void opDT_MouseHover(object sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();
            tp.SetToolTip(opDT, opDT.Text);

        }

        private void imDT_Click(object sender, EventArgs e)
        {

        }

        private void trazi_MouseHover(object sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();
            tp.SetToolTip(this.trazi,"Unesite celu oznaku tipa");
        }

        private void cbFilter_MouseHover(object sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();
            tp.SetToolTip(this.cbFilter, "Unesite oznaku tipa");
        
        }
    }
}
