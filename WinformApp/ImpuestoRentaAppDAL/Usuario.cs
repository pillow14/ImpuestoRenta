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
    
    public partial class Usuario
    {
        public Usuario()
        {
            this.LogActividad = new HashSet<LogActividad>();
        }
    
        public int usuario_id { get; set; }
        public string nombre_usuario { get; set; }
        public string correo_electronico { get; set; }
        public bool esta_activo { get; set; }
        public string rut { get; set; }
        public string clave { get; set; }
    
        public virtual ICollection<LogActividad> LogActividad { get; set; }
    }
}