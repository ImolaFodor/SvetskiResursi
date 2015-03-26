﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SvetskiResursi
{
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

        //treba za datum

        public string pojavljivanje { get; set; }

        public string opis { get; set; }
    }

    class Resursi {
        private Dictionary<String, Resurs> tr = new Dictionary<String, Resurs>();
       
        
        
        public static Resursi instanca=null;
        private   Resursi() { }
        public static Resursi getInstance()
        {
            if (instanca == null)
                instanca = new Resursi();
            return instanca;
        } 
       

        public void Dodaj(Resurs t){
            tr.Add(t.oznaka, t);
        }


        public Dictionary<string, Resurs> getAll(){
        return tr;
        }

    }
}
