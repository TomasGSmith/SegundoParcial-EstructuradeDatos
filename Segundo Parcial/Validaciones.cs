using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_Parcial
{
    class Validaciones
    {

        #region Validación Entero
        /// <summary>
        /// Valida que el numero ingresado sea un entero
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="numMin">Número mínimo aceptado</param>
        /// <param name="numMax">Número máximo aceptado</param>
        /// <returns>Un entero validado</returns>
        /// 

        public static int ValidacionInt(string mensaje, int numMin, int numMax)
        {
            int ingresoInt;

            Console.Write(mensaje);

            while (int.TryParse(Console.ReadLine(), out ingresoInt) == false || ingresoInt < numMin || ingresoInt > numMax)
            {
                Console.Clear();

                Console.WriteLine("Valor incorrecto, vuelva a ingresar.");

                Console.ReadKey();

                Console.Clear();

                Console.Write(mensaje);
            }

            return ingresoInt;
        }
        #endregion


        #region Validación String
        /// <summary>
        /// Valida que lo ingresado no tenga números ni sea un espacio vacio
        /// </summary>
        /// <param name="mensaje"></param>
        /// <returns>Un String validado</returns>
        /// 

        public static string ValidacionString(string mensaje)
        {
            string ingresoString = "";
            bool validado = false;

            while (!validado)
            {
                Console.Write(mensaje);

                ingresoString = Console.ReadLine();

                while (ingresoString.ToLower().Contains("0") || ingresoString.ToLower().Contains("1") || ingresoString.ToLower().Contains("2") ||
                      ingresoString.ToLower().Contains("3") || ingresoString.ToLower().Contains("4") || ingresoString.ToLower().Contains("5") ||
                      ingresoString.ToLower().Contains("6") || ingresoString.ToLower().Contains("7") || ingresoString.ToLower().Contains("8") ||
                      ingresoString.ToLower().Contains("9") || ingresoString.ToLower() == "")
                {
                    Console.Clear();

                    Console.WriteLine("Valor incorrecto, vuelva a ingresar.");

                    Console.ReadKey();

                    Console.Clear();

                    Console.Write(mensaje);

                    ingresoString = Console.ReadLine();
                }

                validado = true;
            }

            return ingresoString;
        }
        #endregion


        #region Validación Si o No
        /// <summary>
        /// Valida que lo ingresado sea: si, s, no, n, 1 o 2
        /// </summary>
        /// <param name="mensaje"></param>
        /// <returns>Un valor valido considerable como Si o No</returns>
        /// 

        public static string Si_O_No(string mensaje)
        {
            string ingresoEleccion = "";
            bool validado = false;

            while (!validado)
            {
                Console.Write(mensaje);

                ingresoEleccion = Console.ReadLine();

                while (string.IsNullOrEmpty(ingresoEleccion) && ingresoEleccion != "1" && ingresoEleccion != "2" && ingresoEleccion.ToLower() != "si" &&
                       ingresoEleccion.ToLower() != "no" && ingresoEleccion.ToLower() != "n" && ingresoEleccion.ToLower() != "s")
                {
                    Console.Clear();

                    Console.WriteLine("Valor incorrecto, vuelva a ingresar. ");

                    Console.ReadKey();

                    Console.Clear();

                    Console.Write(mensaje);

                    ingresoEleccion = Console.ReadLine();
                }

                validado = true;
            }

            return ingresoEleccion;
        }
        #endregion


        #region Validación String con números

        /// <summary>
        /// Valida que lo ingresado no sea un string vacio
        /// </summary>
        /// <param name="mensaje"></param>
        /// <returns>Un String validado</returns>
        /// 

        public static string ValidacionStringConNumeros(string mensaje)
        {
            string ingresoString = "";
            bool validado = false;

            while (!validado)
            {
                Console.Write(mensaje);

                ingresoString = Console.ReadLine();

                while (ingresoString.ToLower() == "")
                {
                    Console.Clear();

                    Console.WriteLine("Valor incorrecto, vuelva a ingresar.");

                    Console.ReadKey();

                    Console.Clear();

                    Console.Write(mensaje);

                    ingresoString = Console.ReadLine();
                }

                validado = true;
            }

            return ingresoString;
        }
        #endregion

    }
}
