using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class Validador
    {
        public static bool ContinuarCargaDeDatos(string mensaje, bool flag)
        {
            string respuesta;
            while (flag)
            {
                Console.Write(mensaje);
                respuesta = Console.ReadLine();
                if (respuesta.ToLower() == "n")
                {
                    flag = false;
                    break;
                }
                else if (respuesta.ToLower() == "s")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opción inválida. Igresá \"s\" o \"n\": ");
                }

            }
            return flag;
        }
    }
}
