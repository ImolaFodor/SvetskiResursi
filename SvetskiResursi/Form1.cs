using SvetskiResursi;
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
        Dictionary<PictureBox,string> dPBr = new Dictionary<PictureBox,string>();
        Dictionary<PictureBox, string> dPBtr = new Dictionary<PictureBox, string>();
        Dictionary<PictureBox, string> dPBi = new Dictionary<PictureBox, string>();
        Dictionary<Point, string> dPs = new Dictionary<Point, string>();
        Dictionary<PictureBox, Point> dPBl = new Dictionary<PictureBox, Point>();
        Dictionary<ListViewItem, string> lista_tipova = new Dictionary<ListViewItem, string>();   
        ImageList ListaSlika = new ImageList();
        ListViewItem selection;
        bool waterMarkActive = true;
        public override bool AllowDrop { get; set; }
        public static Form1 instanca = null;
        List<PictureBox> glob_pb = new List<PictureBox>();
        List<List<Panel>> glob_paneli = new List<List<Panel>>();

        public Form1()
        {
            initialize();
            Detalji.BackColor = System.Drawing.ColorTranslator.FromHtml("#E6E68A");
            listView1.BackColor = System.Drawing.ColorTranslator.FromHtml("#E6E68A");
            groupBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#E6E68A");
            instanca = this;
           
        }

        public void initialize()
        {
            
            InitializeComponent();
            List<tipResursa> trr = new List<tipResursa>();
            List<Etiketa> et = new List<Etiketa>();
            Etiketa etik = new Etiketa();
            

            if (!File.Exists("Resursi.bin"))
                File.Create("Resursi.bin");

            if (!File.Exists("Tipovi.bin"))
                File.Create("Tipovi.bin");

            if (!File.Exists("Etikete.bin"))
                File.Create("Etikete.bin");

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

            //dodavanje default etikete
            using (Stream stream = File.Open("Etikete.bin", FileMode.Open))
            {
                var formatter = new BinaryFormatter();
                stream.Position = 0;
                while (stream.Position != stream.Length)//potrebno proci od pocetka do kraja fajla!!!
                    et.Add((Etiketa)formatter.Deserialize(stream));

                stream.SetLength(0);
                bool pst = false;

                etik.oznaka = "default";
                etik.boja = Color.White;
                etik.opis = "";

                foreach (Etiketa etiketa in et)
                {
                    if (etiketa.oznaka.Equals(etik.oznaka))
                        pst = true;
                    else
                        pst = false;

                }

                if (pst == false)
                    et.Add(etik);


                foreach (Etiketa etiketa in et)
                {
                    formatter.Serialize(stream, etiketa);

                }

                stream.Close();

            }
            
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
            //pa.Clear();
            Point po = PointToClient(new Point(e.X - 300, e.Y - 75));
            List<Resurs> ri = new List<Resurs>();
            iscitajResurs(ri);
            List<Etiketa> et = new List<Etiketa>();
            using (Stream stream = File.Open("Etikete.bin", FileMode.Open))
            {
                var formatter = new BinaryFormatter();
                while (stream.Position != stream.Length)
                    et.Add((Etiketa)formatter.Deserialize(stream));
                stream.Close();
            }
            ListViewItem dragitem = selection;
            PictureBox pb = new PictureBox();
            List<Panel> pa = new List<Panel>();
            int k = 70;


            foreach (Resurs r in ri)
            {
                    if (dragitem.Text == r.ime)
                    {
                        for (int i = 0; i < et.Count; i++)
                        {
                            if (r.oz_etiketa.Contains(et[i].oznaka))
                            {

                                Panel p = new Panel();
                                p.Tag = dragitem.Text;
                                p.Parent = pbMape;
                                p.Location = po;
                                if(r.oz_etiketa.Count==1)
                                    p.Height = p.Width = 63;
                                else{
                                    p.Height = p.Width = k;
                                    k -= 7;
                                }
                                
                                
                                p.BringToFront();
                                p.BackColor = et[i].boja;
                                pa.Add(p);

                                if (pa.Count == r.oz_etiketa.Count)
                                {
                                    pb.Tag = dragitem;
                                    pb.BackgroundImageLayout = ImageLayout.Stretch;
                                    if (pa.Count == 1)
                                        pb.Height = pb.Width = 63;
                                    else if (pa.Count == 2)
                                        pb.Height = pb.Width = 56;
                                    else if (pa.Count == 3)
                                        pb.Height = pb.Width = 50;
                                    else
                                        pb.Height = pb.Width = 40;

                                    pb.MouseDown += new MouseEventHandler(pb_Click);
                                    pa[pa.Count - 1].Controls.Add(pb);
                                }
                            }
                        }
                    }
                    
                
                }
                glob_paneli.Add(pa);
                List<Resurs> Lr = new List<Resurs>();
                using (Stream stream1 = File.Open("Resursi.bin", FileMode.Open))
                {
                    var formatter1 = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    while (stream1.Position != stream1.Length)
                    {
                        Lr.Add(((Resurs)formatter1.Deserialize(stream1)));


                    }

                    stream1.SetLength(0);

                    foreach (Resurs r in Lr)
                    {
                        for (int i = 0; i < listView1.Items.Count; i++)
                        {
                            if (r.ime == listView1.Items[i].Text)
                                pb.BackgroundImage = r.ikonica;
                        }

                        if (r.ime.Equals(dragitem.Text))
                        {
                            r.lokacija = glob_paneli[glob_paneli.Count - 1][pa.Count - 1].Location;
                            
                            String etikete = string.Join(",", r.oz_etiketa.ToArray());
                            String detalji = "Oznaka: " + r.oznaka + Environment.NewLine +
                                       "Naziv:   " + r.ime + Environment.NewLine +
                                     "Tip:      " + r.tipResursa + Environment.NewLine +
                                     "Datum otkrivanja:   " + r.datum_kao.ToString() + Environment.NewLine +
                                     "Tagovi:   " + etikete + Environment.NewLine +
                                     "Opis:    " + r.opis;

                            new ToolTip().SetToolTip(pb, detalji);

                            dPBr.Add(pb, r.oznaka);
                            dPBtr.Add(pb, r.tipResursa);
                            dPBi.Add(pb, r.ime);

                            break;
                        }
                    }

                    
                    glob_pb.Add(pb);
                    foreach (Resurs tr in Lr)
                    {
                        formatter1.Serialize(stream1, tr);
                    }
                    stream1.Close();
                    AddContextMenuAndItemsDD(pb);
                }
              
            }
           

        

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
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
            RefreshList();
        }


        private void tabelaPrikazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelaPrikaza tbl = new TabelaPrikaza(this);
            
            tbl.ShowDialog();
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
            glob_pb.Clear();
            glob_paneli.Clear();
            dPs.Clear();
            
            List<Resurs> ls = new List<Resurs>();
            Point nije_na_mapi=new Point{X=-100, Y=-100};
            iscitajResurs(ls);

            foreach (Resurs sim in ls)
            {   
                if (sim.lokacija != nije_na_mapi)
                {
                    List<Etiketa> et = new List<Etiketa>();
                    using (Stream stream = File.Open("Etikete.bin", FileMode.Open))
                    {
                        var formatter = new BinaryFormatter();
                        while (stream.Position != stream.Length)//potrebno proci od pocetka do kraja fajla!!!
                            et.Add((Etiketa)formatter.Deserialize(stream));
                        stream.Close();
                    }
                    ListViewItem dragitem = selection;
                    PictureBox pb = new PictureBox();
                    List<Panel> pa = new List<Panel>();
                    int k = 70;

                    for (int i = 0; i < et.Count; i++)
                    {
                        if (sim.oz_etiketa.Contains(et[i].oznaka))
                        {

                            Panel p = new Panel();
                            p.Tag = sim.ime;
                            p.Parent = pbMape;
                            p.Location = sim.lokacija;
                            if (sim.oz_etiketa.Count == 1)
                                p.Height = p.Width = 63;
                            else
                            {
                                p.Height = p.Width = k;
                                k -= 7;
                            }
                            p.BringToFront();
                            p.BackColor = et[i].boja;
                            pa.Add(p);
                            if (pa.Count == sim.oz_etiketa.Count)
                            {
                                pb.Tag = dragitem;
                                pb.BackgroundImageLayout = ImageLayout.Stretch;
                                pb.BackgroundImage = sim.ikonica;
                                if (pa.Count == 1)
                                    pb.Height = pb.Width = 63;
                                else if(pa.Count==2)
                                    pb.Height = pb.Width = 56;
                                else if (pa.Count == 3)
                                        pb.Height = pb.Width = 50;
                                    else
                                        pb.Height = pb.Width = 40;

                                pb.MouseDown += new MouseEventHandler(pb_ClickDD);
                                pa[pa.Count-1].Controls.Add(pb);
                            }
                        }
                    }
                    glob_paneli.Add(pa);

                    string etikete = " ";
                    etikete = string.Join(",", sim.oz_etiketa.ToArray());
                    String detalji = "Oznaka: " + sim.oznaka + Environment.NewLine +
                                   "Naziv:   " + sim.ime + Environment.NewLine +
                                 "Tip:      " + sim.tipResursa + Environment.NewLine +
                                 "Datum otkrivanja:   " + sim.datum_kao + Environment.NewLine +
                                 "Tagovi:   " + etikete + Environment.NewLine +
                                 "Opis:    " + sim.opis;
                    new ToolTip().SetToolTip(pb, detalji);
                    AddContextMenuAndItems(pb);
                    dPBr.Add(pb, sim.oznaka);
                    dPBtr.Add(pb, sim.tipResursa);
                    dPBi.Add(pb, sim.ime);
                    dPBl.Add(pb, sim.lokacija);
                    dPs.Add(sim.lokacija, sim.ime);
                }
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
            iscitajResurs(re);

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

                                foreach (KeyValuePair<PictureBox, string> spb in dPBtr)
                                {
                                    spb.Key.BorderStyle = BorderStyle.None;
                                }
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
            Help.ShowHelp(this, "..\\..\\Resources\\Help projects\\SR.chm", HelpNavigator.Topic, "Prevlacenje resursa na mapu.htm");
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
                if (drugi.ShowDialog() == DialogResult.OK)
                {
                    Tut3 treci = new Tut3();
                    treci.Location = new Point((main.X + 290), main.Y + 60);
                    if (treci.ShowDialog() == DialogResult.OK)
                    {
                        Tut4 cetvrti = new Tut4();
                        cetvrti.Location = new Point((main.X + 242), main.Y + 388);
                        if (cetvrti.ShowDialog() == DialogResult.OK)
                        {
                            Tut5 peti = new Tut5();
                            peti.Location = new Point((main.X + 842), main.Y + 438);
                            peti.ShowDialog();
                        }
                    }
                }

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


        private void iscitajResurs(List<Resurs> r)
        {
            using (Stream stream = File.Open("Resursi.bin", FileMode.Open))
            {
                var formatter = new BinaryFormatter();
                while (stream.Position != stream.Length)
                    r.Add((Resurs)formatter.Deserialize(stream));
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
                    fOz.Text = "";
                    fIme.Text = "";
                    fTip.Text = "";
                    prikazIkonice.BackgroundImage = null;
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

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            RefreshList();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            RefreshList();
        }

       

      

        public void AddContextMenuAndItems(PictureBox pb)
        {
            ContextMenu mnuContextMenu = new ContextMenu();
            pb.ContextMenu = mnuContextMenu;
            MenuItem mnuItem = new MenuItem();
            mnuItem.Text = "Izbriši";
            mnuContextMenu.MenuItems.Add(mnuItem);
            mnuItem.Click += new System.EventHandler(this.mnuItem_Click);
           
        }

        private void mnuItem_Click(object sender, System.EventArgs e)
        {
            Point cursorPos = this.PointToClient(Cursor.Position);
            
            List<Resurs> lss = new List<Resurs>();
            using (Stream stream = File.Open("Resursi.bin", FileMode.Open))
            {
                var formatter = new BinaryFormatter();
                while (stream.Position != stream.Length)
                    lss.Add((Resurs)formatter.Deserialize(stream));

                stream.SetLength(0);

                foreach (Resurs s in lss)
                {
                    foreach (List<Panel> pa in glob_paneli)
                    {
                        if (s.lokacija == pa[0].Location)
                        {
                            Rectangle rec = new Rectangle(pa[0].Location.X + 279, pa[0].Location.Y + 54, 80, 80);
                            if (rec.Contains(cursorPos))
                            {
                                for (int i = 0; i < pa.Count; i++)
                                    pa[i].Location = new Point { X = -100, Y = -100 };
                                
                                s.lokacija = new Point { X = -100, Y = -100 };
                                break;
                            }
                        }
                    }
                       
                    

                }

                foreach (Resurs tr in lss)
                {
                    formatter.Serialize(stream, tr);
                }
                stream.Close();    
               
            }        
      }


        public void AddContextMenuAndItemsDD(PictureBox pb)
        {
            ContextMenu mnuContextMenu = new ContextMenu();
            pb.ContextMenu = mnuContextMenu;
            MenuItem mnuItem = new MenuItem();
            mnuItem.Text = "Izbriši";
            mnuContextMenu.MenuItems.Add(mnuItem);
            mnuItem.Click += new System.EventHandler(this.mnuItem_ClickDD);

        }

        private void mnuItem_ClickDD(object sender, System.EventArgs e)
        {
            Point cursorPos = this.PointToClient(Cursor.Position);

            List<Resurs> lss = new List<Resurs>();
            using (Stream stream = File.Open("Resursi.bin", FileMode.Open))
            {
                var formatter = new BinaryFormatter();
                while (stream.Position != stream.Length)
                    lss.Add((Resurs)formatter.Deserialize(stream));

                stream.SetLength(0);

                foreach (Resurs s in lss)
                {
                    foreach (List<Panel> pa in glob_paneli)
                    {
                            Rectangle rec = new Rectangle(pa[0].Location.X + 279, pa[0].Location.Y + 54, 80, 80);
                            if (rec.Contains(cursorPos))
                            {
                                for (int i = 0; i < pa.Count; i++ )
                                    pa[i].Location = new Point { X = -100, Y = -100 };
                                    s.lokacija = new Point { X = -100, Y = -100 };
                            }
                        }
                        
                    }



                

                foreach (Resurs tr in lss)
                {
                    formatter.Serialize(stream, tr);
                }
                stream.Close();

            }
        }

        private void pb_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].Selected = false;
            }
            Point cursorPos = this.PointToClient(Cursor.Position);

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                foreach (List<Panel> pa in glob_paneli)
                {
                    Rectangle rec = new Rectangle(pa[0].Location.X + 279, pa[0].Location.Y + 54, 80, 80);
                    foreach (Panel p in pa)
                    {
                            if (rec.Contains(cursorPos) && p.Tag == listView1.Items[i].Text)
                            {
                                listView1.Items[i].Selected = true;
                            }
                        
                    }
                }
            }
        }

        private void pb_ClickDD(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].Selected = false;
            }
            Point cursorPos = this.PointToClient(Cursor.Position);

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                foreach (KeyValuePair<Point, string> Ps in dPs)
                {
                    Rectangle rec = new Rectangle(Ps.Key.X + 279, Ps.Key.Y + 54, 80, 80);
                    if (rec.Contains(cursorPos) && Ps.Value == listView1.Items[i].Text)
                    {
                        listView1.Items[i].Selected = true;
                    }
                }
            }
        }

        public void Tutorijal()
        {
            Tut1 prvi = new Tut1();
            var main = this.Location;
            prvi.Location = new Point((main.X + 100), main.Y + 60);
            if (prvi.ShowDialog() == DialogResult.OK)
            {
                Tut2 drugi = new Tut2();
                drugi.Location = new Point((main.X + 190), main.Y + 60);
                if (drugi.ShowDialog() == DialogResult.OK)
                {
                    Tut3 treci = new Tut3();
                    treci.Location = new Point((main.X + 290), main.Y + 60);
                    if (treci.ShowDialog() == DialogResult.OK)
                    {
                        Tut4 cetvrti = new Tut4();
                        cetvrti.Location = new Point((main.X + 242), main.Y + 388);
                        if (cetvrti.ShowDialog() == DialogResult.OK)
                        {
                            Tut5 peti = new Tut5();
                            peti.Location = new Point((main.X + 842), main.Y + 438);
                            peti.ShowDialog();
                        }
                    }
                  }

              }
           }  
   }      
}
