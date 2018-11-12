using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformApp.ImpuestoRentaAppBLL
{
    public class LogActividadBLL
    {
        ImpuestoRentaAppDAL.LogActividadDAL logActividadDal = new ImpuestoRentaAppDAL.LogActividadDAL();
       
        public bool IngresarLogActividad(ImpuestoRentaAppDAL.LogActividad logActividad)
        {
            try
            {
                
                return logActividadDal.IngresarLogActividad(logActividad);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public bool IngresarLog(Exception ex)
        {
            ImpuestoRentaAppDAL.LogActividadDAL logActividadDal = new ImpuestoRentaAppDAL.LogActividadDAL();
            ImpuestoRentaAppDAL.LogActividad logActividad = new ImpuestoRentaAppDAL.LogActividad();
            Util.Utilitario utilitario = new Util.Utilitario();

            logActividad.usuario_id = 1;
            logActividad.log_id = 2;
            string mensajeCorto = ex.Message;
            string mensajeLargo = ex.ToString();
            logActividad.descripcion_accion = Convert.ToString(mensajeCorto);
            logActividad.nombre_usuario = ex.Source;
            logActividad.fecha_accion = DateTime.Now;
            logActividad.condicion_accion = false;
            logActividad.esta_activo = true;
            logActividad.impuestorenta_id = 1;

            bool salida = logActividadDal.IngresarLogActividad(logActividad);
            return salida;
        }
    }
}