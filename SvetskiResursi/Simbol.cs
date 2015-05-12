using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SvetskiResursi
{
    [Serializable]
   public class Simbol
    {
        public Point lokacija { get; set; }
        public Bitmap slika { get; set; }
        public String ime { get; set; }
        public String oznaka { get; set; }
        public String tipR { get; set; }
        public String opis { get; set; }
        public String etiketa { get; set; }
        public String datum { get; set; }

        public Simbol() {
            ime = " ";
            oznaka = " ";
            tipR = " ";
            opis = " ";
            //datum = " ";
            etiketa = "nema tagova";

        
        
        }
        
    }
}
