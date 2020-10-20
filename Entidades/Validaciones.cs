using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validaciones
    {
        

        /// <summary>
        ///  Verifica que solo sean letras o espacios
        /// </summary>
        /// <param name="auxString">  </param>
        /// <returns> TRUE si solo hay letras y espacios, FALSE si hay caracteres fuera de rangos </returns>
        public static bool only_Chars_and_Space(string auxString)
        {
            bool okey = true;

            foreach (char item in auxString)
            {
                if( !( 'A' <= item && item <= 'z' ) || (( 'Z' < item && item < 'a' )  &&  item != ' ') )
                {
                    okey = false;
                    break;
                }
            }
            return okey;
        }




        /// <summary>
        /// Verifica que solo sea un numero entero o flotante.
        /// </summary>
        /// <param name="auxInt"></param>
        /// <returns> retorta TRUE si solo se encontraron numeros , sino retorna FALSE </returns>
        public static bool only_numer(string auxInt)
        {
            bool okey = true;
            bool flag = true;
            int contador = 0;

            foreach (char item in auxInt)
            {
                if (item == '.'  )// Verifico que solo exista un punto
                {
                    contador++;

                    if (contador !=0)
                    {
                        okey = false;
                        break;
                    }
                }
                else if ( flag && (item == '+' || item == '-') )//Verifico que solo existan '+' y '-' al pricipio
                {
                    flag = false;
                }
                else if ( ('0' > item && item > '9') )//Verifico que de no estar en este rango no son numeros
                {
                    okey = false;
                    break;
                }
                flag = false;
            }
            return okey;
        }


        /// <summary>
        /// Formato de dia y hora para titulo de Archivo.
        /// </summary>
        /// <returns></returns>
        public static string Dia_Hora_FormatoFile()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(DateTime.Now.Day + "-");
            sb.Append(DateTime.Now.Month + "-");
            sb.Append(DateTime.Now.Year + "  ");
            sb.Append(DateTime.Now.Hour + "-");
            sb.Append(DateTime.Now.Minute + "-");
            sb.Append(DateTime.Now.Second );

            return sb.ToString();
        }


        /// <summary>
        /// Indica si el año es bisiesto.
        /// </summary>
        /// <param name="anio"></param>
        /// <returns></returns>
        public static bool esBisiesto(int anio)
        {
            bool ok = false;

            if (anio % 4 == 0 && anio % 100 != 0 || anio % 400 == 0)
            {
                ok = true;
            }

            return ok;
        }



        /// <summary>
        /// Valida fecha.
        /// </summary>
        /// <param name="dia"></param>
        /// <param name="mes"></param>
        /// <param name="anio"></param>
        /// <returns></returns>
        public static int utn_validarFecha(int dia, int mes, int anio)
        {
            int ok = -1;

            if (mes > 0 && mes < 13 && anio >= 1900)
            {
                switch (mes)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        if (dia > 0 && dia < 32)
                        {
                            ok = 0;
                        }
                        break;

                    case 2:
                        // Porcion de codigo que verifica que es o no bisiesto
                        if (esBisiesto(anio) && dia > 0 && dia < 30)
                        {
                            ok = 0;
                        }
                        else if (dia > 0 && dia < 29)
                        {
                            ok = 0;
                        }
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        if (dia > 0 && dia < 31)
                        {
                            ok = 0;
                        }
                        break;
                }
            }

            return ok;
        }


    }
}
