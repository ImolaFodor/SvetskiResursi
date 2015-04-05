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
        

        public Form1()
        {
            InitializeComponent();

            if (!File.Exists("Resursi.bin") && !File.Exists("Tipovi.bin") && !File.Exists("Etikete.bin"))
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
    }
}