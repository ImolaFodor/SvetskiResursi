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


namespace HCI_projekat
{
    public partial class FormV : Form
    {
        private OpenFileDialog ofd = new OpenFileDialog();
        Dictionary<string, tipResursa> fajl1;
        Dictionary<string, Etiketa> fajl2;
        Dictionary<string, Etiketa> fajl3;

        public FormV()
        {
            InitializeComponent();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Tipovi.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
            fajl1 = (Dictionary<string, tipResursa>)formatter.Deserialize(stream);
            stream.Close();

            IFormatter formatter2 = new BinaryFormatter();
            Stream stream2 = new FileStream("Etikete.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
            fajl2 = (Dictionary<string, Etiketa>)formatter2.Deserialize(stream2);
            stream2.Close();

            IFormatter formatter3 = new BinaryFormatter();
            Stream stream3 = new FileStream("Resursi.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
            fajl3 = (Dictionary<string, Etiketa>)formatter2.Deserialize(stream2);
            stream3.Close();
            //PUNIS COMBO SA SVIM NOVIM
            //  Dictionary<string, tipResursa> privremeni  =  SvetskiResursi.tipoviResursa.getInstance().getAll();
            //Dictionary<string, Etiketa> privremeni2 = SvetskiResursi.Etikete.getInstance().getAll();


            foreach (tipResursa tip in fajl1.Values)
            {
                comboTipResursa.Items.Add(tip.oznaka);

            }

             foreach (Etiketa etiketa in fajl2.Values)
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

            foreach (tipResursa tip in fajl1.Values)
            {

                if (ikonica.BackgroundImage == null && comboTipResursa.Text.Equals(tip.oznaka))
                    res.ikonica = tip.ikonica;
                else
                    res.ikonica = (Image)ikonica.BackgroundImage;
            }




            res.obnovljivo = cbObnovljivo.Text;
            res.eksploatacija = cbEkpl.Text;
            res.strateska_vaznost = cbVaznost.Text;
            res.jedinica_mere = cbMera.Text;
            res.cena = textBox3.Text;
            res.datum_kao = "Datum";//datum
            res.pojavljivanje = comboBox6.Text;
            List<string> cekirani = checkedListBox1.CheckedItems.OfType<string>().ToList();
            res.oz_etiketa = cekirani;



            //Provera da li su obavezna polja popunjena 
            /*if (res.oznaka.Equals("") || res.ime.Equals("") || res.tipResursa.Equals(""))
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
                    {*/
            SvetskiResursi.Resursi.getInstance().Dodaj(res);
            Dictionary<string, Resurs> privremeni = SvetskiResursi.Resursi.getInstance().getAll();

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Resursi.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, privremeni);
            stream.Close();

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void FormV_Load(object sender, EventArgs e)
        {

        }

    }
}
