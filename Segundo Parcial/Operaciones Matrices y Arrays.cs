using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_Parcial
{
    class Operaciones_Matrices_y_Arrays
    {

        #region Multiplicador Arrays
        /// <summary>
        /// Multiplica entre dos arrays
        /// </summary>
        /// <param name="array1">arrayparametro1</param>
        /// <param name="array2">arrayparametro2</param>
        /// <param name="arrayResultante">Array donde se almacena la multiplicación entre los otros 2</param>
        /// 

        public static void MultiplicadorArrays(int[] array1, int[] array2, int[] arrayResultante)
        {
            if (array1.Length != array2.Length && arrayResultante.Length != array1.Length)
            {

                Console.WriteLine("Arrays de distinto tamaño, no se puede hacer la operación.");

            }

            else
            {

                for (int i = 0; i < arrayResultante.Length; i++)
                {

                    if (array1[i] == -1 || array2[i] == -1)
                    {

                        arrayResultante[i] = array1[i];

                    }
                    else
                    {

                        arrayResultante[i] = array1[i] * array2[i];

                    }
                }
            }
        }
        #endregion


        #region Calculadora ganancias
        /// <summary>
        /// Calcula las ganancias
        /// </summary>
        /// <param name="arrayCostos"></param>
        /// <param name="arrayCantVendida"></param>
        /// <param name="arrayFacturacion"></param>
        /// <param name="arrayResultadoGanancias"></param>
        /// 

        public static void CalculadorGanancias(int[] arrayCostos, int[] arrayCantVendida, int[] arrayFacturacion, int[] arrayResultadoGanancias)
        {
            if (arrayCostos.Length != arrayFacturacion.Length && arrayResultadoGanancias.Length != arrayCostos.Length && arrayCostos.Length != arrayCantVendida.Length)
            {

                Console.WriteLine("Arrays de distinto tamaño, no se puede hacer la operación.");

            }
            else
            {

                for (int i = 0; i < arrayResultadoGanancias.Length; i++)
                {

                    if (arrayCostos[i] == -1 || arrayFacturacion[i] == -1 || arrayCantVendida[i] == -1)
                    {

                        arrayResultadoGanancias[i] = arrayCostos[i];

                    }
                    else
                    {

                        arrayResultadoGanancias[i] = arrayFacturacion[i] - (arrayCostos[i] * arrayCantVendida[i]);

                    }
                }
            }
        }
        #endregion


        #region Cargar matriz tipo String de 3 columnas
        /// <summary>
        /// Carga una matriz String de 3 columnas
        /// </summary>
        /// <param name="matrizACargar"></param>
        /// <param name="arrayDeCargaIntAString"></param>
        /// <param name="arrayDeCarga1"></param>
        /// <param name="arrayDeCarga2"></param>
        /// 

        public static void CargarMatrizString3Columnas(string[,] matrizACargar, int[] arrayDeCargaIntAString, string[] arrayDeCarga1, string[] arrayDeCarga2)
        {
            for (int i = 0; i < matrizACargar.GetLength(0); i++)
            {

                for (int j = 0; j < matrizACargar.GetLength(1); j++)
                {

                    if (j == 0)
                    {

                        matrizACargar[i, j] = Convert.ToString(arrayDeCargaIntAString[i]);

                    }
                    else if (j == 1)
                    {

                        matrizACargar[i, j] = arrayDeCarga1[i];

                    }
                    else
                    {

                        matrizACargar[i, j] = arrayDeCarga2[i];

                    }
                }
            }
        }
        #endregion


        #region Cargar matriz tipo Int de 2 columnas
        /// <summary>
        /// Carga una matriz Int de 2 columnas
        /// </summary>
        /// <param name="matrizACargar"></param>
        /// <param name="arrayDeCarga1"></param>
        /// <param name="arrayDeCarga2"></param>
        /// 

        public static void CargarMatrizInt2Columnas(int[,] matrizACargar, int[] arrayDeCarga1, int[] arrayDeCarga2)
        {
            for (int i = 0; i < matrizACargar.GetLength(0); i++)
            {

                for (int j = 0; j < matrizACargar.GetLength(1); j++)
                {

                    if (j == 0)
                    {

                        matrizACargar[i, j] = arrayDeCarga1[i];

                    }
                    else if (j == 1)
                    {

                        matrizACargar[i, j] = arrayDeCarga2[i];

                    }
                }
            }
        }
        #endregion


        #region Cargar matriz tipo Int de 4 columnas
        /// <summary>
        /// Cargar matriz Int de 4 columnas
        /// </summary>
        /// <param name="matrizACargar"></param>
        /// <param name="arrayDeCarga1"></param>
        /// <param name="arrayDeCarga2"></param>
        /// <param name="arrayDeCarga3"></param>
        /// <param name="arrayDeCarga4"></param>
        public static void CargarMatrizInt4Columnas(int[,] matrizACargar, int[] arrayDeCarga1, int[] arrayDeCarga2, int[] arrayDeCarga3, int[] arrayDeCarga4)
        {
            for (int i = 0; i < matrizACargar.GetLength(0); i++)
            {

                for (int j = 0; j < matrizACargar.GetLength(1); j++)
                {

                    if (j == 0)
                    {

                        matrizACargar[i, j] = arrayDeCarga1[i];

                    }
                    else if (j == 1)
                    {

                        matrizACargar[i, j] = arrayDeCarga2[i];

                    }
                    else if (j == 2)
                    {

                        matrizACargar[i, j] = arrayDeCarga3[i];

                    }
                    else if (j == 3)
                    {

                        matrizACargar[i, j] = arrayDeCarga4[i];

                    }
                }
            }
        }
        #endregion


        #region Agregar fila a matriz String
        /// <summary>
        /// Agregar fila a matriz string
        /// </summary>
        /// <param name="categorias"></param>
        /// <param name="matrizString"></param>
        /// <param name="columnasMatriz"></param>
        /// <param name="indicadorEspDisp">Indicación que el espacio esta disponible para agregar una fila</param>
        /// 

        public static void AgregarFila_MatrizString(string[] categorias, string[,] matrizString, string[] columnasMatriz, string indicadorEspDisp)
        {
            int indiceEspacio = 0;
            int indiceCategoria;

            for (int i = 0; i < matrizString.GetLength(0); i++)
            {
                //Se fija si la el elemento de la fila coincide con el indicador de espacio valido para agregar una fila y guarda el indice 
                if (matrizString[i, 1].Trim().ToLower() == indicadorEspDisp.Trim().ToLower())
                {
                    indiceEspacio = i;

                    break;
                }
            }

            //Usa el indice encontrado para cargar la fila
            for (int i = 0; i < matrizString.GetLength(1); i++)
            {
                if (i == 0)
                {
                    Console.Clear();

                    matrizString[indiceEspacio, i] = Convert.ToString(Validaciones.ValidacionInt($"Agregar {columnasMatriz[i]}: ", 1, 350));
                }
                else if (i == 1)
                {
                    Console.Clear();
                    Console.Write($"Agregar {columnasMatriz[i]}: ");

                    matrizString[indiceEspacio, i] = Validaciones.ValidacionStringConNumeros("");
                }
                else if (i == 2)
                {
                    Console.Clear();

                    Console.WriteLine("Categorías: \n");

                    for (int j = 0; j < matrizString.GetLength(1); j++)
                    {

                        Console.WriteLine($"{j + 1}. {categorias[j]}");

                    }

                    indiceCategoria = Validaciones.ValidacionInt("\nOpción Categoría: ", 1, matrizString.GetLength(1));

                    matrizString[indiceEspacio, 2] = categorias[indiceCategoria - 1];
                }
            }
        }
        #endregion


        #region Agregar fila a matriz Int
        /// <summary>
        /// Agregar fila a matriz Int
        /// </summary>
        /// <param name="matrizInt"></param>
        /// <param name="columnasMatriz"></param>
        /// <param name="indicadorEspDisp">Indicación que el espacio esta disponible para agregar una fila</param>
        /// 

        public static void AgregarFila_MatrizInt(int[,] matrizInt, string[] columnasMatriz, int indicadorEspDisp)
        {
            int indiceEspacio = 0;

            if (columnasMatriz.Length == 4)
            {
                for (int i = 0; i < matrizInt.GetLength(0); i++)
                {
                    //Se fija si la el elemento de la fila coincide con el indicador de espacio valido para agregar una fila y guarda el indice 
                    if (matrizInt[i, 0] == indicadorEspDisp)
                    {
                        indiceEspacio = i;

                        break;
                    }
                }

                //Usa el indice encontrado para cargar la fila
                for (int i = 0; i < matrizInt.GetLength(1) - 2; i++)
                {
                    Console.Clear();

                    matrizInt[indiceEspacio, i] = Validaciones.ValidacionInt($"Agregar {columnasMatriz[i]}: ", 0, 1000);

                    matrizInt[indiceEspacio, 2] = matrizInt[indiceEspacio, 0] * matrizInt[indiceEspacio, 1];
                }
            }
            else
            {
                for (int i = 0; i < matrizInt.GetLength(0); i++)
                {

                    if (matrizInt[i, 0] == indicadorEspDisp)
                    {
                        indiceEspacio = i;

                        break;
                    }
                }
                for (int i = 0; i < matrizInt.GetLength(1); i++)
                {
                    Console.Clear();

                    matrizInt[indiceEspacio, i] = Validaciones.ValidacionInt($"Agregar {columnasMatriz[i]}: ", 0, 1000);
                }
            }
        }
        #endregion


        #region Borrar fila de matriz String
        /// <summary>
        /// Borra una fila de matriz String
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="indicefila">Fila que borrar</param>
        /// 

        public static void BorrarFilaMatrizString(string[,] matriz, int indicefila)
        {
            // Reemplaza los valores previos 
            for (int i = 0; i < matriz.GetLength(1); i++)
            {

                if (i == 0)
                {

                    matriz[indicefila, i] = "-1";

                }
                else
                {

                    matriz[indicefila, i] = "Espacio Disp.";

                }
            }
        }
        #endregion


        #region Borrar fila de matriz Int
        /// <summary>
        /// Borra fila de matriz Int
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="indicefila">Fila que borrar</param>
        /// 

        public static void BorrarFilaMatrizInt(int[,] matriz, int indicefila)
        {
            // Reemplaza los valores previos
            for (int i = 0; i < matriz.GetLength(1); i++)
            {

                matriz[indicefila, i] = -1;

            }
        }
        #endregion


        #region Valor máximo de la columna de una matriz
        /// <summary>
        /// Saca el valor máximo que hay en la columna de una matriz
        /// </summary>
        /// <param name="matrizInt"></param>
        /// <param name="indiceColumna">Indice de columna al cuál sacar el máximo valor</param>
        /// <returns>Valor maximo de la columna de una matriz</returns>
        /// 

        public static int ValorMax_ColumnaMatriz(int[,] matrizInt, int indiceColumna)
        {
            int maxvalor = -1;

            for (int i = 0; i < matrizInt.GetLength(0); i++)
            {

                if (matrizInt[i, indiceColumna] > maxvalor)
                {

                    maxvalor = matrizInt[i, indiceColumna];

                }
            }

            return maxvalor;
        }

        #endregion


        #region Valor mínimo de la columna de una matriz
        /// <summary>
        /// Saca el valor mínimo que hay en la columna de una matriz
        /// </summary>
        /// <param name="matrizInt"></param>
        /// <param name="indiceColumna">Indice de columna al cuál sacar el mínimo valor</param>
        /// <returns>Valor mínimo de la columna de una matriz</returns>
        /// 

        public static int ValorMin_ColumnaMatriz(int[,] matrizInt, int indiceColumna)
        {
            int minvalor = 99999;

            for (int i = 0; i < matrizInt.GetLength(0); i++)
            {
                if (matrizInt[i, indiceColumna] < minvalor && matrizInt[i, indiceColumna] != -1)
                {
                    minvalor = matrizInt[i, indiceColumna];
                }
            }
            return minvalor;
        }

        #endregion


        #region Sumatoria de la columna de una matriz
        /// <summary>
        /// Saca la sumatoria de una columna de la matriz
        /// </summary>
        /// <param name="matrizInt"></param>
        /// <param name="indiceColumna">Indice de columna al cuál sacar la sumatoria</param>
        /// <returns>Sumatoria de la columna de una matriz</returns>
        /// 

        public static int SumatoriaColumnaMatriz(int[,] matrizInt, int indiceColumna)
        {

            int sumatoria = 0;

            for (int i = 0; i < matrizInt.GetLength(0); i++)
            {
                if (matrizInt[i, 0] != -1)
                {
                    sumatoria += matrizInt[i, indiceColumna];
                }
                else
                {
                    continue;
                }
            }

            return sumatoria;
        }

        #endregion

    }
}
