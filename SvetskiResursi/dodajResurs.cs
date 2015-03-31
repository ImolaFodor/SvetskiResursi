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
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SvetskiResursi
{
    public partial class dodajResurs : Form
    {
        private OpenFileDialog ofd = new OpenFileDialog();

        public dodajResurs()
        {
            InitializeComponent();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";
                 
            
            
            foreach (tipResursa tip in SvetskiResursi.tipoviResursa.getInstance().getAll().Values)
            {
                comboTipResursa.Items.Add(tip.oznaka);

            }

            foreach (Etiketa etiketa in SvetskiResursi.Etikete.getInstance().getAll().Values)
             {
                 checkedListBox1.Items.Add(etiketa.oznaka);

             }

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

        //Metod za dodelu vrednosti radiobutton-a u promenjivu
        public String oznaceno(String res, RadioButton rb1, RadioButton rb2)
        {
            bool oz = rb1.Checked;
            if (oz)
                res = rb1.Text;
            else
                res = rb2.Text;

            return res;
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
            res.tipResursa = comboTipResursa.Text;

            //Dictionary<string, tipResursa> privremeni  =  SvetskiResursi.tipoviResursa.getInstance().getAll();

                  foreach (tipResursa tip in SvetskiResursi.tipoviResursa.getInstance().getAll().Values)
            {

                if (ikonica.BackgroundImage == null && comboTipResursa.Text.Equals(tip.oznaka))
                    res.ikonica = tip.ikonica;
                else
                    res.ikonica = (Image)ikonica.BackgroundImage;
            }




            res.obnovljivo = oznaceno(res.obnovljivo, rbObn1, rbObn2);
            res.eksploatacija = oznaceno(res.eksploatacija, rbEkp1, rbEksp2);
            res.strateska_vaznost = oznaceno(res.strateska_vaznost, rbSV1, rbSV2);
            res.jedinica_mere = cbMera.Text;
            res.cena = textBox3.Text;
            res.datum_kao = "Datum";//datum
            res.pojavljivanje = comboBox6.Text;
            List<string> cekirani = checkedListBox1.CheckedItems.OfType<string>().ToList();
            res.oz_etiketa = cekirani;



            //Provera da li su obavezna polja popunjena 
            if (res.oznaka.Equals("") || res.ime.Equals("") || res.tipResursa.Equals(""))
            {
                db.ShowDialog();

            }

            else
           /* {
                if (text.Contains(res.oznaka))
                {
                    ozo.ShowDialog();

                }
                else*/
                {
                    SvetskiResursi.Resursi.getInstance().Dodaj(res);

                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
            //}
        }

        private void FormV_Load(object sender, EventArgs e)
        {

        }
    }
}
