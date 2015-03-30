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
        Dictionary<string, Resurs> fajl1;

        public tabelaPrikaza()   
        {
            InitializeComponent();
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Resursi.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
            fajl1 = (Dictionary<string, Resurs>)formatter.Deserialize(stream);
            stream.Close();
            
        }

        private void tblD_Click(object sender, EventArgs e)
        {
            
        }

        private void tabelaPrikaza_Load(object sender, EventArgs e)
        {
            

            //Dictionary<string, Resurs> privremeni = SvetskiResursi.Resursi.getInstance().getAll();
               foreach (Resurs resurs in fajl1.Values)
               {
                   etikete = string.Join(",", resurs.oz_etiketa.ToArray());
                   dataGridView1.Rows.Add(new object[] {resurs.oznaka, resurs.ime, resurs.tipResursa, resurs.opis, resurs.ikonica,
                   resurs.eksploatacija, resurs.obnovljivo, resurs.strateska_vaznost, resurs.jedinica_mere, resurs.cena, resurs.datum_kao, resurs.pojavljivanje, etikete});

               }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
