using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Validaciones
    {
        /// <summary>
        /// Metodo que valida que un string sea un DNI valido
        /// </summary>
        /// <param name="numeroString">String a ser transfotmado a int y devuelto en el param DNI</param>
        /// <param name="dni">paramtro de tipo out int</param>
        /// <returns>true si lo logro transformar a dni, false si no, Si lo logro devuelve un int dni</returns>
        public static bool ValidarQueSeaDni(string numeroString, out int dni)
        {
            bool retorno = false;
            
            bool flag = int.TryParse(numeroString, out int num);
            if (flag == true)
            {
                if (numeroString.Length == 7 || numeroString.Length == 8)
                {
                    retorno = true;
                    dni = num;
                }
                else
                {
                    dni = 0;
                    retorno = false;
                }
            }
            else
            {
                dni = 0;
                retorno = false;
            }

            return retorno;
        }



        /// <summary>
        /// Metodo que valida que un string sea un DNI valido
        /// </summary>
        /// <param name="numeroString">String a ser transfotmado a int y devuelto en el param DNI</param>
        /// <param name="dni">paramtro de tipo out int</param>
        /// /// <param name="tipodeError">paramtro de tipo out int</param>
               // 1 - Errror contiene letras
               // 2- Dni corto
               // 3 - correcto
        /// <returns>true si lo logro transformar a dni, false si no, Si lo logro devuelve un int dni</returns>
        public static bool ValidarQueSeaDni(string numeroString, out int dni, out int tipodeError)
        {
            bool retorno = false;

            bool flag = int.TryParse(numeroString, out int num);
            if (flag == true)
            {
                if (numeroString.Length == 7 || numeroString.Length == 8)
                {
                    retorno = true;
                    dni = num;
                    tipodeError = 3;
                }
                else 
                {
                    dni = 0;
                    retorno = false;
                    tipodeError = 2;
                }
            }
            else
            {
                dni = 0;
                retorno = false;
                tipodeError = 1;
            }

            return retorno;
        }
    }




}
