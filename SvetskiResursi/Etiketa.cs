using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SvetskiResursi
{
    class Etiketa
    {
        public string oznaka;
        public string opis;
        public Color boja;
    }

    class Etikete
    {
        private Dictionary<String, Etiketa> tr = new Dictionary<String, Etiketa>();

        //komentar

        public static Etikete instanca = null;
        private Etikete() { }
        public static Etikete getInstance()
        {
            if (instanca == null)
                instanca = new Etikete();
            return instanca;
        }


        public void Dodaj(Etiketa t)
        {
            tr.Add(t.oznaka, t);
        }


        public Dictionary<string, Etiketa> getAll()
        {
            return tr;
        }

    }
}
