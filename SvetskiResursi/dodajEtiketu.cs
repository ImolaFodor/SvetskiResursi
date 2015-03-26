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
            //if (colorDialog2.ShowDialog() == DialogResult.OK)
            //{
                //this.BackColor = colorDialog2.Color;
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Etiketa et = new Etiketa();

            et.oznaka = textBox1.Text;
            et.opis = richTextBox1.Text;
            et.boja = button1.BackColor; //vrv ne valja


            SvetskiResursi.Etikete.getInstance().Dodaj(et);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
