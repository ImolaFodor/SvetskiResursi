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
    class tipResursa
    {
            public string  oznaka{get; set;}
         
            public System.Drawing.Image ikonica{get; set;}
          
            public string ime{get; set;}
         
            public string opis{get; set;}
         
        }

    [Serializable]
    class tipoviResursa { 


        private Dictionary<String, tipResursa> tr = new Dictionary<String, tipResursa>();
       
        
        /// <summary>
        /// //////////////////////////////////////
        /// </summary>
        public static tipoviResursa instanca=null;
        private   tipoviResursa() { }
        public static tipoviResursa getInstance()
        {
            if (instanca == null)
                instanca = new tipoviResursa();
            return instanca;
        } 
       /// <summary>
       /// /////////////////////////////////////////
       /// </summary>
       /// <param name="t"></param>



        public void Dodaj(tipResursa t){
            tr.Add(t.oznaka, t);

        }


        public void memorisiDat() {
            IFormatter formatter = new BinaryFormatter();


            Stream stream = new FileStream("Tipovi.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            
            formatter.Serialize(stream, tr);
            stream.Close();
        
        }



        public Dictionary<string, tipResursa> getAll(){
                 return tr;
        }

    }
}
