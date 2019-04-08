using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ImpuestoRentaApp.WebApi.Models;
using ImpuestoRentaApp.WebApi.Constantes;

namespace ImpuestoRentaApp.WebApi.Controllers
{
    
    public class UsuariosController : ApiController
    {
        WinformApp.ImpuestoRentaAppBLL.UsuarioBLL usuarioBll = new WinformApp.ImpuestoRentaAppBLL.UsuarioBLL();

        /// <summary>
        /// Obtiene lista de usuarios
        /// </summary>
        /// <returns></returns>
        [Route("api/usuarios/ObtenerListaUsuarios")]
        [HttpGet]
        public IHttpActionResult ObtenerListaUsuarios()
        {
            try
            {
                List<WinformApp.ImpuestoRentaAppDAL.BO.UsuarioBO> listaUsuarios = new List<WinformApp.ImpuestoRentaAppDAL.BO.UsuarioBO>();
                listaUsuarios = usuarioBll.ObtenerListaUsuario();
                if (listaUsuarios.Count > 0)
                {
                    return Content(HttpStatusCode.Accepted,listaUsuarios);
                }
                else
                {
                    return Content(HttpStatusCode.NoContent,"no se encontraron resultados");
                }
            }catch(Exception ex)
            {
                return Content (HttpStatusCode.BadRequest, ex.Message);
            }
        }

        /// <summary>
        /// Obtiene usuario por rut unico
        /// </summary>
        /// <param name="rut"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/usuarios/ObtenerUsuarioPorRut/{rut}")]
        public IHttpActionResult ObtenerUsuarioPorRut(string rut)
        {
            WinformApp.ImpuestoRentaAppDAL.BO.UsuarioBO usuarioBo = new WinformApp.ImpuestoRentaAppDAL.BO.UsuarioBO();
            WinformApp.ImpuestoRentaAppDAL.Usuario usuario = new WinformApp.ImpuestoRentaAppDAL.Usuario();
            usuarioBo = null;
            try
            {
                usuario = usuarioBll.ObtenerUsuarioPorRut(rut);

                if (usuario != null)
                {
                    usuarioBo = new WinformApp.ImpuestoRentaAppDAL.BO.UsuarioBO()
                    {
                        NombreUsuario = usuario.nombre_usuario,
                        CorreoElectronico = usuario.correo_electronico,
                        EstaActivo = usuario.esta_activo,
                        DescripcionEstaActivo = usuario.esta_activo == true ? "SI" : "NO",
                        Rut = usuario.rut,
                        Clave = usuario.clave
                    };

                    return Content(HttpStatusCode.Accepted, usuarioBo);
                }
                else
                {
                    return Content(HttpStatusCode.NoContent,"No se encontraron resultados");

                }

            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex.Message);

            }

        }
    }
}
