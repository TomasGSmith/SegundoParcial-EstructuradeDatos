using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_Parcial
{
    class TituloRgb
    {

        /// <summary>
        /// Convierte el string que se le ingrese, de hasta 50 caracteres, a colores RGB.
        /// </summary>
        /// <param name="mensaje">String a convertir</param>
        /// 

        public static void Bienvenido(string mensaje)
        {
            int cantCaracteres = mensaje.Length;

            if (cantCaracteres > 50)
            {
                Console.WriteLine(mensaje);
            }
            else
            {
                for (int i = 0; i < mensaje.Length; i++)
                {
                    if (i == 0 || i == 7 || i == 14 || i == 21 || i == 28 || i == 35 || i == 42 || i == 49)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(mensaje[i]);
                    }
                    else if (i == 1 || i == 8 || i == 15 || i == 22 || i == 29 || i == 36 || i == 43)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(mensaje[i]);
                    }
                    else if (i == 2 || i == 9 || i == 16 || i == 23 || i == 30 || i == 37 || i == 44)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(mensaje[i]);
                    }
                    else if (i == 3 || i == 10 || i == 17 || i == 24 || i == 31 || i == 38 || i == 45)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(mensaje[i]);
                    }
                    else if (i == 4 || i == 11 || i == 18 || i == 25 || i == 32 || i == 39 || i == 46)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(mensaje[i]);
                    }
                    else if (i == 5 || i == 12 || i == 19 || i == 26 || i == 33 || i == 40 || i == 47)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(mensaje[i]);
                    }
                    else if (i == 6 || i == 13 || i == 20 || i == 27 || i == 34 || i == 41 || i == 48)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write(mensaje[i]);
                    }
                    else
                    {
                        Console.Write($"{mensaje[i]}");
                    }
                }
                Console.ResetColor();
            }

        }

    }
}
