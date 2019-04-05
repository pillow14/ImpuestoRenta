using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformApp.Util
{
    public class Utilitario
    {
        public string formatearRut(string rut)
        {
            int cont = 0;
            string format;
            if (rut.Length == 0)
            {
                return "";
            }
            else
            {
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                format = "-" + rut.Substring(rut.Length - 1);
                for (int i = rut.Length - 2; i >= 0; i--)
                {
                    format = rut.Substring(i, 1) + format;
                    cont++;
                    if (cont == 3 && i != 0)
                    {
                        format = "" + format;
                        cont = 0;
                    }
                }
                return format;
            }
        }

        public string CalculoDigitoVerificador(string rut)
        {
            int Digito;
            int Contador;
            int Multiplo;
            int Acumulador;

            Contador = 2;
            Acumulador = 0;
            long rutConvertido = Convert.ToInt64(rut);
            while (Convert.ToInt64(rutConvertido) != 0)
            {
                Multiplo = Convert.ToInt32((rutConvertido % 10) * Contador);
                Acumulador = Acumulador + Multiplo;
                rutConvertido = (rutConvertido / 10);
                Contador = Contador + 1;
                if (Contador == 8)
                {
                    Contador = 2;
                }
            }
            Digito = 11 - (Acumulador % 11);
            if (Digito == 10)
            {
                rut = string.Concat(rut, "k");
            }
            else if (Digito == 11)
            {
                rut = string.Concat(rut, "0");
            }
            else
            {
                rut = string.Concat(rut, Digito);
            }

            return rut;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rut"></param>
        /// <returns></returns>
        public bool ValidarRut(string rut)
        {
            bool validacion = false;
            string resultado;
            int Multiplicador;
            int iNum;
            int Suma;
            int I;
            string[] Final;
            string[] cad = new string [15];
            resultado = "0";
            Multiplicador = 2;
            iNum = 0;
            Suma = 0;
            for (I = (rut.Length - 2); (I <= 1); I = (I + -1))
            {
                iNum = int.Parse(rut.Substring((I - 1), 1));
                Suma = (Suma
                            + (iNum * Multiplicador));
                Multiplicador = (Multiplicador + 1);
                if ((Multiplicador == 8))
                {
                    Multiplicador = 2;
                }

            }

            resultado = ((11
                        - (Suma % 11))).ToString();
            if ((resultado == "10"))
            {
                resultado = "K";
            }

            if ((resultado == "11"))
            {
                resultado = "0";
            }

            Final = rut.Split('-');
            if ((Final[1] == resultado.Substring((resultado.Length - 1))))
            {
                validacion =  true;
            }

            return validacion;
        }

        /// <summary>
        /// Chequea si string contiene solo numeros
        /// </summary>
        /// <param name="str"></param>
        /// <returns>true : contiene solo numeros ; false : contiene letras</returns>
        public bool ContieneSoloNumeros(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}