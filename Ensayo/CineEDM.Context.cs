﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CineContext : DbContext
    {
        public CineContext()
            : base("name=CineContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Calificaciones> Calificaciones { get; set; }
        public DbSet<Carteleras> Carteleras { get; set; }
        public DbSet<Generos> Generos { get; set; }
        public DbSet<Peliculas> Peliculas { get; set; }
        public DbSet<Reservas> Reservas { get; set; }
        public DbSet<Sedes> Sedes { get; set; }
        public DbSet<TiposDocumentos> TiposDocumentos { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Versiones> Versiones { get; set; }
    }
}
