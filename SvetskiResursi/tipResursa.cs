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
        private Dictionary<String, tipResursa> tr = new Dictionary<String, tipResursa>();
       
        
        
        public static tipoviResursa instanca=null;
        private   tipoviResursa() { }
        public static tipoviResursa getInstance()
        {
            if (instanca == null)
                instanca = new tipoviResursa();
            return instanca;
        } 
       

        public void Dodaj(tipResursa t){
            tr.Add(t.oznaka, t);
        }


        public Dictionary<string, tipResursa> getAll(){
        return tr;
        }

    }
}
