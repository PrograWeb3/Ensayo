//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ensayo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Calificaciones
    {
        public Calificaciones()
        {
            this.Peliculas = new HashSet<Peliculas>();
        }
    
        public int IdCalificacion { get; set; }
        public string Nombre { get; set; }
    
        public virtual ICollection<Peliculas> Peliculas { get; set; }
    }
}
