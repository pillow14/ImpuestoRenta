//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinformApp.ImpuestoRentaAppDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ImpuestoRenta
    {
        public ImpuestoRenta()
        {
            this.LogActividad = new HashSet<LogActividad>();
        }
    
        public int impuestorenta_id { get; set; }
        public Nullable<int> impuestorentatipo_id { get; set; }
        public bool esta_activo { get; set; }
    
        public virtual ImpuestoRentaTipo ImpuestoRentaTipo { get; set; }
        public virtual ICollection<LogActividad> LogActividad { get; set; }
    }
}