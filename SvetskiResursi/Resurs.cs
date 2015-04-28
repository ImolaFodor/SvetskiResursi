using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace SvetskiResursi
{
    [Serializable]
    class Resurs
    {
        public string oznaka { get; set; }

        public System.Drawing.Image ikonica { get; set; }

        public string ime { get; set; }

        public string tipResursa { get; set; } //combo vraca string

        public string obnovljivo { get; set; }

        public string eksploatacija { get; set; }

        public string strateska_vaznost { get; set; }

        public string jedinica_mere { get; set; }

        public string cena { get; set; }

        public string datum_kao { get; set; }//treba za datum

        public string pojavljivanje { get; set; }

        public string opis { get; set; }

        public List<string> oz_etiketa { get; set; }

        public Resurs() {
            ime = " ";
            oznaka = " ";
            tipResursa = " ";
            opis = " ";
           // oz_etiketa = "nema tagova";

        
        
        }
    }

    [Serializable]
    class Resursi {
      //  private Dictionary<String, Resurs> r = new Dictionary<String, Resurs>();
        
        
        
        public static Resursi instanca=null;
        public   Resursi() { }
        public static Resursi getInstance()
        {
            if (instanca == null)
                instanca = new Resursi();
            return instanca;
        } 
       

        public void Dodaj(Resurs t){
          
            using (Stream stream = new FileStream("Resursi.bin", FileMode.Append, FileAccess.Write, FileShare.None))
            {
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                formatter.Serialize(stream, t);
                stream.Close();
            }
        }

        public List<Etiketa> tags
        {
            get;
            set;
        }


    }
}

