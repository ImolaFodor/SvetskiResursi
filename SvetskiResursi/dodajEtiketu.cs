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
    public partial class dodajEtiketu : Form
    {
        public dodajEtiketu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                label5.BackColor = colorDialog1.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Etiketa et = new Etiketa();
            DialogObavestenja db = new DialogObavestenja();

            et.oznaka = textBox1.Text;
            et.opis = richTextBox1.Text;
            et.boja = label5.BackColor; //vrv ne valja

            //provera da li su uneta obavezna polja
            if (et.oznaka.Equals(""))
            {
                db.ShowDialog();

            }
            else
            {

                SvetskiResursi.Etikete.getInstance().Dodaj(et);
                Dictionary<string, Etiketa> privremeni = SvetskiResursi.Etikete.getInstance().getAll();

                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("Etikete.txt", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, privremeni);
                stream.Close();
                

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
