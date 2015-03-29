using SvetskiResursi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HCI_projekat
{
    public partial class FormV : Form
    {
        private OpenFileDialog ofd = new OpenFileDialog();
        private string text = System.IO.File.ReadAllText(@"Resursi.txt");
        string[] lines = System.IO.File.ReadAllLines(@"Resursi.txt");
        
        public FormV()
        {
            InitializeComponent();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";
            
            //PUNIS COMBO SA SVIM NOVIM
          /*  Dictionary<string, tipResursa> privremeni  =  SvetskiResursi.tipoviResursa.getInstance().getAll();
            Dictionary<string, Etiketa> privremeni2 = SvetskiResursi.Etikete.getInstance().getAll();
                

            foreach(tipResursa tip in privremeni.Values){
                comboTipResursa.Items.Add(tip.oznaka+tip.ime);
                
            }

            foreach (Etiketa tip in privremeni2.Values)
            {
                comboBox1.Items.Add(tip.oznaka);

            }*/

            //Dodavanje tipa resursa iz fajla u combobox resursa
            string[] elem = File.ReadAllLines("TipResursa.txt");
            string[] elemSpl = new string[100];
            string[] elemSpl2 = new string[100];

            foreach (string line in elem)
            {
                elemSpl2 = line.Split(':'); //prvo da razdvoji na osnovu :
                for (int i = 0; i < elemSpl2.Count(); i++)
                {
                    if (elemSpl2[i].Equals("\t")) //uvek ce postojati "otpadak" jer nakon svakog upisa u fajl stavljam \t
                        break;

                    elemSpl = elemSpl2[i].Split('\t'); //svaki string koji predstavlja jedan resurs izdeliti na osnovu \t
                    if (elemSpl[0].Equals(""))//posto nakon svakog : postoji \t
                    {
                        comboTipResursa.Items.Add(elemSpl[1] + elemSpl[2]);
                    }
                    else
                    {
                        comboTipResursa.Items.Add(elemSpl[0] + elemSpl[1]);
                    }
                }
            }

            //Dodavanje etikete iz fajla u combobox resursa
            string[] etik = File.ReadAllLines("Etiketa.txt");
      
            foreach (string line in etik)
            {
                elemSpl2 = line.Split(':'); //prvo da razdvoji na osnovu :
                for (int i = 0; i < elemSpl2.Count(); i++)
                {
                    if (elemSpl2[i].Equals("\t")) //uvek ce postojati "otpadak" jer nakon svakog upisa u fajl stavljam \t
                        break;

                    elemSpl = elemSpl2[i].Split('\t'); //svaki string koji predstavlja jedan resurs izdeliti na osnovu \t
                    if (elemSpl[0].Equals(""))//posto nakon svakog : postoji \t
                    {
                        checkedListBox1.Items.Add(elemSpl[1]);
                    }
                    else
                    {
                        checkedListBox1.Items.Add(elemSpl[0]);
                    }
                }
            }



        //    foreach(KeyValuePair<string, tipResursa> a in privremeni){
        //        tipResursa novi = a.Value;
        //          comboTipResursa.Items.Add(novi.oznaka + novi.ime);
        //        }




            //PUNIS LISTU SA ETIKETAMA



        }

       
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult d = ofd.ShowDialog();
            if (d == DialogResult.OK)
            {
                string fname = ofd.FileName;
                Image image1 = new Bitmap(fname);

                ikonica.BackgroundImage = image1;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Resurs res = new Resurs();
            DialogObavestenja db = new DialogObavestenja();
            ObavestenjeZaOznaku ozo = new ObavestenjeZaOznaku();
            

            //kad se klikne ok, prvo se u promenjive smestaju sve unete vrednosti, a ako neka obavezna vred. fali, ide dalja provera
            res.oznaka = oznaka.Text;
            res.ime = ime.Text;
            res.opis = opis.Text;
            res.ikonica = (Image)ikonica.BackgroundImage;
            res.tipResursa = comboTipResursa.Text;
            res.obnovljivo = cbObnovljivo.Text;
            res.eksploatacija = cbEkpl.Text;
            res.strateska_vaznost = cbVaznost.Text;
            res.jedinica_mere = cbMera.Text;
            res.cena = textBox3.Text;
            //datum
            res.pojavljivanje = comboBox6.Text;
            List<string> cekirani = checkedListBox1.CheckedItems.OfType<string>().ToList();
            res.oz_etiketa = cekirani;

            //Provera da li su obavezna polja popunjena 
            if (res.oznaka.Equals("") || res.ime.Equals("") || res.tipResursa.Equals(""))
            {
                db.ShowDialog();

            }
            
            else
            {
               if (text.Contains(res.oznaka))
                    {
                        ozo.ShowDialog();

                    }
                    else
                    {

                        SvetskiResursi.Resursi.getInstance().Dodaj(res);

                        //konvertuje sliku u string, kako bih mogla upisati u file
                        MemoryStream ms = new MemoryStream();
                        res.ikonica.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); //if it is jpeg
                        byte[] buffer = ms.ToArray();
                        string serialized = Convert.ToBase64String(buffer);

                        List<string> elementi = new List<string>();
                        elementi.Add(res.oznaka);
                        elementi.Add(res.ime);
                        elementi.Add(res.tipResursa);
                        elementi.Add(res.opis);
                        elementi.Add(serialized);

                        elementi.Add(res.eksploatacija);
                        elementi.Add(res.obnovljivo);
                        elementi.Add(res.strateska_vaznost);
                        elementi.Add(res.jedinica_mere);
                        elementi.Add(res.cena);
                        elementi.Add(res.pojavljivanje);
                        elementi.Add(";");
                        foreach (string et in res.oz_etiketa)
                        {
                            elementi.Add(et);

                        }
                        elementi.Add(":");

                        //Upis u file
                        using (System.IO.StreamWriter file = new System.IO.StreamWriter("Resursi.txt", true))
                        {
                            foreach (string st in elementi)
                            {
                                file.Write(st);
                                file.Write("\t");
                            }
                        }
                        this.DialogResult = DialogResult.OK;
                        this.Close();

                } 
                }
            

        }

        private void FormV_Load(object sender, EventArgs e)
        {

        }

    }
}
