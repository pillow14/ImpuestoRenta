using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ImpuestoRentaApp.WebApi.Models;

namespace ImpuestoRentaApp.WebApi.Controllers
{
    
    public class UsuariosController : ApiController
    {
        WinformApp.ImpuestoRentaAppBLL.UsuarioBLL usuarioBll = new WinformApp.ImpuestoRentaAppBLL.UsuarioBLL();

        /// <summary>
        /// Obtiene lista de usuarios
        /// </summary>
        /// <returns></returns>
        [System.Web.Http.AcceptVerbs("GET", "POST")]
        [HttpGet]
        public IHttpActionResult ObtenerListaUsuarios()
        {
            List<WinformApp.ImpuestoRentaAppDAL.BO.UsuarioBO> listaUsuarios = new List<WinformApp.ImpuestoRentaAppDAL.BO.UsuarioBO>();
            listaUsuarios = usuarioBll.ObtenerListaUsuario();
            return Ok(listaUsuarios);
        }

        /// <summary>
        /// Obtiene usuario por rut unico
        /// </summary>
        /// <param name="rut"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/usuarios/ObtenerUsuarioPorRut")]
        public IHttpActionResult ObtenerUsuarioPorRut(string rut)
        {
            WinformApp.ImpuestoRentaAppDAL.BO.UsuarioBO usuarioBo = new WinformApp.ImpuestoRentaAppDAL.BO.UsuarioBO();
            WinformApp.ImpuestoRentaAppDAL.Usuario usuario = new WinformApp.ImpuestoRentaAppDAL.Usuario();
            usuario = usuarioBll.ObtenerUsuarioPorRut(rut);

            usuarioBo = new WinformApp.ImpuestoRentaAppDAL.BO.UsuarioBO()
            {
                NombreUsuario = usuario.nombre_usuario,
                CorreoElectronico = usuario.correo_electronico,
                EstaActivo = usuario.esta_activo,
                DescripcionEstaActivo = usuario.esta_activo ==true? "SI" : "NO",
                Rut = usuario.rut,
                Clave = usuario.clave
            };

            return Ok(usuarioBo);
        }
    }
}
