using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformApp.ImpuestoRentaAppDAL.BO
{
    public class UsuarioBO
    {
        public string NombreUsuario { get; set; }
        public string CorreoElectronico { get; set; }
        public string Rut { get; set; }
        public string Clave { get; set; }
        public bool EstaActivo { get; set; }
        public string DescripcionEstaActivo { get; set; }
    }
}
