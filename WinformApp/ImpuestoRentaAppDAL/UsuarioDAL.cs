using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformApp.ImpuestoRentaAppDAL
{
    public class UsuarioDAL
    {

        public Usuario ObtenerUsuarioPorRut(string rut)
        {
            using (var db = new GSV_EnvioImpuestoRentaEntities())
            {
                var query = from a in db.Usuario
                            where a.rut == rut &&
                            a.esta_activo == true
                            select a;

                return query.FirstOrDefault();
            }
        }

        public List<ImpuestoRentaAppDAL.BO.UsuarioBO> ObtenerListaUsuario()
        {
            using (GSV_EnvioImpuestoRentaEntities Gsv_EnvioImpuestoRentaEntities = new GSV_EnvioImpuestoRentaEntities())
            {
                var query = (from a in Gsv_EnvioImpuestoRentaEntities.Usuario
                             where a.esta_activo == true

                             select new ImpuestoRentaAppDAL.BO.UsuarioBO
                             {

                                 NombreUsuario = a.nombre_usuario,
                                 CorreoElectronico = a.correo_electronico,
                                 Rut = a.rut,
                                 Clave = a.clave,
                                 EstaActivo = a.esta_activo
                             });

                return query.ToList();
            }
        }

        public bool IngresarUsuario(Usuario usuario)
        {
            using (var db = new GSV_EnvioImpuestoRentaEntities())
            {
                db.Usuario.Add(usuario);
                db.SaveChanges();
                return true;
            }
        }
    }
}
