using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformApp.ImpuestoRentaAppBLL
{
   public class ImpuestoRentaTipoBLL
    {
       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
       public List<ImpuestoRentaAppDAL.BO.ImpuestoRentaTipoBO> ObtenerListaTipoImpuestoRenta()
       {
           List<ImpuestoRentaAppDAL.BO.ImpuestoRentaTipoBO> listaImpuestoRentaTipo = new List<ImpuestoRentaAppDAL.BO.ImpuestoRentaTipoBO>();
           ImpuestoRentaAppDAL.ImpuestoRentaTipoDAL impuestoRentaTipoDal = new ImpuestoRentaAppDAL.ImpuestoRentaTipoDAL();
           listaImpuestoRentaTipo = impuestoRentaTipoDal.ObtenerListaTipoImpuestoRenta();
           foreach (var lista in listaImpuestoRentaTipo)
           {
               if (lista.EstaActivo==   true)
               {
                   lista.DescripcionEstaActivo = "Si";
               }else
               {
                   lista.DescripcionEstaActivo = "No";
               }
           }

           return listaImpuestoRentaTipo;
       }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="impuestoRentaTipo"></param>
       /// <returns></returns>
       public bool IngresarTipoImpuestoRenta(ImpuestoRentaAppDAL.ImpuestoRentaTipo impuestoRentaTipo)
       {
           ImpuestoRentaAppDAL.ImpuestoRentaTipoDAL impuestoRentaTipoDal = new ImpuestoRentaAppDAL.ImpuestoRentaTipoDAL();
            return impuestoRentaTipoDal.IngresarTipoImpuestoRenta(impuestoRentaTipo);
       }
    }
}
