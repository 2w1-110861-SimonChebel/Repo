using prueba.AccesoDatos;
using prueba.Models.Request;
using prueba.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.SessionState;

namespace prueba.Controllers
{

    [RoutePrefix("api/Fidelitytools/Personas")]
    public class PersonaController : ApiController
    {

        //JSON : {"nombre": "Nuevo","edad":22}
        [HttpPost, Route("Registrar")]
        public IHttpActionResult Add([FromBody] Models.Personas persona)
        {
            using (Models.PruebaApi db = new Models.PruebaApi())
            {
                               
                var oPersona = new Models.Personas();
                oPersona.nombre = persona.nombre;
                oPersona.edad = persona.edad;
                db.Personas.Add(oPersona);
                db.SaveChanges();
            }

            return Ok("Exito");
        }


        //JSON : {"nombre": "Nuevo"}
        [HttpGet, Route("Obtener")]
        public IHttpActionResult BuscarPersona([FromBody] string nombre)
        {
            Acceso a = new Acceso();
            PersonaRequest persona = a.obtenerPersona(nombre);

            //using (Models.PruebaApi db = new Models.PruebaApi())
            //{
            //    List<Models.Personas> lista = db.Personas.ToList();
            //    var listaPr = lista.Where(p => p.nombre.Contains(nombre)).Select(p => new PersonaRequest { Nombre = p.nombre, telefonos = p.tel.Select(t => new Telefono { Tel = t.preFijo + " " + t.numero }).ToList() }).FirstOrDefault();

            //}
            return Ok(persona);

        }

       
    }
}
