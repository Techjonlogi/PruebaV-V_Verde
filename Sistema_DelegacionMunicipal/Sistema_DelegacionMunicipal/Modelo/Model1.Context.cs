﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sistema_DelegacionMunicipal.Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SistemaReportesVehiculosEntities : DbContext
    {
        public SistemaReportesVehiculosEntities()
            : base("name=SistemaReportesVehiculosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Conductor> Conductor { get; set; }
        public virtual DbSet<Delegacion> Delegacion { get; set; }
        public virtual DbSet<Dictamen> Dictamen { get; set; }
        public virtual DbSet<Municipio> Municipio { get; set; }
        public virtual DbSet<Reporte> Reporte { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Vehiculo> Vehiculo { get; set; }
        public virtual DbSet<VehiculoReporte> VehiculoReporte { get; set; }
    }
}
