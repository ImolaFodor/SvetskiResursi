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
   public class Etiketa
    {
        public string oznaka;
        public string opis;
        public Color boja;
    }

    [Serializable]
    public class Etikete
    {

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
            using (Stream stream = new FileStream("Etikete.bin", FileMode.Append, FileAccess.Write, FileShare.None))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, t);
                stream.Close();
            }
        }
    }
}
