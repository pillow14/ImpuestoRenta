using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformApp.ImpuestoRentaAppBLL
{
    public class UsuarioBLL
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ObtenerUsuario"></param>
        /// <returns></returns>
        public ImpuestoRentaAppDAL.Usuario ObtenerUsuarioPorRut(string rut)
        {
            ImpuestoRentaAppDAL.Usuario nuevoUsuario =  new ImpuestoRentaAppDAL.Usuario();
            ImpuestoRentaAppDAL.UsuarioDAL usuarioDal = new ImpuestoRentaAppDAL.UsuarioDAL();
            return nuevoUsuario = usuarioDal.ObtenerUsuarioPorRut(rut);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<ImpuestoRentaAppDAL.BO.UsuarioBO> ObtenerListaUsuario()
        {
            List<ImpuestoRentaAppDAL.BO.UsuarioBO> listaUsuario = new List<ImpuestoRentaAppDAL.BO.UsuarioBO>();
            ImpuestoRentaAppDAL.UsuarioDAL usuarioDal = new ImpuestoRentaAppDAL.UsuarioDAL();
            listaUsuario = usuarioDal.ObtenerListaUsuario();
            foreach (var lista in listaUsuario)
            {
                if (lista.EstaActivo == true)
                {
                    lista.DescripcionEstaActivo = "Si";
                }
                else
                {
                    lista.DescripcionEstaActivo = "No";
                }
            }

            return listaUsuario;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool IngresarUsuario(ImpuestoRentaAppDAL.Usuario usuario)
        {
            ImpuestoRentaAppDAL.UsuarioDAL usuarioDal = new ImpuestoRentaAppDAL.UsuarioDAL();
            return usuarioDal.IngresarUsuario(usuario);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public int InsertarCargaMasivaUsuarios(string path)
        {
            int resultado = 0;
            ImpuestoRentaAppDAL.UsuarioDAL usuarioDal = new ImpuestoRentaAppDAL.UsuarioDAL();
            resultado = usuarioDal.InsertarCargaMasivaUsuarios(path);
            return resultado;
        }
    }
}
