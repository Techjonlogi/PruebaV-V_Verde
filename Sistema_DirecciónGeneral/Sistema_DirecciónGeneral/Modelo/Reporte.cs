//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sistema_DirecciónGeneral.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reporte
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reporte()
        {
            this.VehiculoReporte = new HashSet<VehiculoReporte>();
        }
    
        public int idReporte { get; set; }
        public string calle { get; set; }
        public string colonia { get; set; }
        public string codigoPostal { get; set; }
        public int numCarrosInvolucrados { get; set; }
        public bool evidencia { get; set; }
        public string folio { get; set; }
        public int idDelegación { get; set; }
        public Nullable<int> idImagen { get; set; }
    
        public virtual Delegacion Delegacion { get; set; }
        public virtual Dictamen Dictamen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehiculoReporte> VehiculoReporte { get; set; }
    }
}
