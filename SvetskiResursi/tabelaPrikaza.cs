using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
         /*   foreach (Resurs resurs in privremeni.Values)
            {
                dataGridView1.Rows.Add(new object[] {resurs.oznaka, resurs.ime, resurs.tipResursa, resurs.opis, resurs.ikonica,
                resurs.eksploatacija, resurs.obnovljivo, resurs.strateska_vaznost, resurs.jedinica_mere, resurs.cena, null, resurs.pojavljivanje, resurs.oz_etiketa});

            }*/

            string[] elem = File.ReadAllLines("Resursi.txt");
            string[] elemSpl = new string[100];
            string[] elemSpl2 = new string[100];
            string[] elemSpl3 = new string[100];
            //string[] elemSplSvi = new string[100];
            string[] elemSplEtiketa = new string[100];
            List<string> lista_etiketa = new List<string>();
            int brojac_etiketa=0;
            foreach (string line in elem)
            {

                elemSpl2 = line.Split(':'); //prvo da razdvoji na osnovu :
                for (int i = 0; i < elemSpl2.Count(); i++)
                {
                    if (elemSpl2[i].Equals("\t")) //uvek ce postojati "otpadak" jer nakon svakog upisa u fajl stavljam \t
                        break;

                   // elemSpl = elemSpl2[i].Split('\t');//svaki string koji predstavlja jedan resurs izdeliti na osnovu \t
                    elemSpl3= elemSpl2[i].Split(';');
                    elemSpl = elemSpl3[0].Split('\t');
                    elemSplEtiketa = elemSpl3[1].Split('\t');
                    brojac_etiketa = 0;

                    for(int m=0; m<elemSplEtiketa.Count(); m++){
                        if (elemSplEtiketa[m].Equals(""))
                            brojac_etiketa = brojac_etiketa;
                        else
                            brojac_etiketa++;

                    }
                    
                    if (elemSpl[0].Equals(""))//posto nakon svakog : postoji \t
                    {


                        for (int k = 1; k <= brojac_etiketa; k++)
                        {

                            lista_etiketa.Add(elemSplEtiketa[k]);
                            

                        }




                        //prvo konvertovati string u sliku
                        int mod4 = elemSpl[5].Length % 4;
                        if (mod4 > 0)
                        {
                            elemSpl[5] += new string('=', 4 - mod4);
                        }

                        byte[] imageBytes = Convert.FromBase64String(elemSpl[5]);
                        MemoryStream ms = new MemoryStream(imageBytes, 0,
                          imageBytes.Length);

                        // Convert byte[] to Image
                        ms.Write(imageBytes, 0, imageBytes.Length);
                        Image image = Image.FromStream(ms, true);

                        dataGridView1.Rows.Add(new object[] { elemSpl[1], elemSpl[2], elemSpl[3], elemSpl[4], image, elemSpl[6], elemSpl[7], elemSpl[8],
                        elemSpl[9], elemSpl[10],null, elemSpl[11], elemSpl[12],lista_etiketa});
                    }
                    else
                    {
                        
                        /*for (int k = 0; k < brojac_etiketa; k++)
                        {
                           
                            lista_etiketa[k] = elemSplEtiketa[k];

                        }*/
                

                        //prvo konvertovati string u sliku
                        int mod4 = elemSpl[4].Length % 4;
                        if (mod4 > 0)
                        {
                            elemSpl[4] += new string('=', 4 - mod4);
                        }

                        byte[] imageBytes = Convert.FromBase64String(elemSpl[4]);
                        MemoryStream ms = new MemoryStream(imageBytes, 0,
                          imageBytes.Length);

                        // Convert byte[] to Image
                        ms.Write(imageBytes, 0, imageBytes.Length);
                        Image image = Image.FromStream(ms, true);

                        dataGridView1.Rows.Add(new object[] { elemSpl[0], elemSpl[1], elemSpl[2], elemSpl[3], image, elemSpl[5], elemSpl[6], elemSpl[7], elemSpl[8],
                        elemSpl[9],null, elemSpl[10], elemSpl[11], lista_etiketa});
                    }



                    



                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
