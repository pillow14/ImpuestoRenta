using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml.Linq;
using LinqToExcel;
using System.Data.OleDb;
using System.Data.Entity.Validation;
using System.Web;
using System.Configuration;

namespace WinformApp.ImpuestoRentaAppDAL
{
    public class UsuarioDAL
    {
        private GSV_EnvioImpuestoRentaEntities db = new GSV_EnvioImpuestoRentaEntities();

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

        /// <summary>
        /// Insercion de datos de carga masiva
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public int InsertarCargaMasivaUsuarios(string path)
        {
            int resultado = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["Excel07ConString"].ConnectionString;

            DataTable dt = new DataTable();
            connectionString = string.Format(connectionString, path);

            using (OleDbConnection connExcel = new OleDbConnection(connectionString))
            {
                using (OleDbCommand cmdExcel = new OleDbCommand())
                {
                    using (OleDbDataAdapter odaExcel = new OleDbDataAdapter())
                    {
                        cmdExcel.Connection = connExcel;

                        //Get the name of First Sheet.
                        connExcel.Open();
                        DataTable dtExcelSchema;
                        dtExcelSchema = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                        string sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                        connExcel.Close();

                        //Read Data from First Sheet.
                        connExcel.Open();
                        cmdExcel.CommandText = "SELECT * From [" + sheetName + "]";
                        odaExcel.SelectCommand = cmdExcel;
                        odaExcel.Fill(dt);
                        connExcel.Close();
                    }
                }
            }

            foreach (DataRow row in dt.Rows)
            {
                if (row["nombre_usuario"].ToString() != "" && row["correo_electronico"].ToString() != "" && row["rut"].ToString() != "" && row["clave"].ToString() != "")
                {

                    db.Usuario.Add(new Usuario
                    {
                        nombre_usuario = row["nombre_usuario"].ToString(),
                        correo_electronico = row["correo_electronico"].ToString(),
                        esta_activo = true,
                        rut = row["rut"].ToString(),
                        clave = row["clave"].ToString(),
                    });

                }
                else
                {
                    return resultado;
                    
                }

            }

             return resultado = db.SaveChanges();

        }

    }
}
