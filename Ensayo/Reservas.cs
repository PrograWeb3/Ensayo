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
    
    public partial class Reservas
    {
        public int IdReserva { get; set; }
        public int IdSede { get; set; }
        public int IdVersion { get; set; }
        public int IdPelicula { get; set; }
        public System.DateTime FechaHoraInicio { get; set; }
        public string Email { get; set; }
        public int IdTipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public int CantidadEntradas { get; set; }
        public System.DateTime FechaCarga { get; set; }
    
        public virtual Peliculas Peliculas { get; set; }
        public virtual Sedes Sedes { get; set; }
        public virtual TiposDocumentos TiposDocumentos { get; set; }
        public virtual Versiones Versiones { get; set; }
    }
}
