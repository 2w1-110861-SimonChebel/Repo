//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace prueba.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tel
    {
        public int id { get; set; }
        public int preFijo { get; set; }
        public int numero { get; set; }
        public int idPersona { get; set; }
    
        public virtual Personas Personas { get; set; }
    }
}
