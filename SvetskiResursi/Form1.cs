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
        

        public Form1()
        {
            InitializeComponent();

            Dictionary<string, Resurs> r = SvetskiResursi.Resursi.getInstance().getAll();
            Dictionary<string, tipResursa> tr = SvetskiResursi.tipoviResursa.getInstance().getAll();
            Dictionary<string, Etiketa> e = SvetskiResursi.Etikete.getInstance().getAll();

            if (File.Exists("Resursi.bin"))
            {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Resursi.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            r = (Dictionary<string, Resurs>)formatter.Deserialize(stream);
            stream.Close();



            IFormatter formatter2 = new BinaryFormatter();
            Stream stream2 = new FileStream("Tipovi.bin", FileMode.Open, FileAccess.Read, FileShare.None);
            tr = (Dictionary<string, tipResursa>)formatter.Deserialize(stream2);
            stream2.Close();

            IFormatter formatter3 = new BinaryFormatter();
            Stream stream3 = new FileStream("Etikete.bin", FileMode.Open, FileAccess.Read, FileShare.None);
            e = (Dictionary<string, Etiketa>)formatter.Deserialize(stream3);
            stream3.Close();

            }
            else
            {

                File.Create("Resursi.bin");
                File.Create("Tipovi.bin");
                File.Create("Etikete.bin");

            }
            

        }


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

        private void button1_MouseClick(object sender, MouseEventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
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
            
        }

        private void tabelaPrikazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabelaPrikaza tbl = new tabelaPrikaza();
            
            tbl.ShowDialog();
            
        }

        private void prikazIkonice_Click(object sender, EventArgs e)
        {

        }



       /* public Dictionary<string, Resurs> getFajlResursi()
        {
            return fajl1;

        }

        public Dictionary<string, tipResursa> getFajlTipovi()
        {
            return fajl2;

        }

        public Dictionary<string, Etiketa> getFajlEtikete()
        {
            return fajl3;

        }*/











    }
}