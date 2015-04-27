using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SvetskiResursi
{
    [Serializable]
    class Simbol
    {
        public Point lokacija { get; set; }
        public Bitmap slika { get; set; }
        public string oznaka { get; set; }
    }
}
