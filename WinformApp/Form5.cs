using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformApp
{
    public partial class Form5 : MetroSet_UI.Forms.MetroSetForm
    {
        Util.Utilitario utilitario = new Util.Utilitario();
        
        public Form5()
        {
            InitializeComponent();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            ImpuestoRentaAppBLL.UsuarioBLL usuarioBll = new ImpuestoRentaAppBLL.UsuarioBLL();
            ImpuestoRentaAppBLL.LogActividadBLL logActividadBll = new ImpuestoRentaAppBLL.LogActividadBLL();
            ImpuestoRentaAppDAL.LogActividad logActividad = new ImpuestoRentaAppDAL.LogActividad();
            string mensaje = string.Empty;
            try
            {
                ImpuestoRentaAppDAL.Usuario usuario = new ImpuestoRentaAppDAL.Usuario();
                usuario.nombre_usuario = txtNombreUsuario.Text;
                usuario.correo_electronico = txtCorreoElectronico.Text;
                usuario.rut = txtRut.Text;
                usuario.clave = txtClave.Text;
                usuario.esta_activo = true;

                if (string.IsNullOrEmpty(usuario.nombre_usuario) || string.IsNullOrEmpty(usuario.correo_electronico) || string.IsNullOrEmpty(usuario.rut)||string.IsNullOrEmpty(usuario.clave))
                {
                    mensaje = "No debe dejar campos vacíos";
                    MessageBox.Show(mensaje);

                }

                //else if (!utilitario.ValidarRut(usuario.rut))
                //{
                //    mensaje = "Rut inválido.Favor de ingresar uno con formato correcto";
                //    MessageBox.Show(mensaje);
                //}
                else
                {

                    if (usuarioBll.IngresarUsuario(usuario))
                    {
                        mensaje = "Usuario ingresado exitosamente";
                        logActividad.usuario_id = 1;
                        logActividad.log_id = 2;
                        logActividad.descripcion_accion = mensaje;
                        logActividad.nombre_usuario = "germansoto";
                        logActividad.fecha_accion = DateTime.Now;
                        logActividad.condicion_accion = true;
                        logActividad.esta_activo = true;
                        logActividad.impuestorenta_id = 1;

                        logActividadBll.IngresarLogActividad(logActividad);

                        
                        MessageBox.Show(mensaje);
                                               
                    }
                    else
                    {
                        mensaje = "Ocurrio un error al ingresar nuevo usuario, revise log de actividad para mas detalle";
                        logActividad.usuario_id = 1;
                        logActividad.log_id = 1;
                        logActividad.descripcion_accion = mensaje;
                        logActividad.nombre_usuario = "germansoto";
                        logActividad.fecha_accion = DateTime.Now;
                        logActividad.condicion_accion = false;
                        logActividad.esta_activo = true;
                        logActividad.impuestorenta_id = 1;

                        logActividadBll.IngresarLogActividad(logActividad);
                        MessageBox.Show(mensaje);
                    }
                }


            }
            catch (Exception ex)
            {
                logActividad.descripcion_accion = ex.Message;
                logActividad.nombre_usuario = "germansoto";
                logActividad.fecha_accion = DateTime.Today;
                logActividad.condicion_accion = false;
                logActividad.esta_activo = true;

                logActividadBll.IngresarLogActividad(logActividad);
                MessageBox.Show("Ha ocurrido un error", ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
