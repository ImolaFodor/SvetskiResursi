using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace SvetskiResursi
{
    [Serializable]
    class Etiketa
    {
        public string oznaka;
        public string opis;
        public Color boja;
    }

    [Serializable]
    class Etikete
    {
        private Dictionary<String, Etiketa> tr = new Dictionary<String, Etiketa>();

        public static Etikete instanca = null;
        public Etikete() { }
        public static Etikete getInstance()
        {
            if (instanca == null)
                instanca = new Etikete();
            return instanca;
        }


        public void Dodaj(Etiketa t)
        {
            tr.Add(t.oznaka, t);
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Etikete.bin", FileMode.Append, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, tr);
            stream.Close();
        }


        public Dictionary<string, Etiketa> getAll()
        {
            return tr;
        }

    }
}
