using SvetskiResursi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCI_projekat
{
    public partial class FormV : Form
    {
        private OpenFileDialog ofd = new OpenFileDialog();
        public FormV()
        {
            InitializeComponent();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";
            
            //PUNIS COMBO SA SVIM NOVIM
            Dictionary<string, tipResursa> privremeni  =  SvetskiResursi.tipoviResursa.getInstance().getAll();
                

            foreach(tipResursa tip in privremeni.Values){
                comboTipResursa.Items.Add(tip.oznaka+tip.ime);
                
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

        private void comboTipResursa_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboTipResursa.Items.Add(sender);
        }




    }
}
