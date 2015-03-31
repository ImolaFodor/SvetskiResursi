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
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SvetskiResursi
{
    public partial class dodajEtiketu : Form
    {
        private Regex rx_oz = null;
        private bool formIsValid = true;

        Dictionary<object, bool> errorRepeat = new Dictionary<object, bool>();

        public dodajEtiketu()
        {
            InitializeComponent();
            rx_oz = new Regex("^\\w+$");

            errorRepeat.Add(textBox1,false);
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
            formIsValid = true;
            this.ValidateChildren();
            if (formIsValid) { 

                SvetskiResursi.Etikete.getInstance().Dodaj(et);
             
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void dodajEtiketu_Load(object sender, EventArgs e)
        {

        }
    }
}
