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
    public partial class Form2 : MetroSet_UI.Forms.MetroSetForm
    {
        public Form2()
        {
            InitializeComponent();
            DataTable tablaDatos = new DataTable();
            List<ImpuestoRentaAppDAL.BO.ImpuestoRentaTipoBO> listaImpuestoRentaTipo = new List<ImpuestoRentaAppDAL.BO.ImpuestoRentaTipoBO>();
            WinformApp.ImpuestoRentaAppBLL.ImpuestoRentaTipoBLL impuestoRentaTipoBll = new ImpuestoRentaAppBLL.ImpuestoRentaTipoBLL();
            listaImpuestoRentaTipo = impuestoRentaTipoBll.ObtenerListaTipoImpuestoRenta();

            tablaDatos = LINQResultToDataTable(listaImpuestoRentaTipo);             

            dataGridView2.DataSource = tablaDatos;

        }

        public DataTable LINQResultToDataTable<T>(IEnumerable<T> Linqlist)
        {
            DataTable dt = new DataTable();


            PropertyInfo[] columns = null;

            if (Linqlist == null) return dt;

            foreach (T Record in Linqlist)
            {

                if (columns == null)
                {
                    columns = ((Type)Record.GetType()).GetProperties();
                    foreach (PropertyInfo GetProperty in columns)
                    {
                        Type colType = GetProperty.PropertyType;

                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition()
                        == typeof(Nullable<>)))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }

                        dt.Columns.Add(new DataColumn(GetProperty.Name, colType));
                    }
                }

                DataRow dr = dt.NewRow();

                foreach (PropertyInfo pinfo in columns)
                {
                    dr[pinfo.Name] = pinfo.GetValue(Record, null) == null ? DBNull.Value : pinfo.GetValue
                    (Record, null);
                }

                dt.Rows.Add(dr);
            }
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }  
  

    }

}

