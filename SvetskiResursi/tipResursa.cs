using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SvetskiResursi
{
    class tipResursa
    {
            public string  oznaka{get; set;}
         
            public System.Drawing.Image ikonica{get; set;}
          
            public string ime{get; set;}
         
            public string opis{get; set;}
         
        }

    class tipoviResursa { 
        public Dictionary<String, tipResursa> tr = new Dictionary<String, tipResursa>();
        private readonly string _datoteka;
        public tipoviResursa()
        {
            //_datoteka = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tipovispomenika.podaci");
            //UcitajDatoteku();
        }


        public void Dodaj(tipResursa TR)
        {
            if (!tr.ContainsKey(TR.oznaka))
                tr.Add(TR.oznaka, TR);
        }
    
    }
}
