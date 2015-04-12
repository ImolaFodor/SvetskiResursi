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
        public string etikete;
        bool waterMarkActive=true;
        public override bool AllowDrop { get; set; }
        private Point pictureLocation;
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

            if (!File.Equals("Resursi.bin", null) && !File.Equals("Tipovi.bin", null) && !File.Equals("Etikete.bin", null))
            listView1_Fill();

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
            pbMape.DragDrop += new DragEventHandler(this.pictureBox1_DragDrop);
            pbMape.DragEnter += new DragEventHandler(this.pictureBox1_DragEnter);
        }




        //DRAG&DROP

        protected override void OnPaint(PaintEventArgs e)
        {
            // If there is an image and it has a location, 
            // paint it when the Form is repainted.
            base.OnPaint(e);
            if (pbMape != null && this.pictureLocation != Point.Empty)
            {
                e.Graphics.DrawImage(pbMape.Image, this.pictureLocation);
            }
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            /*// Handle FileDrop data.
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Assign the file names to a string array, in 
                // case the user has selected multiple files.
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                try
                {
                    // Assign the first image to the picture variable.
                    //pbMape = Image.FromFile(files[0]);
                    // Set the picture location equal to the drop point.
                    this.pictureLocation = this.PointToClient(new Point(e.X, e.Y));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }

            // Handle Bitmap data.
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                try
                {
                    // Create an Image and assign it to the picture variable.
                    pbMape = (PictureBox)e.Data.GetData(DataFormats.Bitmap);
                    // Set the picture location equal to the drop point.
                    this.pictureLocation = this.PointToClient(new Point(e.X, e.Y));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            // Force the form to be redrawn with the image.
            this.Invalidate();
            ListViewItem selection = listView1.GetItemAt(e.X, e.Y);
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pbMape.Image = (Image)selection;*/

            if(listView1.SelectedItems.Count==0)
{
return;
}
ListViewItem dragitem=listView1.SelectedItems[0];
pbMape.Image=ListaSlika.Images[dragitem.ImageIndex];
listView1.Items.Remove(dragitem);
}
        

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            /*// If the data is a file or a bitmap, display the copy cursor.
            if (e.Data.GetDataPresent(DataFormats.Bitmap) ||
               e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Move;*/

            int len = e.Data.GetFormats().Length - 1;
            int i;
            for (i = 0; i <= len; i++)
            {
                if (e.Data.GetFormats()[i].Equals("System.Windows.Forms.ListView+SelectedLis tViewItemCollection"))
                {
                    //The data from the drag source is moved to the target.	
                    e.Effect = DragDropEffects.Move;
                }
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
            dodajResurs dlg3 = new dodajResurs();
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

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            //ListViewItem selection = listView1.GetItemAt(e.X, e.Y);
            
            listView1.DoDragDrop(listView1.SelectedItems , DragDropEffects.Copy |
      DragDropEffects.Move);
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
                
                // Setup other things like SubItems, Font, ...
                
                listView1.Items.Add(resurs);
                lista_tipova.Add(resurs,tre.oznaka );
                lista_resursa.Add(resurs);
                
                //this.Controls.Add(listView1);
                    }
                    

            }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
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
    }
}