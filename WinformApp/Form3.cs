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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Boton que guarda nuevo tipo impuesto renta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            ImpuestoRentaAppBLL.ImpuestoRentaTipoBLL impuestoRentaBll = new ImpuestoRentaAppBLL.ImpuestoRentaTipoBLL();
            ImpuestoRentaAppBLL.LogActividadBLL logActividadBll = new ImpuestoRentaAppBLL.LogActividadBLL();
            ImpuestoRentaAppDAL.LogActividad logActividad = new ImpuestoRentaAppDAL.LogActividad();
            string mensaje = string.Empty;
            try
            {
                ImpuestoRentaAppDAL.ImpuestoRentaTipo impuestoRentaTipo = new ImpuestoRentaAppDAL.ImpuestoRentaTipo();
                impuestoRentaTipo.descripcion_impuesto_renta_tipo = textBox1.Text;
                impuestoRentaTipo.esta_activo = checkBox1.Checked;

                if (string.IsNullOrEmpty(impuestoRentaTipo.descripcion_impuesto_renta_tipo) || impuestoRentaTipo.esta_activo == false)
                {
                    mensaje = "No debe dejar campos vacíos o dejar No activo";
                    MessageBox.Show(mensaje);

                }
                else
                {

                    if (impuestoRentaBll.IngresarTipoImpuestoRenta(impuestoRentaTipo))
                    {
                        logActividad.descripcion_accion = mensaje;
                        logActividad.nombre_usuario = "germansoto";
                        logActividad.fecha_accion = DateTime.Now;
                        logActividad.condicion_accion = true;
                        logActividad.esta_activo = checkBox1.Checked;

                        logActividadBll.IngresarLogActividad(logActividad);

                        mensaje = "Tipo de impuesto a la renta ingresado exitosamente";
                        MessageBox.Show(mensaje);
                        
                        textBox1.Clear();
                    }
                    else
                    {
                        mensaje = "Ocurrio un error al ingresar tipo de impuesto a la renta, revise log de actividad para mas detalle";

                        logActividad.descripcion_accion = mensaje;
                        logActividad.nombre_usuario = "germansoto";
                        logActividad.fecha_accion = DateTime.Now;
                        logActividad.condicion_accion = false;
                        logActividad.esta_activo = true;

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
                MessageBox.Show("Ha ocurrido un error",ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
