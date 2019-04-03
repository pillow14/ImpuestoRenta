using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformApp
{

    public partial class FormularioPrincipal : MetroSet_UI.Forms.MetroSetForm
    {
        DirectoryInfo directorio1941 = new DirectoryInfo(ConfigurationManager.AppSettings["CarpetaArchivos1941"]);
        DirectoryInfo directorio1925 = new DirectoryInfo(ConfigurationManager.AppSettings["CarpetaArchivos1925"]);
        Util.Utilitario utilitario = new Util.Utilitario();
        ImpuestoRentaAppBLL.LogActividadBLL logActividadBll = new ImpuestoRentaAppBLL.LogActividadBLL();

        public FormularioPrincipal()
        {
            InitializeComponent();
            ObtenerArchivosDeclaracionJurada();
            btnProcesar.Enabled = false;
        }

        /// <summary>
        /// Click hacia mantenedor de usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroSetTile1_Click(object sender, EventArgs e)
        {
            try
            {
                Form4 formularioMantenedorUsuario = new Form4();
                formularioMantenedorUsuario.Show();
            }
            catch (Exception ex)
            {
                logActividadBll.IngresarLog(ex);
                return;
            }
        }

        private void metroSetTile2_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Click hacia mantenedor de tipo impuesto a la renta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroSetTile3_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 formularioMantenedorImpuestoRenta = new Form2();
                formularioMantenedorImpuestoRenta.Show();
            }
            catch (Exception ex)
            {
                logActividadBll.IngresarLog(ex);
                return;
            }
        }

        /// <summary>
        /// Click para realizar procesamiento de archivos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroSetButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroSetButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Obtiene sumario de declaraciones juradas en carpetas
        /// </summary>
        public void ObtenerArchivosDeclaracionJurada()
        {
            try
            {
                int contador = 0;
                checkedListBox1.Items.Clear();
                checkedListBox2.Items.Clear();

                //Checkeo de existencia de carpeta, si no existe la crea

                if (!Directory.Exists(Path.GetDirectoryName(ConfigurationManager.AppSettings["CarpetaArchivos1941"])) || !!Directory.Exists(ConfigurationManager.AppSettings["CarpetaArchivos1925"]))
                {
                    Directory.CreateDirectory(ConfigurationManager.AppSettings["CarpetaArchivos1941"]);
                    Directory.CreateDirectory(ConfigurationManager.AppSettings["CarpetaArchivos1925"]);
                }

                //Obtencion de nombre de archivos para cada tipo de impuesto a la renta

                FileInfo[] archivos1925 = directorio1925.GetFiles("*.zip");
                FileInfo[] archivos1941 = directorio1941.GetFiles("*.zip");
                foreach (FileInfo archivos in archivos1941)
                {
                    checkedListBox1.Items.Add(archivos.Name);
                    contador = contador + 1;
                }

                label1.Text = string.Concat("Existen", " ", contador.ToString(), " ", "archivos 1941 disponibles");

                contador = 0;

                foreach (FileInfo archivos in archivos1925)
                {
                    checkedListBox2.Items.Add(archivos.Name);
                    contador = contador + 1;
                }

                label2.Text = string.Concat("Existen", " ", contador.ToString(), " ", "archivos 1925 disponibles");
            }
            catch (Exception ex)
            {
                logActividadBll.IngresarLog(ex);
                return;
            }

        }
    }
}
