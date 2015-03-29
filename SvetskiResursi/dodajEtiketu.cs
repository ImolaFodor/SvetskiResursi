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

                List<string> elementi = new List<string>();
                elementi.Add(et.oznaka);
                elementi.Add(et.opis);
                //elementi.Add(et.boja);
                elementi.Add(":");

                using (System.IO.StreamWriter file = new System.IO.StreamWriter("Etiketa.txt", true))
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
}
