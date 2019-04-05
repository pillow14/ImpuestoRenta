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

        [System.Web.Http.AcceptVerbs("GET", "POST")]
        [HttpGet]
        public IHttpActionResult ObtenerListaUsuarios()
        {
            List<WinformApp.ImpuestoRentaAppDAL.BO.UsuarioBO> listaUsuarios = new List<WinformApp.ImpuestoRentaAppDAL.BO.UsuarioBO>();
            listaUsuarios = usuarioBll.ObtenerListaUsuario();
            return Ok(listaUsuarios);
        }

        [System.Web.Http.AcceptVerbs("GET", "POST")]
        [HttpGet]
        public IHttpActionResult ObtenerUsuarioPorRut(string rut)
        {
            WinformApp.ImpuestoRentaAppDAL.Usuario usuario = new WinformApp.ImpuestoRentaAppDAL.Usuario();
            usuario = usuarioBll.ObtenerUsuarioPorRut(rut);

            return Ok(usuario);
        }
    }
}
