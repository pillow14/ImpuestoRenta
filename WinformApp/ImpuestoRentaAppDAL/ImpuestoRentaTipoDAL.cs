using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformApp.ImpuestoRentaAppDAL
{
    public class ImpuestoRentaTipoDAL
    {
        public List<ImpuestoRentaAppDAL.BO.ImpuestoRentaTipoBO> ObtenerListaTipoImpuestoRenta()
        {
            using (GSV_EnvioImpuestoRentaEntities Gsv_EnvioImpuestoRentaEntities = new GSV_EnvioImpuestoRentaEntities())
            {
                var query = (from a in Gsv_EnvioImpuestoRentaEntities.ImpuestoRentaTipo
                             where a.esta_activo == true

                             select new ImpuestoRentaAppDAL.BO.ImpuestoRentaTipoBO
                             {

                                 DescripcionImpuestoRentaTipo = a.descripcion_impuesto_renta_tipo,
                                 EstaActivo = a.esta_activo
                             });

                return query.ToList();
            }
        }

       public  bool IngresarTipoImpuestoRenta(ImpuestoRentaTipo impuestoRentaTipo)
        {
            using (var db = new GSV_EnvioImpuestoRentaEntities())
            {
                db.ImpuestoRentaTipo.Add(impuestoRentaTipo);
                db.SaveChanges();
                return true;
            }
        }
    }
}
