//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class VehiculoReporte
    {
        public int idVehiculoReporte { get; set; }
        public string placas { get; set; }
        public int idReporte { get; set; }
    
        public virtual Reporte Reporte { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }
    }
}
