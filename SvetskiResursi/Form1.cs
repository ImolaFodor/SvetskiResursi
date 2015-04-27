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
        Dictionary<ListViewItem,string> lista_tipova = new Dictionary<ListViewItem,string>();
        List<ListViewItem> lista_resursa = new List<ListViewItem>();
        List<Simbol> s = new List<Simbol>();
        Point lokacija;
        
        public string etikete;
        bool waterMarkActive=true;
        public override bool AllowDrop { get; set; }
        ImageList ListaSlika = new ImageList();

        public Form1()
        {
            InitializeComponent();
            

           /* if (!File.Exists("Resursi.bin") && !File.Exists("Tipovi.bin") && !File.Exists("Etikete.bin"))
            {
                File.Create("Resursi.bin");
                File.Create("Tipovi.bin");
                File.Create("Etikete.bin");
            }*/

            if(!File.Exists("Resursi.bin"))
                File.Create("Resursi.bin");

            if(!File.Exists("Tipovi.bin"))
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

            this.waterMarkActive = true;
this.textBox1.ForeColor = Color.Gray;
this.textBox1.Text = "Unesite oznaku tipa...";

this.textBox1.GotFocus += (source, e) =>
  {
    if (this.waterMarkActive)
    {
      this.waterMarkActive = false;
      this.textBox1.Text = "";
      this.textBox1.ForeColor = Color.Black;
    }
  };

this.textBox1.LostFocus += (source, e) =>
  {
      if (!this.waterMarkActive && string.IsNullOrEmpty(this.textBox1.Text))
      {
          this.waterMarkActive = true;
          this.textBox1.Text = "Unesite oznaku tipa...";
          this.textBox1.ForeColor = Color.Gray;
      }
  };


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

            listView1.MouseDown += listView1_MouseDown;
            pbMape.AllowDrop = true;
        }


        ListViewItem selection;

        //DRAG&DROP
        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {

            selection = listView1.GetItemAt(e.X, e.Y);
            if(selection != null)
            {
                Bitmap img = (Bitmap)ListaSlika.Images[selection.ImageIndex];
                listView1.DoDragDrop(img, DragDropEffects.Copy);
            }
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {

            PictureBox pb = new PictureBox();
            pb.Parent = pbMape;
            Point po = PointToClient(new Point(e.X - 450, e.Y - 75));

            pb.Location = po;
            Simbol simbol = new Simbol();
            simbol.lokacija = pb.Location;
            simbol.slika = (Bitmap)ListaSlika.Images[selection.ImageIndex];
            
            

            

            ListViewItem dragitem = selection;

            pb.BackgroundImage = ListaSlika.Images[dragitem.ImageIndex];
            pb.BackgroundImageLayout = ImageLayout.Stretch;
            pb.Tag = dragitem;
            ListViewItem lvi = (ListViewItem)pb.Tag;
            Resurs r = (Resurs)lvi.Tag;
            simbol.oznaka = r.oznaka;
            String etikete = string.Join(",", r.oz_etiketa.ToArray());

            String detalji = "Oznaka: " + r.oznaka + Environment.NewLine +
                               "Naziv:   " + r.ime + Environment.NewLine +
                             "Tip:      " + r.tipResursa + Environment.NewLine +
                             "Datum otkrivanja:   " + r.datum_kao.ToString() + Environment.NewLine +

                             "Tagovi:   " + etikete + Environment.NewLine +
                             "Opis:    " + r.opis;

            new ToolTip().SetToolTip(pb, detalji);

            pb.Height = pb.Width = 45;

            pb.BringToFront();
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
        }

        private void dodavanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dodajEtiketu dlg2 = new dodajEtiketu();
            dlg2.ShowDialog();
        }

        private void dodavanjeResursaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dodajResurs dlg3 = new dodajResurs(this);
            dlg3.ShowDialog();
        }

      /*  private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            //potrebno je preuzeti selektovano ime i na osnovu njega
            //videti koja mapa je u pitanju, a zatim je i prikazati
            string selected = Mape.GetItemText(Mape.SelectedItem);
            if (selected.Equals("Mapa1"))
            {
                pbMape.BackgroundImage = mp1;
            }
            else
                pbMape.BackgroundImage = mp2;
        }
        */
        /*private void Form1_Load(object sender, EventArgs e)
        {
          
            //kreiranje mogucih tipova i njihovo dodavanje na koren
            TreeNode a = new TreeNode("bla");
            TreeNode[] vrsteNafte = new TreeNode[] {a };
            TreeNode nafta = new TreeNode("Nafta",vrsteNafte);
            TreeNode ptice = new TreeNode("Ptice");
            TreeNode zivotinje = new TreeNode("Zivotinje");
            TreeNode[] deca = new TreeNode[] { nafta, ptice, zivotinje };

            TreeNode root = new TreeNode("Resursi ",deca);
            treeView1.Nodes.Add(root);
            
        }*/

        private void tabelaPrikazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabelaPrikaza tbl = new tabelaPrikaza();
            
            tbl.ShowDialog();
            
        }

        private void prikazIkonice_Click(object sender, EventArgs e)
        {

        }

        

        public static Form1 instanca=null;
        public static Form1 getInstance()
        {
            if (instanca == null)
                instanca = new Form1();
            return instanca;
        } 

        public void listView1_Fill()
        {

            tr.Clear();
            r.Clear();
            //Ucitavanje resursa iz fajla.
            using (Stream stream = File.Open("Resursi.bin", FileMode.Open))
            {
               // if (stream == null)
                 //   Console.Write("Prvo pisanje");
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
                

                listView1.View = View.List;
                ListViewItem tresurs = new ListViewItem();
                tresurs.Text = tre.oznaka;

                tresurs.Tag = tre;

                // Setup other things like SubItems, Font, ...


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

                     
                    if(tre.oznaka==re.tipResursa){
                listView1.View = View.List;
                ListViewItem resurs = new ListViewItem();
                resurs.Text = re.oznaka+" "+re.ime;
                resurs.ImageIndex =i;
                resurs.Tag = re;
             
                
                listView1.Items.Add(resurs);
                lista_tipova.Add(resurs,tre.oznaka );
                lista_resursa.Add(resurs);
                
                //this.Controls.Add(listView1);
                    }
                    

            }
                
            }
        }

        public void pbMapa_Fill()
        {
            using (Stream stream = File.Open("Simboli.bin", FileMode.Open))
            {
                
                var formatter = new BinaryFormatter();
                while (stream.Position != stream.Length)//potrebno proci od pocetka do kraja fajla!!!
                    s.Add((Simbol)formatter.Deserialize(stream));
                stream.Close();

                foreach(Simbol sim in s){
                PictureBox pb = new PictureBox();
                pb.Parent = pbMape;
                Point po = sim.lokacija;
                pb.Location = po;
                pb.BackgroundImage = sim.slika;
                pb.BackgroundImageLayout = ImageLayout.Stretch;
                pb.Height = pb.Width = 45;
                String detalji = "Oznaka: " + sim.oznaka + Environment.NewLine;
                new ToolTip().SetToolTip(pb, detalji);
                }
                
                
            }

        }

    
        private string CalculateMsgAt(Point pt)
        {
            // Calculate the message that should be shown 
            // when the mouse is at thegiven point
            return "This is a tooltip";
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string trazeni = textBox1.Text;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Text.StartsWith(trazeni))
                {
                    listView1.Items.Clear();
                    foreach (KeyValuePair<ListViewItem,string> slvi in lista_tipova)
                    {

                        if (slvi.Value==trazeni)
                        {
                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = slvi.Key.Text;
                            lvi.ImageIndex = slvi.Key.ImageIndex;
                            lvi.Tag = slvi.Key;
                            listView1.Items.Add(lvi);
                        }
                    }
                    

                }
            }


            }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems.Clear();
            string trazeni = textBox2.Text;
            for(int i=0; i<listView1.Items.Count;i++){
                if (listView1.Items[i].Text==trazeni)
                {
                    listView1.Select();
                    listView1.Items[i].Selected = true;
                    
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       /* private void pbMape_MouseHover(object sender, EventArgs e)
        {
            

            Point pt = lokacija;
            String msg = this.CalculateMsgAt(pt);
            if (String.IsNullOrEmpty(msg))
                return;

            //pt.Y += 20;
            this.ToolTip.Show(msg, this, pt);
            if (this.ToolTip == null)
                return;
        }

        private void pbMape_MouseLeave(object sender, EventArgs e)
        {
            if (this.ToolTip != null)
                this.ToolTip.Hide(this);
        }*/

       
    }
}