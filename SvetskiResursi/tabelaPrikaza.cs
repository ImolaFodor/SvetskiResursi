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
        //Dictionary<string, Resurs> fajl1;
        Dictionary<string, Resurs> r = SvetskiResursi.Resursi.getInstance().getAll();
        public tabelaPrikaza()   
        {
            InitializeComponent();
            
            
        }

        private void tabelaPrikaza_Load(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Resursi.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            r = (Dictionary<string, Resurs>)formatter.Deserialize(stream);
            stream.Close();

            //Dictionary<string, Resurs> privremeni = SvetskiResursi.Resursi.getInstance().getAll();
            foreach (Resurs resurs in SvetskiResursi.Resursi.getInstance().getAll().Values)
               {
                   etikete = string.Join(",", resurs.oz_etiketa.ToArray());

                   dataGridView1.Rows.Add(new object[] {resurs.oznaka, resurs.ime, resurs.tipResursa, resurs.opis, resurs.ikonica,
                    resurs.jedinica_mere, resurs.cena, resurs.datum_kao, etikete});

               }

        }
    }
}
