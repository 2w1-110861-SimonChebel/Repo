using prueba.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prueba.Models.Request
{
    public class PersonaRequest
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public List<Telefono> telefonos { get; set; }

        public PersonaRequest()
        {
            this.telefonos = new List<Telefono>();
        }

    }
}