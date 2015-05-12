using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace SvetskiResursi
{
    [Serializable]
   public class tipResursa
    {
            public string  oznaka{get; set;}
         
            public System.Drawing.Image ikonica{get; set;}
          
            public string ime{get; set;}
         
            public string opis{get; set;}
         
        }

    [Serializable]
   public class tipoviResursa {         
 
        public static tipoviResursa instanca=null;
        public   tipoviResursa() { }
        public static tipoviResursa getInstance()
        {
            if (instanca == null)
                instanca = new tipoviResursa();
            return instanca;
        } 
       
        public void Dodaj(tipResursa t){

            using (Stream stream = new FileStream("Tipovi.bin", FileMode.Append, FileAccess.Write, FileShare.None))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, t);
                stream.Close();
            }
        }
    }
}
