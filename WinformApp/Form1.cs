using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WinformApp
{
    public partial class Form1 : Form
    {
        DirectoryInfo directorio1941 = new DirectoryInfo(ConfigurationManager.AppSettings["CarpetaArchivos1941"]);
        DirectoryInfo directorio1925 = new DirectoryInfo(ConfigurationManager.AppSettings["CarpetaArchivos1925"]);
        Util.Utilitario utilitario = new Util.Utilitario();
        ImpuestoRentaAppBLL.LogActividadBLL logActividadBll = new ImpuestoRentaAppBLL.LogActividadBLL();

        /// <summary>
        /// 
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            ObtenerArchivosDeclaracionJurada();

        }

        private void tipoImpuestoRentaToolStripMenuItem_Click(object sender, EventArgs e)
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

            CheckedListBox.CheckedItemCollection objetos1941 = checkedListBox1.CheckedItems;
            CheckedListBox.CheckedItemCollection objetos1925 = checkedListBox2.CheckedItems;

            List<string> listaRutArchivos1941 = new List<string>();
            List<string> listaRutArchivos1925 = new List<string>();
            try
            {
                //Obtencion nombre de archivos para automatizacion
                if (objetos1941.Count > 0 || objetos1925.Count > 0)
                {

                    foreach (object listaRutArchivos1941Chequeados in objetos1941)
                    {

                        listaRutArchivos1941.Add((Path.GetFileNameWithoutExtension(listaRutArchivos1941Chequeados.ToString())));
                    }

                    foreach (object listaRutArchivos1925Chequeados in objetos1925)
                    {

                        listaRutArchivos1925.Add((Path.GetFileNameWithoutExtension(listaRutArchivos1925Chequeados.ToString())));
                    }

                    //Procesamiento sellenium
                    foreach (string rutLista in listaRutArchivos1941)
                    {
                        string rut = string.Empty;
                        rut = utilitario.CalculoDigitoVerificador(rutLista);
                        rut = utilitario.formatearRut(rut);
                        ProcesamientoSelenium(rut);
                    }

                    foreach (var lista in listaRutArchivos1925)
                    {
                        string rut = string.Empty;
                        rut = utilitario.CalculoDigitoVerificador(lista);
                        rut = utilitario.formatearRut(rut);
                        ProcesamientoSelenium(rut);
                    }

                    ObtenerArchivosDeclaracionJurada();

                }
                else
                {
                    MessageBox.Show("Favor seleccione algún archivo para procesar");
                }
            }
            catch (Exception ex)
            {
                logActividadBll.IngresarLog(ex);
                return;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rut"></param>
        public void ProcesamientoSelenium(string rut)
        {
            IWebDriver webDriver = new ChromeDriver();

            try
            {
                webDriver.Navigate().GoToUrl(ConfigurationManager.AppSettings["DireccionSii"]);
                webDriver.Manage().Window.Maximize();
                webDriver.FindElement(By.LinkText("Mi Sii")).Click();

                //obtener valor desde tabla usuario
                ImpuestoRentaAppBLL.UsuarioBLL usuarioBll = new ImpuestoRentaAppBLL.UsuarioBLL();
                ImpuestoRentaAppDAL.Usuario usuario = new ImpuestoRentaAppDAL.Usuario();

                usuario = usuarioBll.ObtenerUsuarioPorRut(rut);

                if (usuario != null)
                {
                    if (!string.IsNullOrEmpty(usuario.rut) || !string.IsNullOrEmpty(usuario.clave))
                    {
                        webDriver.FindElement(By.Id("rutcntr")).SendKeys(usuario.rut);
                        webDriver.FindElement(By.Id("clave")).SendKeys(usuario.clave);

                        webDriver.FindElement(By.XPath("//button[contains(text(),'Ingresar')]")).Click();

                        webDriver.FindElement(By.LinkText("Servicios online")).Click();

                        webDriver.FindElement(By.LinkText("Declaraciones juradas")).Click();

                        webDriver.FindElement(By.LinkText("Declaraciones juradas de Renta")).Click();

                        webDriver.Navigate().GoToUrl(ConfigurationManager.AppSettings["direccionSubidaArchivos"]);

                        //ingreso a sitio subida de archivos-carga de archivo

                        webDriver.FindElement(By.XPath("//input[@type='FILE']")).Click();

                        rut = rut.Replace("-", "");
                        rut = rut.Remove(rut.Length - 1);

                        FileInfo[] archivoBuscado = directorio1941.GetFiles("*" + rut + "*.zip");

                        foreach (FileInfo archivo in archivoBuscado)
                        {
                            webDriver.FindElement(By.XPath("//input[@type='FILE']")).SendKeys(archivo.FullName);

                            webDriver.FindElement(By.XPath("//input[@type='submit']")).Click();

                            //impresion de comprobante

                            //Guardar estado de operacion
                            ImpuestoRentaAppDAL.LogActividad logActividad = new ImpuestoRentaAppDAL.LogActividad();

                            logActividad.usuario_id = usuario.usuario_id;
                            logActividad.log_id = Util.Constantes.LOG_ESTADO_EXITO;
                            logActividad.descripcion_accion = "Archivo declaracion jurada cargado exitosamente";
                            logActividad.nombre_usuario = usuario.nombre_usuario;
                            logActividad.fecha_accion = DateTime.Now;
                            logActividad.condicion_accion = true;
                            logActividad.esta_activo = true;
                            logActividad.impuestorenta_id = Util.Constantes.IMPUESTO_1941;
                            bool retorno = logActividadBll.IngresarLogActividad(logActividad);

                            //Copia y traslado de archivo como procesado

                            string archivoDestino = System.IO.Path.Combine(ConfigurationManager.AppSettings["CarpetaArchivosProcesados"], archivo.Name);
                            File.Move(archivo.FullName, archivoDestino);
                            webDriver.Close();
                            ObtenerArchivosDeclaracionJurada();
                        }
                    }
                    else
                    {
                        //este usuario no posee cuenta en SII
                        MessageBox.Show(string.Concat("el rut", " ", rut, " ", "no posee contraseña de ingreso para SII.Favor de ingresarla previamente"));
                        webDriver.Close();

                    }

                }
                else
                {
                    //este usuario no existe o no posee credenciales
                    MessageBox.Show(string.Concat("el rut", " ", rut, " ", "no existe como usuario en sistema.Favor de crearlo previamente"));
                    webDriver.Close();

                }
            }
            catch (Exception ex)
            {
                logActividadBll.IngresarLog(ex);
                MessageBox.Show(string.Concat("Hubo un error en el proceso para rut", " ", rut, ".Revisar log de actividad para mas detalles."));
                webDriver.Close();
                return;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void ObtenerArchivosDeclaracionJurada()
        {
            try
            {
                int contador = 0;
                checkedListBox1.Items.Clear();
                checkedListBox2.Items.Clear();

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

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
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

    }
}