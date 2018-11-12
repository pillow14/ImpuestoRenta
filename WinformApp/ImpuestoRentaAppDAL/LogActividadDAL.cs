using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformApp.ImpuestoRentaAppDAL
{
    public class LogActividadDAL
    {
        public  bool IngresarLogActividad(LogActividad logActividad)
        {
            try
            {
                using (GSV_EnvioImpuestoRentaEntities db = new GSV_EnvioImpuestoRentaEntities())
                {
                    db.LogActividad.Add(logActividad);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
