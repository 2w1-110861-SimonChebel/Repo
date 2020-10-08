using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prueba.Models.ViewModel
{
    public class Telefono
    {
        //public int PreFijo { get; set; }

        public string Tel { get; set; }


        public int numero { get; set; }
        public int preFijo { get; set; }

        public override string ToString()
        {
            return "Telefono: " + preFijo + " " + numero;
        }
    }
}