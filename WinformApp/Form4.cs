using FastMember;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformApp
{
    public partial class Form4 : MetroSet_UI.Forms.MetroSetForm
    {
        public Form4()
        {
            InitializeComponent();
            CargaDataTablaUsuario();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargaDataTablaUsuario()
        {
            DataTable tablaDatos = new DataTable();
            IEnumerable<ImpuestoRentaAppDAL.BO.UsuarioBO> listaUsuario = new List<ImpuestoRentaAppDAL.BO.UsuarioBO>();
            WinformApp.ImpuestoRentaAppBLL.UsuarioBLL usuarioBll = new ImpuestoRentaAppBLL.UsuarioBLL();
            listaUsuario = usuarioBll.ObtenerListaUsuario();

            using (var reader = ObjectReader.Create(listaUsuario))
            {
                tablaDatos.Load(reader);
            }

            var fuente = new BindingSource(tablaDatos, null);
            dgUsuarios.DataSource = fuente;

            dgUsuarios.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8.0F, FontStyle.Bold);
            foreach (DataGridViewColumn columna in dgUsuarios.Columns)
            {
                columna.DefaultCellStyle.Font = new Font("Arial", 8.0F);
                //columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        /// <summary>
        /// Boton para cargar archivo excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargaMasiva_Click(object sender, EventArgs e)
        {
            int resultado;
            try
            {
                DialogResult dialog = fileExcel.ShowDialog();
                fileExcel.Filter = "allfiles|*.xls";
                if (dialog == DialogResult.OK) // Test result.
                {
                    WinformApp.ImpuestoRentaAppBLL.UsuarioBLL usuarioBll = new ImpuestoRentaAppBLL.UsuarioBLL();
                    resultado = usuarioBll.InsertarCargaMasivaUsuarios(fileExcel.FileName);

                    if(resultado != 0)
                    {
                        MessageBox.Show("Carga masiva exitosa!");
                        CargaDataTablaUsuario();
                    }
                    else
                    {
                        MessageBox.Show("Error en carga masiva. Consulte Log de actividades");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente error:" + "" + ex.Message);
            }

        }
    }
}

