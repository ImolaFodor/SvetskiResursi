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
    public partial class dodajTipResursa : Form
    {
        private OpenFileDialog ofd = new OpenFileDialog();

        public dodajTipResursa()
        {
            InitializeComponent();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d = ofd.ShowDialog();
            if (d == DialogResult.OK)
            {
                string fname = ofd.FileName;
                Image img = new Bitmap(fname);
                pictureBox1.BackgroundImage = img;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

            //data
            tipResursa tipRes = new tipResursa();

            tipRes.oznaka = oznaka_tip.Text;
            tipRes.ime = ime_tip.Text;
            tipRes.opis = opis_tip.Text;
            tipRes.ikonica = (Image)pictureBox1.BackgroundImage;

            SvetskiResursi.tipoviResursa.getInstance().Dodaj(tipRes);
            Dictionary<string, tipResursa> privremeni = SvetskiResursi.tipoviResursa.getInstance().getAll();

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Tipovi.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, privremeni);
            stream.Close();


            this.DialogResult = DialogResult.OK;
            this.Close();

        }



    }
}