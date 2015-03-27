using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SvetskiResursi
{
    public partial class tabelaPrikaza : Form
    {
        public tabelaPrikaza()
        {
            InitializeComponent();
            
        }

        private void tblD_Click(object sender, EventArgs e)
        {
            
        }

        private void tabelaPrikaza_Load(object sender, EventArgs e)
        {
            Dictionary<string, Resurs> privremeni = SvetskiResursi.Resursi.getInstance().getAll();
            foreach (Resurs resurs in privremeni.Values)
            {
                dataGridView1.Rows.Add(new object[] {resurs.oznaka, resurs.ime, resurs.tipResursa, resurs.opis, resurs.ikonica,
                resurs.eksploatacija, resurs.obnovljivo, resurs.strateska_vaznost, resurs.jedinica_mere, resurs.cena, null, resurs.pojavljivanje});

            }
        }
    }
}
