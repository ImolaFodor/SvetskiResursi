﻿using SvetskiResursi;
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
    public partial class Form1 : Form
    {
        List<Resurs> r = new List<Resurs>();
        List<tipResursa> tr = new List<tipResursa>();    
        List<ListViewItem> lista_resursa = new List<ListViewItem>();
        List<Simbol> s = new List<Simbol>();
        Dictionary<PictureBox,string> dPBr = new Dictionary<PictureBox,string>();
        Dictionary<PictureBox, string> dPBtr = new Dictionary<PictureBox, string>();
        Dictionary<PictureBox, string> dPBi = new Dictionary<PictureBox, string>();
        Dictionary<ListViewItem, string> lista_tipova = new Dictionary<ListViewItem, string>();   
        ImageList ListaSlika = new ImageList();
        ListViewItem selection;
        bool waterMarkActive = true;
        public override bool AllowDrop { get; set; }
        public static Form1 instanca = null;


        public Form1()
        {
            initialize();
            instanca = this;
        }

        public void initialize()
        {
            InitializeComponent();
            List<tipResursa> trr = new List<tipResursa>();

            if (!File.Exists("Resursi.bin"))
                File.Create("Resursi.bin");

            if (!File.Exists("Tipovi.bin"))
                File.Create("Tipovi.bin");

            if (!File.Exists("Etikete.bin"))
                File.Create("Etikete.bin");

            if (!File.Exists("Simboli.bin"))
                File.Create("Simboli.bin");

            if (!File.Equals("Resursi.bin", null) && !File.Equals("Tipovi.bin", null) && !File.Equals("Etikete.bin", null))
            {
                listView1_Fill();
                pbMapa_Fill();
            }

            iscitajTipResursa(trr);
            foreach (tipResursa tip in trr)
            {
                filtriranjeTip.Items.Add(tip.oznaka);

            }

            Watermarks();
            listView1.MouseDown += listView1_MouseDown;
            pbMape.AllowDrop = true;
        }

        public void Watermarks()
        {
            


            this.waterMarkActive = true;
            this.textBox2.ForeColor = Color.Gray;
            this.textBox2.Text = "Unesite tip ili resurs...";

            this.textBox2.GotFocus += (source, e) =>
            {
                if (this.waterMarkActive)
                {
                    this.waterMarkActive = false;
                    this.textBox2.Text = "";
                    this.textBox2.ForeColor = Color.Black;
                }
            };

            this.textBox2.LostFocus += (source, e) =>
            {
                if (!this.waterMarkActive && string.IsNullOrEmpty(this.textBox2.Text))
                {
                    this.waterMarkActive = true;
                    this.textBox2.Text = "Unesite tip ili resurs...";
                    this.textBox2.ForeColor = Color.Gray;
                }
            };
        }


        //DRAG&DROP
        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            selection = listView1.GetItemAt(e.X, e.Y);
            if(selection != null && selection.ImageIndex!=-1)
            {
                Bitmap img = (Bitmap)ListaSlika.Images[selection.ImageIndex];
                listView1.DoDragDrop(img, DragDropEffects.Copy);
            }
        }


        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = new PictureBox();
            pb.Parent = pbMape;

            Point po = PointToClient(new Point(e.X - 300, e.Y - 75));
            pb.Location = po;

            ListViewItem dragitem = selection;
            pb.BackgroundImage = ListaSlika.Images[dragitem.ImageIndex];
            pb.Tag = dragitem;

            pb.BackgroundImageLayout = ImageLayout.Stretch;
            pb.Height = pb.Width = 45;
            pb.BringToFront();

            Simbol simbol = new Simbol();
            simbol.lokacija = pb.Location;
            simbol.slika = (Bitmap)ListaSlika.Images[selection.ImageIndex];
     
            ListViewItem lvi = (ListViewItem)pb.Tag;
            Resurs r = (Resurs)lvi.Tag;
            simbol.oznaka = r.oznaka;
            simbol.ime = r.ime;
            simbol.opis = r.opis;
            simbol.tipR = r.tipResursa;
            String etikete = string.Join(",", r.oz_etiketa.ToArray());
            simbol.etiketa = etikete;
            simbol.datum = r.datum_kao;
            

            String detalji = "Oznaka: " + r.oznaka + Environment.NewLine +
                               "Naziv:   " + r.ime + Environment.NewLine +
                             "Tip:      " + r.tipResursa + Environment.NewLine +
                             "Datum otkrivanja:   " + r.datum_kao.ToString() + Environment.NewLine +
                             "Tagovi:   " + etikete + Environment.NewLine +
                             "Opis:    " + r.opis;

            new ToolTip().SetToolTip(pb, detalji);

            dPBr.Add(pb, r.oznaka);
            dPBtr.Add(pb, r.tipResursa);

            using (Stream stream = new FileStream("Simboli.bin", FileMode.Append, FileAccess.Write, FileShare.None))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, simbol);
                stream.Close();
            }

            }
           

        

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            // If the data is a file or a bitmap, display the copy cursor.
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
                //label23.Text = "draaag";
            }
            else
            {
                e.Effect = DragDropEffects.None;
                //label23.Text = "no drag";
            }

        }

        //DRAG&DROP


        private void dodavanjeTipaResursaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dodajTipResursa dlg1 = new dodajTipResursa();
            dlg1.ShowDialog();
            filtriranjeTip.Items.Clear();
            List<tipResursa> trr = new List<tipResursa>();
            iscitajTipResursa(trr);
            foreach (tipResursa tip in trr)
            {
                filtriranjeTip.Items.Add(tip.oznaka);

            }
            RefreshList();
        }

        private void dodavanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dodajEtiketu dlg2 = new dodajEtiketu();
            dlg2.ShowDialog();
        }

        private void dodavanjeResursaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajResurs dlg3 = new DodajResurs(this);
            dlg3.ShowDialog();
        }


        private void tabelaPrikazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelaPrikaza tbl = new TabelaPrikaza(this);
            
            tbl.ShowDialog();
            dPBi.Clear();
            dPBr.Clear();
            dPBtr.Clear();
            this.pbMapa_Fill();
        }

        public static Form1 getInstance()
        {
            return instanca;
        } 

        public void listView1_Fill()
        {

            tr.Clear();
            r.Clear();
            ListaSlika.Dispose();
            using (Stream stream = File.Open("Resursi.bin", FileMode.Open))
            {
                var formatter = new BinaryFormatter();
                while (stream.Position != stream.Length)//potrebno proci od pocetka do kraja fajla!!!
                    r.Add((Resurs)formatter.Deserialize(stream));
                stream.Close();
            }

            using (Stream stream = File.Open("Tipovi.bin", FileMode.Open))
            {
                var formatter = new BinaryFormatter();
                while (stream.Position != stream.Length)//potrebno proci od pocetka do kraja fajla!!!
                    tr.Add((tipResursa)formatter.Deserialize(stream));
                stream.Close();
            }

            int i = -1;
            foreach(tipResursa tre in tr){
                /*listView1.View = View.Details;
                ColumnHeader header = new ColumnHeader();
                header.Text = "";
                header.Name = "col1";
                listView1.Columns.Add(header);
                listView1.HeaderStyle = ColumnHeaderStyle.None;*/
                ListViewItem tresurs = new ListViewItem();
                tresurs.Text =tre.oznaka;
                tresurs.Tag = tre;
                listView1.Items.Add(tresurs);
                
                
                foreach (Resurs re in r)
                 {
                     if (re.ikonica == null)
                     {
                         ListaSlika.Images.Add(tre.ikonica);
                         i++;
                     }
                     else
                     {
                         ListaSlika.Images.Add(re.ikonica);
                         i++;
                     }
                    
                     listView1.SmallImageList = ListaSlika;

                     
                    if(tre.oznaka==re.tipResursa)
                    {
                        listView1.View = View.List;
                        ListViewItem resurs = new ListViewItem();
                        resurs.Text = re.ime;
                        resurs.ImageIndex =i;
                        resurs.Tag = re;
                        listView1.Items.Add(resurs);
                        lista_tipova.Add(resurs,tre.oznaka );
                        lista_resursa.Add(resurs);

                    }
                    
                }
                
            }
        }

        public void pbMapa_Fill()
        {
            dPBi.Clear();
            dPBr.Clear();
            dPBtr.Clear();
            List<Simbol> ls = new List<Simbol>();
            using (Stream stream = File.Open("Simboli.bin", FileMode.Open))
            {
                
                var formatter = new BinaryFormatter();
                while (stream.Position != stream.Length)//potrebno proci od pocetka do kraja fajla!!!
                    ls.Add((Simbol)formatter.Deserialize(stream));
                stream.Close();
            }

                foreach(Simbol sim in ls)
                {
                    PictureBox pb = new PictureBox();
                    pb.Parent = pbMape;

                    Point po = sim.lokacija;
                    pb.Location = po;

                    pb.BackgroundImage = sim.slika;
                    pb.BackgroundImageLayout = ImageLayout.Stretch;
                    pb.Height = pb.Width = 45;

                    string etikete=" ";
                    if (sim.etiketa != null)
                    {
                        etikete = string.Join(",", sim.etiketa.ToArray());
                    }
                    else
                    {
                        sim.etiketa = " ";
                    }
                    String detalji = "Oznaka: " + sim.oznaka + Environment.NewLine +
                                   "Naziv:   " + sim.ime + Environment.NewLine +
                                 "Tip:      " + sim.tipR + Environment.NewLine +
                                 "Datum otkrivanja:   " + sim.datum + Environment.NewLine+
                                 "Tagovi:   " + etikete + Environment.NewLine +
                                 "Opis:    " + sim.opis;
                    new ToolTip().SetToolTip(pb, detalji);
                
                    dPBr.Add(pb, sim.oznaka);
                    dPBtr.Add(pb, sim.tipR);
                    dPBi.Add(pb, sim.ime);
                }
        }

        private void RefreshButtonClick(object sender, EventArgs e)
        {
            RefreshList();
            
        }


        public void RefreshList()
        {
            foreach (ListViewItem item in listView1.Items)
                listView1.Items.Remove(item);

            lista_tipova.Clear();
            lista_resursa.Clear();

            listView1_Fill();
        }

        private void trazenje_TextChanged(object sender, EventArgs e)
        {
            listView1.SelectedItems.Clear();
            string trazeni = textBox2.Text;
            if (trazeni.Equals("")) {
                fOz.Text = "";
                fIme.Text = "";
                fTip.Text = "";
                prikazIkonice.BackgroundImage = null;
            }

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].Selected = false;
                if (listView1.Items[i].Text == trazeni)
                {
                    listView1.Select();
                    listView1.Items[i].Selected = true;
                }
            }

            foreach (KeyValuePair<PictureBox, string> spb in dPBi)
            {
                spb.Key.BorderStyle = BorderStyle.None;
                if (spb.Value == trazeni)
                {
                    spb.Key.BorderStyle = BorderStyle.Fixed3D;

                }

            }
            if (textBox2.Text == "")
            {
                this.waterMarkActive = true;
                this.textBox2.LostFocus += (source, ee) =>
                {
                    if (!this.waterMarkActive && string.IsNullOrEmpty(this.textBox2.Text))
                    {
                        this.waterMarkActive = true;
                        this.textBox2.Text = "Unesite tip ili resurs...";
                        this.textBox2.ForeColor = Color.Gray;
                    }
                };
            }

        }

        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabelaTipovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabelaTipova tbl = new tabelaTipova();
            tbl.ShowDialog();
            this.RefreshList();
            filtriranjeTip.Items.Clear();
            List<tipResursa> trr = new List<tipResursa>();
            iscitajTipResursa(trr);
            foreach (tipResursa tip in trr)
            {
                filtriranjeTip.Items.Add(tip.oznaka);

            }

        }

        private void tabelaEtiketaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabelaEtiketa tbl = new tabelaEtiketa();
            tbl.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fOz_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Resurs> re= new List<Resurs>();
                using (Stream stream = File.Open("Resursi.bin", FileMode.Open))
            {
                var formatter = new BinaryFormatter();
                while (stream.Position != stream.Length)//potrebno proci od pocetka do kraja fajla!!!
                    re.Add((Resurs)formatter.Deserialize(stream));
                stream.Close();
            }

                for(int i=0; i<listView1.Items.Count; i++){
                    if (listView1.Items[i].Selected)
                    {
                        foreach (Resurs r in re)
                        {

                            if (listView1.Items[i].Text == r.ime)
                            {
                                fOz.Text = r.oznaka;
                                fIme.Text=r.ime;
                                fTip.Text = r.tipResursa;
                                prikazIkonice.BackgroundImage = r.ikonica;
                                break;
                            }
                            else
                            {
                                fOz.Text = "";
                                fIme.Text = "";
                                fTip.Text = "";
                                prikazIkonice.BackgroundImage = null;
                            }
                        }

                        foreach (KeyValuePair<PictureBox, string> spb in dPBi)
                        {
                            spb.Key.BorderStyle = BorderStyle.None;
                            if (spb.Value == listView1.Items[i].Text)
                            {
                                spb.Key.BorderStyle = BorderStyle.Fixed3D;

                            }else
                                spb.Key.BorderStyle = BorderStyle.None;

                        }
                    }

                }
                
            
        }

        private void pomocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void onlineHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "..\\..\\Resources\\Help projects\\SR.chm", HelpNavigator.Topic, "O aplikaciji.htm");
        }

        private void tutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tut1 prvi = new Tut1();
            var main = this.Location;
            prvi.Location = new Point((main.X + 100), main.Y+60);
            if (prvi.ShowDialog() == DialogResult.OK)
            {
                Tut2 drugi = new Tut2();
                drugi.Location = new Point((main.X + 190), main.Y + 60);
                drugi.ShowDialog();

            }

        }

        private void iscitajTipResursa(List<tipResursa> tr)
        {
            using (Stream stream = File.Open("Tipovi.bin", FileMode.Open))
            {
                var formatter = new BinaryFormatter();
                while (stream.Position != stream.Length)
                    tr.Add((tipResursa)formatter.Deserialize(stream));
                stream.Close();
            }
        }

        private void filtriranjeTip_TextChanged(object sender, EventArgs e)
        {
            if (filtriranjeTip.Text.Equals(""))
            {
                RefreshList();
            }

            string trazeni = filtriranjeTip.Text;


            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Text.Equals(trazeni))
                {
                    listView1.Items.Clear();
                    foreach (KeyValuePair<ListViewItem, string> slvi in lista_tipova)
                    {

                        if (slvi.Value == trazeni)
                        {
                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = slvi.Key.Text;
                            lvi.ImageIndex = slvi.Key.ImageIndex;
                            lvi.Tag = slvi.Key;
                            listView1.Items.Add(lvi);
                        }
                    }

                    foreach (KeyValuePair<PictureBox, string> spb in dPBtr)
                    {
                        spb.Key.BorderStyle = BorderStyle.None;
                        if (spb.Value == trazeni)
                        {
                            spb.Key.BorderStyle = BorderStyle.Fixed3D;
                        }

                    }

                }

            }

        }

        private void filtriranjeTip_MouseClick(object sender, MouseEventArgs e)
        {
            RefreshList();
        }
       
    }
}