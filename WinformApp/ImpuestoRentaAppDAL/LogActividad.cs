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
    
    public partial class LogActividad
    {
        public int logactividad_id { get; set; }
        public Nullable<int> usuario_id { get; set; }
        public Nullable<int> log_id { get; set; }
        public string descripcion_accion { get; set; }
        public string nombre_usuario { get; set; }
        public System.DateTime fecha_accion { get; set; }
        public bool condicion_accion { get; set; }
        public bool esta_activo { get; set; }
        public Nullable<int> impuestorenta_id { get; set; }
    
        public virtual ImpuestoRenta ImpuestoRenta { get; set; }
        public virtual Log Log { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
