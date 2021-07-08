using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_Parcial
{
    class Menus
    {
        // Menú principal
        public static void MenuPrincipal(string[] categorias, string[] columnasMatriz1, string[,] matriz1,
                                         string[] columnasMatriz2, int[,] matriz2, string[] columnasMatriz3, int[,] matriz3)
        {

            int opcionMenu;
            string validado;
            bool salir = false;

            Console.Clear();

            while (!salir)
            {
                Console.Clear();

                Console.Write("  ");

                TituloRgb.Bienvenido("ISTEGAMING!!!");

                opcionMenu = Validaciones.ValidacionInt($"\n\n{"Menú Principal",20}\n{"--------------",20}" +
                                                        $"\n\n1. Mostrar productos" +
                                                        $"\n2. Buscar productos" +
                                                        $"\n3. Agregar productos" +
                                                        $"\n4. Modificar productos" +
                                                        $"\n5. Borrar producto del sistema" +
                                                        $"\n6. Facturación y datos de ventas" +
                                                        $"\n7. Salir" +
                                                        $"\n\nOpción: "
                                                        , 1, 7);

                if (opcionMenu == 1)
                {

                    SubMenu_MostrarProductos(categorias, columnasMatriz1, matriz1, columnasMatriz2, matriz2, columnasMatriz3, matriz3);

                }
                else if (opcionMenu == 2)
                {

                    SubMenu_BuscarProductos(columnasMatriz1, matriz1, columnasMatriz2, matriz2, columnasMatriz3, matriz3);

                }
                else if (opcionMenu == 3)
                {

                    AgregarProductos(categorias, columnasMatriz1, matriz1, columnasMatriz2, matriz2, columnasMatriz3, matriz3);

                }
                else if (opcionMenu == 4)
                {

                    SubMenu_ModificarProductos(categorias, columnasMatriz1, matriz1, columnasMatriz2, matriz2, columnasMatriz3, matriz3);

                }
                else if (opcionMenu == 5)
                {

                    BorrarProducto(columnasMatriz1, matriz1, columnasMatriz2, matriz2, columnasMatriz3, matriz3);

                }
                else if (opcionMenu == 6)
                {

                    SubMenu_Facturacion_Y_DatosVentas(columnasMatriz1, matriz1, columnasMatriz2, matriz2, columnasMatriz3, matriz3);

                }
                else
                {

                    Console.Clear();

                    validado = Validaciones.Si_O_No("¿Seguro desea salir del programa?" +
                                                    "\n\n1.Si" +
                                                    "\n2.No" +
                                                    "\n\nOpción: ");

                    if (validado.ToLower() == "s" || validado.ToLower() == "si" || validado == "1")
                    {

                        salir = true;

                    }
                    else
                    {

                        continue;

                    }
                }
            }

        }


        #region 1. Mostrar Productos
        /// <summary>
        /// Menu: Mostrar productos
        /// </summary>
        /// <param name="categorias"></param>
        /// <param name="columnasMatriz1"></param>
        /// <param name="matriz1"></param>
        /// <param name="columnasMatriz2"></param>
        /// <param name="matriz2"></param>
        /// <param name="columnasMatriz3"></param>
        /// <param name="matriz3"></param>
        /// 

        public static void SubMenu_MostrarProductos(string[] categorias, string[] columnasMatriz1, string[,] matriz1,
                                                   string[] columnasMatriz2, int[,] matriz2, string[] columnasMatriz3, int[,] matriz3)
        {

            int opcionMenu;

            bool salir = false;

            Console.Clear();

            while (!salir)
            {
                opcionMenu = Validaciones.ValidacionInt($"{"Mostrar Productos",20}\n{"-----------------",20}" +
                                                        $"\n\n1. Mostrar todos" +
                                                        $"\n2. Mostrar según categoría " +
                                                        $"\n3. Mostrar según stock" +
                                                        $"\n4. Volver al menú principal" +
                                                        $"\n\nOpción: "
                                                        , 1, 4);

                if (opcionMenu == 1)
                {

                    MostrarTodosLosProductos(columnasMatriz1, matriz1, columnasMatriz2, matriz2, columnasMatriz3, matriz3);

                    break;

                }
                else if (opcionMenu == 2)
                {

                    MostrarSegunCategoria(categorias, columnasMatriz1, matriz1, columnasMatriz2, matriz2, columnasMatriz3, matriz3);

                    break;

                }
                else if (opcionMenu == 3)
                {

                    MostrarSegunStock(columnasMatriz1, matriz1, columnasMatriz2, matriz2, columnasMatriz3, matriz3);

                    break;

                }
                else
                {

                    break;

                }
            }
        }

        #region 1.1 Mostrar todos los productos 
        /// <summary>
        /// Muestra todos los productos ingresados al sistema, salteandose los espacios vacios.
        /// </summary>
        /// <param name="columnasMatriz1"></param>
        /// <param name="matriz1"></param>
        /// <param name="columnasMatriz2"></param>
        /// <param name="matriz2"></param>
        /// <param name="columnasMatriz3"></param>
        /// <param name="matriz3"></param>
        /// 

        public static void MostrarTodosLosProductos(string[] columnasMatriz1, string[,] matriz1, string[] columnasMatriz2,
                                                    int[,] matriz2, string[] columnasMatriz3, int[,] matriz3)
        {

            Console.Clear();

            Console.WriteLine($"{"1.1 Mostrar todos los productos",35}\n{"-------------------------------",35}");

            Console.WriteLine("\n\n-----------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"||{"Productos",76}{"||",77}");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");

            #region Muestra los titulos de las columnas
            Console.Write("||");

            for (int i = 0; i < columnasMatriz1.Length; i++)
            {

                Console.Write($"{columnasMatriz1[i],-15}||");

            }
            for (int i = 0; i < columnasMatriz2.Length; i++)
            {

                Console.Write($"{columnasMatriz2[i],-15}||");

            }
            for (int i = 0; i < columnasMatriz3.Length; i++)
            {

                Console.Write($"{columnasMatriz3[i],-15}||");

            }
            #endregion

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");

            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                // En cada fila de la matriz busca la coincidencia del espacio vacio para decidir si pasa a la siguiente iteración o imprime el producto.
                if (matriz1[i, 0] == "-1")
                {

                    continue;

                }
                Console.Write("||");

                for (int j = 0; j < matriz1.GetLength(1); j++)
                {

                    Console.Write($"{matriz1[i, j],-15}||");

                }
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {

                    Console.Write($"{matriz2[i, j],-15}||");

                }
                for (int j = 0; j < matriz3.GetLength(1); j++)
                {

                    Console.Write($"{matriz3[i, j],-15}||");

                }

                Console.WriteLine("");
            }

            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");

            Console.ReadKey();

            Console.Clear();
        }
        #endregion

        #region 1.2 Mostrar según categoría
        /// <summary>
        /// Muestra los productos que hay en el programa según la categoría elegida, usa la opción elegida y verifica en que 
        /// productos coinciden con la misma para mostrarlos.   
        /// </summary>
        /// <param name="categorias"></param>
        /// <param name="columnasMatriz1"></param>
        /// <param name="matriz1"></param>
        /// <param name="columnasMatriz2"></param>
        /// <param name="matriz2"></param>
        /// <param name="columnasMatriz3"></param>
        /// <param name="matriz3"></param>
        /// 

        public static void MostrarSegunCategoria(string[] categorias, string[] columnasMatriz1, string[,] matriz1,
                                                 string[] columnasMatriz2, int[,] matriz2, string[] columnasMatriz3, int[,] matriz3)
        {

            int opcion;

            Console.Clear();

            Console.WriteLine($"{"1.2 Mostrar según categoría",30}\n{"---------------------------",30}");

            Console.WriteLine("");

            //Muestra las categorías que hay para elegir.
            for (int i = 0; i < categorias.Length; i++)
            {

                Console.WriteLine($"{i + 1}. {categorias[i]}");

            }

            opcion = Validaciones.ValidacionInt("\nOpción: ", 1, 3);

            Console.Clear();

            Console.WriteLine($"{"1.2 Mostrar según categoría",30}\n{"---------------------------",30}");

            Console.WriteLine("\n\n-----------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"{"||",-56}{"Productos:",10} {categorias[opcion - 1],-15}{"||",73}");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");

            #region Muestra los titulos de las columnas
            Console.Write("||");
            for (int i = 0; i < columnasMatriz1.Length; i++)
            {
                Console.Write($"{columnasMatriz1[i],-15}||");
            }
            for (int i = 0; i < columnasMatriz2.Length; i++)
            {
                Console.Write($"{columnasMatriz2[i],-15}||");
            }
            for (int i = 0; i < columnasMatriz3.Length; i++)
            {
                Console.Write($"{columnasMatriz3[i],-15}||");
            }
            #endregion

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");

            for (int i = 0; i < matriz1.GetLength(0); i++)
            {

                // En cada fila de la matriz busca la coincidencia del espacio vacio  o que no coincida con la opción de categoria elegida
                // para decidir si pasa a la siguiente iteración o imprime el producto.
                if (matriz1[i, 0] == "-1" || matriz1[i, 2] != categorias[opcion - 1])
                {

                    continue;

                }

                Console.Write("||");
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {

                    Console.Write($"{matriz1[i, j],-15}||");

                }
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {

                    Console.Write($"{matriz2[i, j],-15}||");

                }
                for (int j = 0; j < matriz3.GetLength(1); j++)
                {

                    Console.Write($"{matriz3[i, j],-15}||");

                }

                Console.WriteLine("");

            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");

            Console.ReadKey();

            Console.Clear();
        }
        #endregion

        #region 1.3 Mostrar según stock
        /// <summary>
        /// Muestra los productos según la cantidad de stock elegida, usa la opción elegida y verifica que productos 
        /// cumplen con la condición elegida para mostrarlos. 
        /// </summary>
        /// <param name="columnasMatriz1"></param>
        /// <param name="matriz1"></param>
        /// <param name="columnasMatriz2"></param>
        /// <param name="matriz2"></param>
        /// <param name="columnasMatriz3"></param>
        /// <param name="matriz3"></param>
        /// 

        public static void MostrarSegunStock(string[] columnasMatriz1, string[,] matriz1, string[] columnasMatriz2, int[,] matriz2,
                                             string[] columnasMatriz3, int[,] matriz3)
        {
            int opcion;

            // Muestra las opciones de stock para elegir
            Console.Clear();

            Console.WriteLine($"{"1.3 Mostrar según stock",26}\n{"-----------------------",26}");

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("\n1. Sin stock");

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("2. Stock < 50");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("3. Stock >=50");

            Console.ResetColor();

            opcion = Validaciones.ValidacionInt("\nOpción: ", 1, 3);

            #region Sin stock

            if (opcion == 1)
            {
                Console.Clear();

                Console.WriteLine($"{"1.3 Mostrar según stock",26}\n{"-----------------------",26}");
                Console.WriteLine("\n\n-----------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"{"||",-56}{"Productos:",10} {"Sin stock",-15}{"||",73}");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");

                #region Muestra los titulos de las columnas
                Console.Write("||");
                for (int i = 0; i < columnasMatriz1.Length; i++)
                {
                    Console.Write($"{columnasMatriz1[i],-15}||");
                }
                for (int i = 0; i < columnasMatriz2.Length; i++)
                {
                    Console.Write($"{columnasMatriz2[i],-15}||");
                }
                for (int i = 0; i < columnasMatriz3.Length; i++)
                {
                    Console.Write($"{columnasMatriz3[i],-15}||");
                }
                #endregion

                Console.WriteLine();

                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");

                for (int i = 0; i < matriz1.GetLength(0); i++)
                {
                    // Saltea las filas vacias 
                    if (matriz1[i, 0] == "-1")
                    {

                        continue;

                    }
                    // Verifica que se cumpla la condición de stock=0 para mostrar los productos
                    if (matriz2[i, 1] == 0)
                    {

                        Console.Write("||");
                        for (int j = 0; j < matriz1.GetLength(1); j++)
                        {

                            Console.Write($"{matriz1[i, j],-15}||");

                        }
                        for (int j = 0; j < matriz2.GetLength(1); j++)
                        {

                            Console.Write($"{matriz2[i, j],-15}||");

                        }
                        for (int j = 0; j < matriz3.GetLength(1); j++)
                        {

                            Console.Write($"{matriz3[i, j],-15}||");

                        }

                        Console.WriteLine("");
                    }
                }
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");

                Console.ReadKey();

                Console.Clear();
            }
            #endregion

            #region Stock < 50
            else if (opcion == 2)
            {
                Console.Clear();

                Console.WriteLine($"{"1.3 Mostrar según stock",26}\n{"-----------------------",26}");
                Console.WriteLine("\n\n-----------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"{"||",-56}{"Productos:",10} {"Stock < 50",-15}{"||",73}");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");

                #region Muestra los titulos de las columnas
                Console.Write("||");

                for (int i = 0; i < columnasMatriz1.Length; i++)
                {

                    Console.Write($"{columnasMatriz1[i],-15}||");

                }
                for (int i = 0; i < columnasMatriz2.Length; i++)
                {

                    Console.Write($"{columnasMatriz2[i],-15}||");

                }
                for (int i = 0; i < columnasMatriz3.Length; i++)
                {

                    Console.Write($"{columnasMatriz3[i],-15}||");

                }
                #endregion

                Console.WriteLine();

                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");

                for (int i = 0; i < matriz1.GetLength(0); i++)
                {
                    // Saltea las filas vacias
                    if (matriz1[i, 0] == "-1")
                    {

                        continue;

                    }
                    // Verifica que se cumpla la condición de stock < 50 y stock > 0 para mostrar los productos
                    if (matriz2[i, 1] < 50 && matriz2[i, 1] > 0)
                    {
                        Console.Write("||");

                        for (int j = 0; j < matriz1.GetLength(1); j++)
                        {

                            Console.Write($"{matriz1[i, j],-15}||");

                        }
                        for (int j = 0; j < matriz2.GetLength(1); j++)
                        {

                            Console.Write($"{matriz2[i, j],-15}||");

                        }
                        for (int j = 0; j < matriz3.GetLength(1); j++)
                        {

                            Console.Write($"{matriz3[i, j],-15}||");

                        }

                        Console.WriteLine("");
                    }
                }
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");

                Console.ReadKey();

                Console.Clear();
            }
            #endregion

            #region Stock >= 50
            else
            {
                Console.Clear();

                Console.WriteLine($"{"1.3 Mostrar según stock",26}\n{"-----------------------",26}");
                Console.WriteLine("\n\n-----------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"{"||",-56}{"Productos:",10} {"Stock >= 50",-15}{"||",73}");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");

                #region Muestra los titulos de las columnas
                Console.Write("||");

                for (int i = 0; i < columnasMatriz1.Length; i++)
                {

                    Console.Write($"{columnasMatriz1[i],-15}||");

                }
                for (int i = 0; i < columnasMatriz2.Length; i++)
                {

                    Console.Write($"{columnasMatriz2[i],-15}||");

                }
                for (int i = 0; i < columnasMatriz3.Length; i++)
                {

                    Console.Write($"{columnasMatriz3[i],-15}||");

                }
                #endregion

                Console.WriteLine();

                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");

                for (int i = 0; i < matriz1.GetLength(0); i++)
                {
                    // Saltea las filas vacias
                    if (matriz1[i, 0] == "-1")
                    {

                        continue;

                    }
                    // Verifica que se cumpla la condición de stock >= 50 para mostrar los productos
                    if (matriz2[i, 1] >= 50)
                    {
                        Console.Write("||");

                        for (int j = 0; j < matriz1.GetLength(1); j++)
                        {

                            Console.Write($"{matriz1[i, j],-15}||");

                        }
                        for (int j = 0; j < matriz2.GetLength(1); j++)
                        {

                            Console.Write($"{matriz2[i, j],-15}||");

                        }
                        for (int j = 0; j < matriz3.GetLength(1); j++)
                        {

                            Console.Write($"{matriz3[i, j],-15}||");

                        }
                        Console.WriteLine("");
                    }
                }
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");

                Console.ReadKey();

                Console.Clear();
            }
            #endregion
        }
        #endregion

        #endregion


        #region 2. Buscar Productos
        /// <summary>
        /// Menú: Buscar productos
        /// </summary>
        /// <param name="columnasMatriz1"></param>
        /// <param name="matriz1"></param>
        /// <param name="columnasMatriz2"></param>
        /// <param name="matriz2"></param>
        /// <param name="columnasMatriz3"></param>
        /// <param name="matriz3"></param>
        /// 

        public static void SubMenu_BuscarProductos(string[] columnasMatriz1, string[,] matriz1, string[] columnasMatriz2,
                                                    int[,] matriz2, string[] columnasMatriz3, int[,] matriz3)
        {
            int opcion;
            bool salir = false;

            Console.Clear();

            while (!salir)
            {
                opcion = Validaciones.ValidacionInt($"{"2. Buscar productos",25}\n{"-------------------",25}" +
                                                    $"\n\n1. Buscar por nombre del producto" +
                                                    $"\n2. Buscar por ID " +
                                                    $"\n3. Volver al menú principal" +
                                                    $"\n\nOpción: "
                                                    , 1, 3);

                if (opcion == 1)
                {
                    Console.Clear();

                    BuscarPorNombre(columnasMatriz1, matriz1, columnasMatriz2, matriz2, columnasMatriz3, matriz3);

                    Console.Clear();

                    continue;
                }
                else if (opcion == 2)
                {
                    Console.Clear();

                    BuscarPorId(columnasMatriz1, matriz1, columnasMatriz2, matriz2, columnasMatriz3, matriz3);

                    Console.Clear();

                    continue;
                }
                else
                {

                    break;

                }
            }
        }

        #region 2.1 Buscar por nombre del producto
        /// <summary>
        /// Busca los productos por su nombre y muestra los que coinciden con la busqueda.
        /// </summary>
        /// <param name="columnasMatriz1"></param>
        /// <param name="matriz1"></param>
        /// <param name="columnasMatriz2"></param>
        /// <param name="matriz2"></param>
        /// <param name="columnasMatriz3"></param>
        /// <param name="matriz3"></param>
        /// 

        public static void BuscarPorNombre(string[] columnasMatriz1, string[,] matriz1, string[] columnasMatriz2,
                                           int[,] matriz2, string[] columnasMatriz3, int[,] matriz3)
        {

            string producto_A_Buscar;
            int contProductosEncontrados = 0;


            Console.WriteLine($"{"Buscar productos",20}\n{"----------------",20}");

            producto_A_Buscar = Validaciones.ValidacionStringConNumeros("\n Ingrese el nombre del producto: ");

            for (int i = 0; i < matriz1.GetLength(0); i++)
            {

                // Se pregunta si lo ingresado como producto a buscar es igual a lo que tiene la matriz o si el producto contiene lo ingresado.
                // Si se cumple alguna de las dos condiciones, lo muestra y si no lo hace en ninguna fila dice que el producto no fue encontrado
                if (matriz1[i, 1].ToLower().Replace(" ", "") == producto_A_Buscar.ToLower().Replace(" ", "") || matriz1[i, 1].ToLower().Trim().Contains(producto_A_Buscar.ToLower().Trim()))
                {

                    // Verifica que es la primera coincidencia y arma el formato de muestra y suma uno al contador para que no vuelva a hacerlo. 
                    if (contProductosEncontrados == 0)
                    {
                        contProductosEncontrados++;

                        Console.Clear();

                        Console.WriteLine($"{"Buscar productos",20}\n{"----------------",20}");

                        Console.WriteLine("\n\n-----------------------------------------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine($"{"||",-56}{"Buscar productos:",10} {"Por nombre",-15}{"||",66}");
                        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");

                        #region Muestra los titulos de las columnas
                        Console.Write("||");

                        for (int j = 0; j < columnasMatriz1.Length; j++)
                        {

                            Console.Write($"{columnasMatriz1[j],-15}||");

                        }
                        for (int j = 0; j < columnasMatriz2.Length; j++)
                        {

                            Console.Write($"{columnasMatriz2[j],-15}||");

                        }
                        for (int j = 0; j < columnasMatriz3.Length; j++)
                        {

                            Console.Write($"{columnasMatriz3[j],-15}||");

                        }
                        #endregion

                        Console.WriteLine();

                        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");

                        if (matriz1[i, 0] == "-1")
                        {

                            continue;

                        }
                        else
                        {
                            Console.Write("||");

                            for (int k = 0; k < matriz1.GetLength(1); k++)
                            {

                                Console.Write($"{matriz1[i, k],-15}||");

                            }
                            for (int k = 0; k < matriz2.GetLength(1); k++)
                            {

                                Console.Write($"{matriz2[i, k],-15}||");

                            }
                            for (int k = 0; k < matriz3.GetLength(1); k++)
                            {

                                Console.Write($"{matriz3[i, k],-15}||");

                            }

                            Console.WriteLine("");
                        }
                    }
                    else
                    {

                        if (matriz1[i, 0] == "-1")
                        {

                            continue;

                        }
                        else
                        {
                            Console.Write("||");

                            for (int k = 0; k < matriz1.GetLength(1); k++)
                            {

                                Console.Write($"{matriz1[i, k],-15}||");

                            }
                            for (int k = 0; k < matriz2.GetLength(1); k++)
                            {

                                Console.Write($"{matriz2[i, k],-15}||");

                            }
                            for (int k = 0; k < matriz3.GetLength(1); k++)
                            {

                                Console.Write($"{matriz3[i, k],-15}||");

                            }

                            Console.WriteLine("");
                        }
                    }
                }
            }
            if (contProductosEncontrados == 0)
            {
                Console.Clear();

                Console.WriteLine($"{"Buscar productos",20}\n{"----------------",20}");

                Console.WriteLine($"\nNo se encontraron resultados para: '{producto_A_Buscar}'");

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");

                Console.ReadKey();

                Console.Clear();

            }
        }
        #endregion

        #region 2.2 Buscar por ID del producto
        /// <summary>
        /// Busca el producto ingresando ID y muestra el que coincide de manera exacta 
        /// </summary>
        /// <param name="columnasMatriz1"></param>
        /// <param name="matriz1"></param>
        /// <param name="columnasMatriz2"></param>
        /// <param name="matriz2"></param>
        /// <param name="columnasMatriz3"></param>
        /// <param name="matriz3"></param>
        /// 

        public static void BuscarPorId(string[] columnasMatriz1, string[,] matriz1, string[] columnasMatriz2,
                                       int[,] matriz2, string[] columnasMatriz3, int[,] matriz3)
        {
            int id_A_Buscar;
            int contProductosEncontrados = 0;


            Console.WriteLine($"{"Buscar productos",25}\n{"----------------",25}");

            id_A_Buscar = Validaciones.ValidacionInt("\n Ingrese el ID del producto: ", 1, 100);

            for (int i = 0; i < matriz1.GetLength(0); i++)
            {

                // Se pregunta en cada ciclo si el ID ingresado es igual a lo que tiene la matriz en esa fila.
                if (matriz1[i, 0] == Convert.ToString(id_A_Buscar))
                {
                    // idem busqueda por nombre
                    if (contProductosEncontrados == 0)
                    {
                        contProductosEncontrados++;

                        Console.Clear();

                        Console.WriteLine($"{"Buscar productos",25}\n{"----------------",25}");

                        Console.WriteLine("\n\n-----------------------------------------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine($"{"||",-56}{"Buscar productos:",10} {"Por ID",-15}{"||",66}");
                        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");

                        #region Muestra los titulos de las columnas
                        Console.Write("||");

                        for (int j = 0; j < columnasMatriz1.Length; j++)
                        {

                            Console.Write($"{columnasMatriz1[j],-15}||");

                        }
                        for (int j = 0; j < columnasMatriz2.Length; j++)
                        {

                            Console.Write($"{columnasMatriz2[j],-15}||");

                        }
                        for (int j = 0; j < columnasMatriz3.Length; j++)
                        {

                            Console.Write($"{columnasMatriz3[j],-15}||");

                        }
                        #endregion

                        Console.WriteLine();

                        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");

                        if (matriz1[i, 0] == "-1")
                        {

                            continue;

                        }
                        else
                        {
                            Console.Write("||");

                            for (int k = 0; k < matriz1.GetLength(1); k++)
                            {

                                Console.Write($"{matriz1[i, k],-15}||");

                            }
                            for (int k = 0; k < matriz2.GetLength(1); k++)
                            {

                                Console.Write($"{matriz2[i, k],-15}||");

                            }
                            for (int k = 0; k < matriz3.GetLength(1); k++)
                            {

                                Console.Write($"{matriz3[i, k],-15}||");

                            }
                            Console.WriteLine("");
                        }
                    }
                    else
                    {

                        if (matriz1[i, 0] == "-1")
                        {

                            continue;

                        }
                        else
                        {
                            Console.Write("||");

                            for (int k = 0; k < matriz1.GetLength(1); k++)
                            {

                                Console.Write($"{matriz1[i, k],-15}||");

                            }
                            for (int k = 0; k < matriz2.GetLength(1); k++)
                            {

                                Console.Write($"{matriz2[i, k],-15}||");

                            }
                            for (int k = 0; k < matriz3.GetLength(1); k++)
                            {

                                Console.Write($"{matriz3[i, k],-15}||");

                            }

                            Console.WriteLine("");
                        }
                    }
                }
            }
            if (contProductosEncontrados == 0)
            {
                Console.Clear();

                Console.WriteLine($"{"Buscar productos",25}\n{"----------------",25}");

                Console.WriteLine($"\nNo se encontraron resultados para el ID: '{id_A_Buscar}'");

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");

                Console.ReadKey();

                Console.Clear();
            }
        }

        #endregion

        #endregion


        #region 3. Agregar Productos
        /// <summary>
        /// Deja agregar productos en aquellos espacios que esten vacios y informa en el caso de que no queden más espacios
        /// </summary>
        /// <param name="categorias"></param>
        /// <param name="columnasMatriz1"></param>
        /// <param name="matriz1"></param>
        /// <param name="columnasMatriz2"></param>
        /// <param name="matriz2"></param>
        /// <param name="columnasMatriz3"></param>
        /// <param name="matriz3"></param>
        /// 

        public static void AgregarProductos(string[] categorias, string[] columnasMatriz1, string[,] matriz1, string[] columnasMatriz2,
                                                    int[,] matriz2, string[] columnasMatriz3, int[,] matriz3)
        {
            int indiceFila_A_Cargar;
            string validado;
            int contEspacios = 0;

            Console.Clear();

            Console.WriteLine($"{"Agregar Productos",25}\n{"------------------",25}");

            // Recorre las filas de la matriz y se fija cuantos espacios disponibles quedan
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                if (matriz1[i, 1] == "Espacio Disp.")
                {
                    contEspacios++;
                }
            }

            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                // Se fija si la fila esta vacia, si lo esta, se ingresa el producto en la misma.
                if (matriz1[i, 1] == "Espacio Disp.")
                {
                    indiceFila_A_Cargar = i;

                    Console.WriteLine($"\nQuedan {contEspacios} espacios.");

                    Console.ReadKey();

                    Operaciones_Matrices_y_Arrays.AgregarFila_MatrizString(categorias, matriz1, columnasMatriz1, "Espacio Disp.");

                    Operaciones_Matrices_y_Arrays.AgregarFila_MatrizInt(matriz2, columnasMatriz2, -1);

                    Operaciones_Matrices_y_Arrays.AgregarFila_MatrizInt(matriz3, columnasMatriz3, -1);

                    matriz3[indiceFila_A_Cargar, 3] = matriz3[indiceFila_A_Cargar, 2] - (matriz2[indiceFila_A_Cargar, 0] * matriz3[indiceFila_A_Cargar, 1]);

                    Console.Clear();

                    Console.WriteLine($"{"Agregar Productos",25}\n{"------------------",25}");

                    Console.WriteLine("\n\n-----------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine($"||{"Producto agregado",76}{"||",77}");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");

                    #region Muestra los titulos de las columnas
                    Console.Write("||");

                    for (int j = 0; j < columnasMatriz1.Length; j++)
                    {

                        Console.Write($"{columnasMatriz1[j],-15}||");

                    }
                    for (int j = 0; j < columnasMatriz2.Length; j++)
                    {

                        Console.Write($"{columnasMatriz2[j],-15}||");

                    }
                    for (int j = 0; j < columnasMatriz3.Length; j++)
                    {

                        Console.Write($"{columnasMatriz3[j],-15}||");

                    }
                    #endregion

                    Console.WriteLine();

                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");

                    Console.Write("||");

                    for (int j = 0; j < matriz1.GetLength(1); j++)
                    {

                        Console.Write($"{matriz1[indiceFila_A_Cargar, j],-15}||");

                    }
                    for (int j = 0; j < matriz2.GetLength(1); j++)
                    {

                        Console.Write($"{matriz2[indiceFila_A_Cargar, j],-15}||");

                    }
                    for (int j = 0; j < matriz3.GetLength(1); j++)
                    {

                        Console.Write($"{matriz3[indiceFila_A_Cargar, j],-15}||");

                    }

                    Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------------------------------------------");

                    validado = Validaciones.Si_O_No("\n¿Seguro quiere agregar este producto? " +
                                                "\n1. Si" +
                                                "\n2. No" +
                                                "\n\nOpción: ");

                    if (validado.ToLower() == "s" || validado.ToLower() == "si" || validado == "1")
                    {
                        for (int j = 0; j < 2; j++)
                        {

                            Console.Clear();
                            Console.WriteLine($"Agregando producto");
                            System.Threading.Thread.Sleep(250);
                            Console.Clear();
                            Console.WriteLine($"Agregando producto.");
                            System.Threading.Thread.Sleep(250);
                            Console.Clear();
                            Console.WriteLine($"Agregando producto..");
                            System.Threading.Thread.Sleep(250);
                            Console.Clear();
                            Console.WriteLine($"Agregando producto...");
                            System.Threading.Thread.Sleep(250);
                            Console.Clear();

                        }
                        Console.WriteLine($"El producto '{matriz1[indiceFila_A_Cargar, 1]}' fue agregado correctamente!");

                        Console.ReadKey();
                    }

                    // Deja todos los espacios de la fila en su estado original
                    else
                    {

                        Operaciones_Matrices_y_Arrays.BorrarFilaMatrizString(matriz1, indiceFila_A_Cargar);
                        Operaciones_Matrices_y_Arrays.BorrarFilaMatrizInt(matriz2, indiceFila_A_Cargar);
                        Operaciones_Matrices_y_Arrays.BorrarFilaMatrizInt(matriz3, indiceFila_A_Cargar);

                    }
                    break;
                }
            }
            if (contEspacios == 0)
            {
                Console.WriteLine("No queda más espacio.");

                Console.ReadKey();
            }
        }
        #endregion


        #region 4. Modificar productos
        /// <summary>
        /// Menú: Modificar productos
        /// </summary>
        /// <param name="categorias"></param>
        /// <param name="columnasMatriz1"></param>
        /// <param name="matriz1"></param>
        /// <param name="columnasMatriz2"></param>
        /// <param name="matriz2"></param>
        /// <param name="columnasMatriz3"></param>
        /// <param name="matriz3"></param>
        /// 

        public static void SubMenu_ModificarProductos(string[] categorias, string[] columnasMatriz1, string[,] matriz1, string[] columnasMatriz2,
                                                      int[,] matriz2, string[] columnasMatriz3, int[,] matriz3)
        {
            int opcionMenu;
            string validado;

            bool salir = false;

            Console.Clear();

            while (!salir)
            {
                opcionMenu = Validaciones.ValidacionInt($"{"4. Modificar productos",25}\n{"----------------------",25}" +
                                                        $"\n\n1. Ingresar ID del producto" +
                                                        $"\n2. Ingresar nombre del producto " +
                                                        $"\n3. Mostrar todos los productos" +
                                                        $"\n4. Volver al menú principal" +
                                                        $"\n\nOpción: "
                                                        , 1, 4);

                if (opcionMenu == 1)
                {

                    validado = ModificarIngresandoId(categorias, columnasMatriz1, matriz1, columnasMatriz2, matriz2, columnasMatriz3, matriz3);

                    if (validado.ToLower() == "s" || validado.ToLower() == "si" || validado == "1")
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        continue;
                    }
                }

                else if (opcionMenu == 2)
                {
                    validado = ModificarIngresandoNombre(categorias, columnasMatriz1, matriz1, columnasMatriz2, matriz2, columnasMatriz3, matriz3);

                    if (validado.ToLower() == "s" || validado.ToLower() == "si" || validado == "1")
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        continue;
                    }
                }

                else if (opcionMenu == 3)
                {
                    validado = ModificarMostrandoTodosLosProductos(categorias, columnasMatriz1, matriz1, columnasMatriz2, matriz2, columnasMatriz3, matriz3);

                    if (validado.ToLower() == "s" || validado.ToLower() == "si" || validado == "1")
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        continue;
                    }
                }

                else
                {
                    break;
                }
            }
        }

        #region 4.1 Modificar ingresando ID del producto
        /// <summary>
        /// Te deja modificar el producto ingresando el ID del mismo.
        /// </summary>
        /// <param name="categorias"></param>
        /// <param name="columnasMatriz1"></param>
        /// <param name="matriz1"></param>
        /// <param name="columnasMatriz2"></param>
        /// <param name="matriz2"></param>
        /// <param name="columnasMatriz3"></param>
        /// <param name="matriz3"></param>
        /// <returns>Devuelve el valor para saber si se sale del menu 'Modificar productos' o no.</returns>
        /// 

        public static string ModificarIngresandoId(string[] categorias, string[] columnasMatriz1, string[,] matriz1, string[] columnasMatriz2,
                                                    int[,] matriz2, string[] columnasMatriz3, int[,] matriz3)
        {
            int ingresoIdProducto;
            int contProductosEncontrados = 0;
            int indiceProductoEncontrado = 0;
            int eleccionCategoria;

            string validado = "";

            Console.Clear();

            Console.WriteLine($"{"Modificar productos",25}\n{"---------------------",25}");

            ingresoIdProducto = Validaciones.ValidacionInt("\n4.1 Ingrese ID del producto: ", 1, 350);

            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                // Se fija que el ID ingresado es igual al ID de la fila y que no sea igual al ID asignado para filas vacias
                if (Convert.ToString(ingresoIdProducto) == matriz1[i, 0] && Convert.ToString(ingresoIdProducto) != "-1")
                {
                    contProductosEncontrados++;

                    indiceProductoEncontrado = i;

                    break;
                }
            }
            if (contProductosEncontrados > 0)
            {
                Console.Clear();

                Console.WriteLine($"{"Modificar productos",25}\n{"-------------------",25}");

                Console.WriteLine("\n\n-----------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"{"||",-56}{"4. Modificar productos:",25}{"||",73}");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");

                #region Muestra los titulos de las columnas
                Console.Write("||");

                for (int i = 0; i < columnasMatriz1.Length; i++)
                {

                    Console.Write($"{columnasMatriz1[i],-15}||");

                }
                for (int i = 0; i < columnasMatriz2.Length; i++)
                {

                    Console.Write($"{columnasMatriz2[i],-15}||");

                }
                for (int i = 0; i < columnasMatriz3.Length; i++)
                {

                    Console.Write($"{columnasMatriz3[i],-15}||");

                }
                #endregion

                Console.WriteLine();

                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");

                Console.Write("||");

                for (int i = 0; i < matriz1.GetLength(1); i++)
                {

                    Console.Write($"{matriz1[indiceProductoEncontrado, i],-15}||");

                }
                for (int i = 0; i < matriz2.GetLength(1); i++)
                {

                    Console.Write($"{matriz2[indiceProductoEncontrado, i],-15}||");

                }
                for (int i = 0; i < matriz3.GetLength(1); i++)
                {

                    Console.Write($"{matriz3[indiceProductoEncontrado, i],-15}||");

                }

                Console.WriteLine("");

                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------\n\n");

                // Despues de mostrar el producto que se quiere modificar, se pregunta si esta seguro que se quiere realizar esta acción.
                validado = Validaciones.Si_O_No("¿Esta seguro que quiere modificar este producto?" +
                                                "\n\n1. Si" +
                                                "\n2. No" +
                                                "\n\nOpción: ");

                if (validado.ToLower() == "s" || validado.ToLower() == "si" || validado == "1")
                {

                    for (int i = 0; i < matriz1.GetLength(1); i++)
                    {

                        if (i == 0)
                        {
                            Console.Clear();

                            matriz1[indiceProductoEncontrado, i] = Convert.ToString(Validaciones.ValidacionInt($"Ingrese {columnasMatriz1[i]}: ", 1, 350));
                        }
                        else if (i == 1)
                        {
                            Console.Clear();

                            matriz1[indiceProductoEncontrado, i] = Validaciones.ValidacionStringConNumeros($"Ingrese {columnasMatriz1[i]}: ");
                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine("Categorías:\n----------\n");

                            for (int j = 0; j < categorias.Length; j++)
                            {

                                Console.WriteLine($"{j + 1}. {categorias[j]}");

                            }

                            eleccionCategoria = Validaciones.ValidacionInt("\nOpción categoría: ", 1, 3);

                            matriz1[indiceProductoEncontrado, i] = categorias[eleccionCategoria - 1];
                        }
                    }

                    for (int i = 0; i < matriz2.GetLength(1); i++)
                    {
                        Console.Clear();

                        matriz2[indiceProductoEncontrado, i] = Validaciones.ValidacionInt($"Ingrese {columnasMatriz2[i]}: ", 0, 1000);
                    }
                    for (int i = 0; i < matriz3.GetLength(1) - 2; i++)
                    {
                        Console.Clear();

                        matriz3[indiceProductoEncontrado, i] = Validaciones.ValidacionInt($"Ingrese {columnasMatriz3[i]}: ", 0, 1000);
                    }

                    matriz3[indiceProductoEncontrado, 2] = matriz3[indiceProductoEncontrado, 0] * matriz3[indiceProductoEncontrado, 1];

                    matriz3[indiceProductoEncontrado, 3] = matriz3[indiceProductoEncontrado, 2] - (matriz2[indiceProductoEncontrado, 0] * matriz3[indiceProductoEncontrado, 1]);

                    for (int j = 0; j < 2; j++)
                    {

                        Console.Clear();
                        Console.WriteLine($"Modificando producto");
                        System.Threading.Thread.Sleep(250);
                        Console.Clear();
                        Console.WriteLine($"Modificando producto.");
                        System.Threading.Thread.Sleep(250);
                        Console.Clear();
                        Console.WriteLine($"Modificando producto..");
                        System.Threading.Thread.Sleep(250);
                        Console.Clear();
                        Console.WriteLine($"Modificando producto...");
                        System.Threading.Thread.Sleep(250);
                        Console.Clear();

                    }
                    Console.WriteLine($"El producto fue modificado correctamente!");

                    Console.ReadKey();
                }
            }
            else
            {
                Console.Clear();

                Console.WriteLine($"No se encontro ningún producto con ID: {ingresoIdProducto} ");

                Console.ReadKey();
            }
            return validado;
        }
        #endregion

        #region 4.2 Modificar ingresando nombre del producto
        /// <summary>
        /// Te deja modificar el producto ingresando el nombre del mismo.
        /// </summary>
        /// <param name="categorias"></param>
        /// <param name="columnasMatriz1"></param>
        /// <param name="matriz1"></param>
        /// <param name="columnasMatriz2"></param>
        /// <param name="matriz2"></param>
        /// <param name="columnasMatriz3"></param>
        /// <param name="matriz3"></param>
        /// <returns>Devuelve el valor para saber si se sale del menu 'Modificar productos' o no.</returns>
        /// 

        public static string ModificarIngresandoNombre(string[] categorias, string[] columnasMatriz1, string[,] matriz1, string[] columnasMatriz2,
                                                    int[,] matriz2, string[] columnasMatriz3, int[,] matriz3)
        {
            string ingresoNombreProducto;
            int contProductosEncontrados = 0;
            int indiceProductoEncontrado = 0;
            int eleccionCategoria;

            string validado = "";

            Console.Clear();

            Console.WriteLine($"{"Modificar productos",25}\n{"---------------------",25}");

            ingresoNombreProducto = Validaciones.ValidacionStringConNumeros("\n4.2 Ingrese nombre del producto: ");

            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                // Se fija si el nombre ingresado coincide con el valor en la fila.
                if (ingresoNombreProducto.Trim().ToLower().Replace(" ", "") == matriz1[i, 1].Trim().ToLower().Replace(" ", ""))
                {
                    contProductosEncontrados++;

                    indiceProductoEncontrado = i;

                    break;
                }
            }
            if (contProductosEncontrados > 0)
            {
                Console.Clear();

                Console.WriteLine($"{"Modificar productos",25}\n{"---------------------",25}");

                Console.WriteLine("\n\n-----------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"{"||",-56}{"4. Modificar productos:",25}{"||",73}");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");

                #region Muestra los titulos de las columnas
                Console.Write("||");

                for (int i = 0; i < columnasMatriz1.Length; i++)
                {

                    Console.Write($"{columnasMatriz1[i],-15}||");

                }
                for (int i = 0; i < columnasMatriz2.Length; i++)
                {

                    Console.Write($"{columnasMatriz2[i],-15}||");

                }
                for (int i = 0; i < columnasMatriz3.Length; i++)
                {

                    Console.Write($"{columnasMatriz3[i],-15}||");

                }
                #endregion

                Console.WriteLine();

                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");

                Console.Write("||");

                for (int i = 0; i < matriz1.GetLength(1); i++)
                {

                    Console.Write($"{matriz1[indiceProductoEncontrado, i],-15}||");

                }
                for (int i = 0; i < matriz2.GetLength(1); i++)
                {

                    Console.Write($"{matriz2[indiceProductoEncontrado, i],-15}||");

                }
                for (int i = 0; i < matriz3.GetLength(1); i++)
                {

                    Console.Write($"{matriz3[indiceProductoEncontrado, i],-15}||");

                }
                Console.WriteLine("");

                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");

                validado = Validaciones.Si_O_No("\n\n¿Esta seguro que quiere modificar este producto?" +
                                                "\n\n1. Si" +
                                                "\n2. No" +
                                                "\n\nOpción: ");

                if (validado.ToLower() == "s" || validado.ToLower() == "si" || validado == "1")
                {
                    for (int i = 0; i < matriz1.GetLength(1); i++)
                    {
                        if (i == 0)
                        {
                            Console.Clear();

                            matriz1[indiceProductoEncontrado, i] = Convert.ToString(Validaciones.ValidacionInt($"Ingrese {columnasMatriz1[i]}: ", 1, 350));
                        }
                        else if (i == 1)
                        {
                            Console.Clear();

                            matriz1[indiceProductoEncontrado, i] = Validaciones.ValidacionStringConNumeros($"Ingrese {columnasMatriz1[i]}: ");
                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine("Categorías:\n----------\n");

                            for (int j = 0; j < categorias.Length; j++)
                            {

                                Console.WriteLine($"{j + 1}. {categorias[j]}");

                            }
                            eleccionCategoria = Validaciones.ValidacionInt("\nOpción categoria: ", 1, 3);

                            matriz1[indiceProductoEncontrado, i] = categorias[eleccionCategoria - 1];
                        }
                    }
                    for (int i = 0; i < matriz2.GetLength(1); i++)
                    {
                        Console.Clear();

                        matriz2[indiceProductoEncontrado, i] = Validaciones.ValidacionInt($"Ingrese {columnasMatriz2[i]}: ", 0, 1000);
                    }
                    for (int i = 0; i < matriz3.GetLength(1) - 2; i++)
                    {
                        Console.Clear();

                        matriz3[indiceProductoEncontrado, i] = Validaciones.ValidacionInt($"Ingrese {columnasMatriz3[i]}: ", 0, 1000);
                    }

                    matriz3[indiceProductoEncontrado, 2] = matriz3[indiceProductoEncontrado, 0] * matriz3[indiceProductoEncontrado, 1];

                    matriz3[indiceProductoEncontrado, 3] = matriz3[indiceProductoEncontrado, 2] - (matriz2[indiceProductoEncontrado, 0] * matriz3[indiceProductoEncontrado, 1]);

                    for (int j = 0; j < 2; j++)
                    {

                        Console.Clear();
                        Console.WriteLine("Modificando producto");
                        System.Threading.Thread.Sleep(250);
                        Console.Clear();
                        Console.WriteLine("Modificando producto.");
                        System.Threading.Thread.Sleep(250);
                        Console.Clear();
                        Console.WriteLine("Modificando producto..");
                        System.Threading.Thread.Sleep(250);
                        Console.Clear();
                        Console.WriteLine("Modificando producto...");
                        System.Threading.Thread.Sleep(250);
                        Console.Clear();

                    }
                    Console.WriteLine("El producto fue modificado correctamente!");

                    Console.ReadKey();
                }
            }
            else
            {
                Console.Clear();

                Console.WriteLine($"No se encontro ningún producto con el nombre: {ingresoNombreProducto} ");

                Console.ReadKey();
            }
            return validado;
        }
        #endregion

        #region 4.3 Modificar mostrando todos los productos
        /// <summary>
        /// Muestra todos los productos y te deja elegir cuál modificar
        /// </summary>
        /// <param name="categorias"></param>
        /// <param name="columnasMatriz1"></param>
        /// <param name="matriz1"></param>
        /// <param name="columnasMatriz2"></param>
        /// <param name="matriz2"></param>
        /// <param name="columnasMatriz3"></param>
        /// <param name="matriz3"></param>
        /// <returns>Devuelve el valor para saber si se sale del menu 'Modificar productos' o no.</returns>
        /// 

        public static string ModificarMostrandoTodosLosProductos(string[] categorias, string[] columnasMatriz1, string[,] matriz1, string[] columnasMatriz2,
                                                                      int[,] matriz2, string[] columnasMatriz3, int[,] matriz3)
        {
            int indiceProductoElegido;
            int eleccionCategoria;
            bool continuar = false;

            string validado = "";

            Console.Clear();


            while (!continuar)
            {
                Console.Clear();
                Console.WriteLine($"{"4.3 Productos para modificar",35}\n{"----------------------------",35}");

                Console.WriteLine("\n\n    -----------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"    ||{"Productos",76}{"||",77}");
                Console.WriteLine("    -----------------------------------------------------------------------------------------------------------------------------------------------------------");

                #region Muestra los titulos de las columnas
                Console.Write("    ||");

                for (int i = 0; i < columnasMatriz1.Length; i++)
                {

                    Console.Write($"{columnasMatriz1[i],-15}||");

                }
                for (int i = 0; i < columnasMatriz2.Length; i++)
                {

                    Console.Write($"{columnasMatriz2[i],-15}||");

                }
                for (int i = 0; i < columnasMatriz3.Length; i++)
                {

                    Console.Write($"{columnasMatriz3[i],-15}||");

                }
                #endregion

                Console.WriteLine();

                Console.WriteLine("    -----------------------------------------------------------------------------------------------------------------------------------------------------------");

                for (int i = 0; i < matriz1.GetLength(0); i++)
                {

                    Console.Write($"{i + 1,3}.||");

                    for (int j = 0; j < matriz1.GetLength(1); j++)
                    {

                        Console.Write($"{matriz1[i, j],-15}||");

                    }
                    for (int j = 0; j < matriz2.GetLength(1); j++)
                    {

                        Console.Write($"{matriz2[i, j],-15}||");

                    }
                    for (int j = 0; j < matriz3.GetLength(1); j++)
                    {

                        Console.Write($"{matriz3[i, j],-15}||");

                    }

                    Console.WriteLine("");
                }

                Console.WriteLine("    -----------------------------------------------------------------------------------------------------------------------------------------------------------");

                indiceProductoElegido = Validaciones.ValidacionInt("\n¿Cuál producto desea modificar?\n\nOpción: ", 1, matriz1.GetLength(0));

                // Si se elige una fila vacia te avisa y vuelve a mostrarte la lista entera
                if (matriz1[indiceProductoElegido - 1, 0] == "-1")
                {
                    Console.Clear();

                    Console.WriteLine("Espacio de producto vacio.");

                    Console.ReadKey();

                    continue;
                }
                else
                {
                    Console.Clear();

                    Console.WriteLine($"{"Modificar productos",25}\n{"------------------",25}");

                    Console.WriteLine("\n\n-----------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine($"{"||",-56}{"Modificar productos:",25}{"||",73}");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");

                    #region Muestra los titulos de las columnas
                    Console.Write("||");

                    for (int i = 0; i < columnasMatriz1.Length; i++)
                    {

                        Console.Write($"{columnasMatriz1[i],-15}||");

                    }
                    for (int i = 0; i < columnasMatriz2.Length; i++)
                    {

                        Console.Write($"{columnasMatriz2[i],-15}||");

                    }
                    for (int i = 0; i < columnasMatriz3.Length; i++)
                    {

                        Console.Write($"{columnasMatriz3[i],-15}||");

                    }
                    #endregion

                    Console.WriteLine();

                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");

                    Console.Write("||");

                    for (int i = 0; i < matriz1.GetLength(1); i++)
                    {

                        Console.Write($"{matriz1[indiceProductoElegido - 1, i],-15}||");

                    }
                    for (int i = 0; i < matriz2.GetLength(1); i++)
                    {

                        Console.Write($"{matriz2[indiceProductoElegido - 1, i],-15}||");

                    }
                    for (int i = 0; i < matriz3.GetLength(1); i++)
                    {

                        Console.Write($"{matriz3[indiceProductoElegido - 1, i],-15}||");

                    }
                    Console.WriteLine("");

                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");

                    validado = Validaciones.Si_O_No("\n\n¿Esta seguro que quiere modificar este producto?" +
                                                    "\n\n1. Si" +
                                                    "\n2. No" +
                                                    "\n\nOpción: ");

                    if (validado.ToLower() == "s" || validado.ToLower() == "si" || validado == "1")
                    {

                        for (int i = 0; i < matriz1.GetLength(1); i++)
                        {

                            if (i == 0)
                            {
                                Console.Clear();

                                matriz1[indiceProductoElegido - 1, i] = Convert.ToString(Validaciones.ValidacionInt($"Ingrese {columnasMatriz1[i]}: ", 1, 350));

                            }
                            else if (i == 1)
                            {
                                Console.Clear();

                                matriz1[indiceProductoElegido - 1, i] = Validaciones.ValidacionStringConNumeros($"Ingrese {columnasMatriz1[i]}");

                            }
                            else
                            {
                                Console.Clear();

                                Console.WriteLine("Categorías:\n----------\n\n");

                                for (int j = 0; j < categorias.Length; j++)
                                {

                                    Console.WriteLine($"{j + 1}. {categorias[j]}");

                                }
                                eleccionCategoria = Validaciones.ValidacionInt("Opción categoria: ", 1, 3);

                                matriz1[indiceProductoElegido - 1, i] = categorias[eleccionCategoria - 1];
                            }
                        }
                        for (int i = 0; i < matriz2.GetLength(1); i++)
                        {
                            Console.Clear();

                            matriz2[indiceProductoElegido - 1, i] = Validaciones.ValidacionInt($"Ingrese {columnasMatriz2[i]}: ", 0, 1000);

                        }
                        for (int i = 0; i < matriz3.GetLength(1) - 2; i++)
                        {
                            Console.Clear();

                            matriz3[indiceProductoElegido - 1, i] = Validaciones.ValidacionInt($"Ingrese {columnasMatriz3[i]}: ", 0, 1000);

                        }

                        matriz3[indiceProductoElegido - 1, 2] = matriz3[indiceProductoElegido - 1, 0] * matriz3[indiceProductoElegido - 1, 1];

                        matriz3[indiceProductoElegido - 1, 3] = matriz3[indiceProductoElegido - 1, 2] - (matriz2[indiceProductoElegido - 1, 0] * matriz3[indiceProductoElegido - 1, 1]);

                        for (int j = 0; j < 2; j++)
                        {

                            Console.Clear();
                            Console.WriteLine($"Agregando producto");
                            System.Threading.Thread.Sleep(250);
                            Console.Clear();
                            Console.WriteLine($"Agregando producto.");
                            System.Threading.Thread.Sleep(250);
                            Console.Clear();
                            Console.WriteLine($"Agregando producto..");
                            System.Threading.Thread.Sleep(250);
                            Console.Clear();
                            Console.WriteLine($"Agregando producto...");
                            System.Threading.Thread.Sleep(250);
                            Console.Clear();

                        }
                        Console.WriteLine($"El producto fue modificado correctamente!");

                        Console.ReadKey();

                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return validado;
        }

        #endregion

        #endregion


        #region 5. Borrar productos del sistema
        /// <summary>
        /// Muestra todos los productos del sistema y te deja elegir cuál borrar
        /// </summary>
        /// <param name="columnasMatriz1"></param>
        /// <param name="matriz1"></param>
        /// <param name="columnasMatriz2"></param>
        /// <param name="matriz2"></param>
        /// <param name="columnasMatriz3"></param>
        /// <param name="matriz3"></param>

        public static void BorrarProducto(string[] columnasMatriz1, string[,] matriz1, string[] columnasMatriz2,
                                            int[,] matriz2, string[] columnasMatriz3, int[,] matriz3)
        {
            int indiceProductoElegido;
            bool continuar = false;

            string validado;

            Console.Clear();

            while (!continuar)
            {
                Console.Clear();

                Console.WriteLine($"{"Borrar productos del sistema",35}\n{"-------------------------------",35}");

                Console.WriteLine("\n\n    -----------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"    ||{"Productos",76}{"||",77}");
                Console.WriteLine("    -----------------------------------------------------------------------------------------------------------------------------------------------------------");

                #region Muestra los titulos de las columnas
                Console.Write("    ||");

                for (int i = 0; i < columnasMatriz1.Length; i++)
                {

                    Console.Write($"{columnasMatriz1[i],-15}||");

                }
                for (int i = 0; i < columnasMatriz2.Length; i++)
                {

                    Console.Write($"{columnasMatriz2[i],-15}||");

                }
                for (int i = 0; i < columnasMatriz3.Length; i++)
                {

                    Console.Write($"{columnasMatriz3[i],-15}||");

                }
                #endregion

                Console.WriteLine();

                Console.WriteLine("    -----------------------------------------------------------------------------------------------------------------------------------------------------------");

                for (int i = 0; i < matriz1.GetLength(0); i++)
                {
                    Console.Write($"{i + 1,3}.||");

                    for (int j = 0; j < matriz1.GetLength(1); j++)
                    {

                        Console.Write($"{matriz1[i, j],-15}||");

                    }
                    for (int j = 0; j < matriz2.GetLength(1); j++)
                    {

                        Console.Write($"{matriz2[i, j],-15}||");

                    }
                    for (int j = 0; j < matriz3.GetLength(1); j++)
                    {

                        Console.Write($"{matriz3[i, j],-15}||");

                    }

                    Console.WriteLine("");
                }

                Console.WriteLine("    -----------------------------------------------------------------------------------------------------------------------------------------------------------");

                indiceProductoElegido = Validaciones.ValidacionInt("\n¿Cuál producto desea borrar?\n\nOpción: ", 1, matriz1.GetLength(0));

                if (matriz1[indiceProductoElegido - 1, 0] == "-1")
                {
                    Console.Clear();

                    Console.WriteLine("Espacio de producto vacio.");

                    Console.ReadKey();

                    continue;
                }
                else
                {
                    Console.Clear();

                    Console.WriteLine($"{"Borrar productos del sistema",35}\n{"-------------------",35}");

                    Console.WriteLine("\n\n-----------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine($"{"||",-56}{"Productos",25}{"||",74}");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");

                    #region Muestra los titulos de las columnas
                    Console.Write("||");

                    for (int i = 0; i < columnasMatriz1.Length; i++)
                    {

                        Console.Write($"{columnasMatriz1[i],-15}||");

                    }
                    for (int i = 0; i < columnasMatriz2.Length; i++)
                    {

                        Console.Write($"{columnasMatriz2[i],-15}||");

                    }
                    for (int i = 0; i < columnasMatriz3.Length; i++)
                    {

                        Console.Write($"{columnasMatriz3[i],-15}||");

                    }
                    #endregion

                    Console.WriteLine();

                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");

                    Console.Write("||");

                    for (int i = 0; i < matriz1.GetLength(1); i++)
                    {

                        Console.Write($"{matriz1[indiceProductoElegido - 1, i],-15}||");

                    }
                    for (int i = 0; i < matriz2.GetLength(1); i++)
                    {

                        Console.Write($"{matriz2[indiceProductoElegido - 1, i],-15}||");

                    }
                    for (int i = 0; i < matriz3.GetLength(1); i++)
                    {

                        Console.Write($"{matriz3[indiceProductoElegido - 1, i],-15}||");

                    }

                    Console.WriteLine("");

                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------");

                    validado = Validaciones.Si_O_No("\n\n¿Esta seguro que quiere borrar este producto? La información del mismo se perdera." +
                                                    "\n\n1. Si" +
                                                    "\n2. No" +
                                                    "\n\nOpción: ");

                    // Si esta validado borra los valores de la fila
                    if (validado.ToLower() == "s" || validado.ToLower() == "si" || validado == "1")
                    {
                        Operaciones_Matrices_y_Arrays.BorrarFilaMatrizString(matriz1, indiceProductoElegido - 1);
                        Operaciones_Matrices_y_Arrays.BorrarFilaMatrizInt(matriz2, indiceProductoElegido - 1);
                        Operaciones_Matrices_y_Arrays.BorrarFilaMatrizInt(matriz3, indiceProductoElegido - 1);


                        for (int j = 0; j < 2; j++)
                        {

                            Console.Clear();
                            Console.WriteLine($"Borrando producto");
                            System.Threading.Thread.Sleep(250);
                            Console.Clear();
                            Console.WriteLine($"Borrando producto.");
                            System.Threading.Thread.Sleep(250);
                            Console.Clear();
                            Console.WriteLine($"Borrando producto..");
                            System.Threading.Thread.Sleep(250);
                            Console.Clear();
                            Console.WriteLine($"Borrando producto...");
                            System.Threading.Thread.Sleep(250);
                            Console.Clear();

                        }
                        Console.WriteLine($"El producto fue borrado correctamente!");

                        Console.ReadKey();

                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        #endregion


        #region 6. Facturación y datos de venta
        /// <summary>
        /// Muestra los datos de facturación, ganancias y ventas.
        /// </summary>
        /// <param name="columnasMatriz1"></param>
        /// <param name="matriz1"></param>
        /// <param name="columnasMatriz2"></param>
        /// <param name="matriz2"></param>
        /// <param name="columnasMatriz3"></param>
        /// <param name="matriz3"></param>
        /// 

        public static void SubMenu_Facturacion_Y_DatosVentas(string[] columnasMatriz1, string[,] matriz1, string[] columnasMatriz2,
                                                             int[,] matriz2, string[] columnasMatriz3, int[,] matriz3)
        {

            int opcionMenu;
            bool salir = false;

            Console.Clear();

            while (!salir)
            {
                opcionMenu = Validaciones.ValidacionInt($"{"Facturación y datos de ventas",35}\n{"-----------------------------",35}" +
                                                        $"\n\n1. Facturación " +
                                                        $"\n2. Ganancias  " +
                                                        $"\n3. Datos de ventas" +
                                                        $"\n4. Volver al menú principal" +
                                                        $"\n\nOpción: "
                                                        , 1, 4);

                if (opcionMenu == 1)
                {
                    Console.Clear();

                    MenuFacturacion(columnasMatriz1, matriz1, columnasMatriz3, matriz3);

                    Console.Clear();
                }
                else if (opcionMenu == 2)
                {
                    Console.Clear();

                    MenuGanancias(columnasMatriz1, matriz1, columnasMatriz3, matriz3);

                    Console.Clear();
                }
                else if (opcionMenu == 3)
                {
                    Console.Clear();

                    MenuDatosVentas(columnasMatriz1, matriz1, columnasMatriz3, matriz3);

                    Console.Clear();
                }
                else
                {
                    break;
                }


            }

        }

        #region Facturacion
        /// <summary>
        /// Muestra los datos de facturación
        /// </summary>
        /// <param name="columnasMatriz1"></param>
        /// <param name="matriz1"></param>
        /// <param name="columnasMatriz3"></param>
        /// <param name="matriz3"></param>
        /// 

        public static void MenuFacturacion(string[] columnasMatriz1, string[,] matriz1, string[] columnasMatriz3, int[,] matriz3)
        {

            int opcion;
            int indiceMaxFacturacion;
            int indiceMinFacturacion;

            opcion = Validaciones.ValidacionInt($"{"6.1 Facturación",20}\n{"---------------",20}" +
                                        $"\n\n1. Facturación por producto " +
                                        $"\n2. Facturación total  " +
                                        $"\n3. Producto de mayor facturación" +
                                        $"\n4. Producto de menor facturación" +
                                        $"\n5. Volver al menú anterior" +
                                        $"\n\nOpción: "
                                        , 1, 5);

            #region Facturación por producto
            if (opcion == 1)
            {
                Console.Clear();

                Console.WriteLine($"{"6.1 Facturación",20}\n{"---------------",20}");

                Console.WriteLine("\n-----------------------------------------------");
                Console.WriteLine($"||{"Facturación por producto",33}{"||",12}");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine($"||{columnasMatriz1[0],3} ||{columnasMatriz1[1],-20}||{columnasMatriz3[2],-15}||");
                Console.WriteLine("-----------------------------------------------");

                for (int i = 0; i < matriz1.GetLength(0); i++)
                {
                    if (matriz1[i, 0] == "-1")
                    {

                        continue;

                    }
                    else
                    {

                        Console.WriteLine($"||{matriz1[i, 0],3}.||{matriz1[i, 1],-20}||USD {matriz3[i, 2],-11}||");

                    }
                }
                Console.WriteLine("-----------------------------------------------");

                Console.ReadKey();
            }
            #endregion

            #region Facturación total

            else if (opcion == 2)
            {
                Console.Clear();

                Console.WriteLine($"{"6.1 Facturación",20}\n{"---------------",20}");


                Console.WriteLine("\n-----------------------------------------------");
                Console.WriteLine($"||   Facturación total: USD {Operaciones_Matrices_y_Arrays.SumatoriaColumnaMatriz(matriz3, 2),-10} {"||",8}");
                Console.WriteLine("-----------------------------------------------");

                Console.ReadKey();
            }
            #endregion

            #region Producto de mayor facturación

            else if (opcion == 3)
            {
                Console.Clear();

                Console.WriteLine($"{"6.1 Facturación",20}\n{"---------------",20}");

                Console.WriteLine("\n-----------------------------------------------");
                Console.WriteLine($"||{"Producto con mayor facturación",33}{"||",12}");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine($"|| {columnasMatriz1[0],-3}||{columnasMatriz1[1],-20}||{columnasMatriz3[2],-15}||");
                Console.WriteLine("-----------------------------------------------");


                for (int i = 0; i < matriz3.GetLength(0); i++)
                {
                    if (matriz3[i, 2] == Operaciones_Matrices_y_Arrays.ValorMax_ColumnaMatriz(matriz3, 2))
                    {
                        indiceMaxFacturacion = i;

                        Console.WriteLine($"|| {matriz1[indiceMaxFacturacion, 0],-3}||{matriz1[indiceMaxFacturacion, 1],-20}||USD {matriz3[indiceMaxFacturacion, 2],-11}||");
                    }
                }

                Console.WriteLine("-----------------------------------------------");

                Console.ReadKey();

            }
            #endregion

            #region Producto de menor facturación

            else if (opcion == 4)
            {
                Console.Clear();

                Console.WriteLine($"{"6.1 Facturación",20}\n{"---------------",20}");

                Console.WriteLine("\n-----------------------------------------------");
                Console.WriteLine($"||{"Producto con menor facturación",33}{"||",12}");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine($"|| {columnasMatriz1[0],-3}||{columnasMatriz1[1],-20}||{columnasMatriz3[2],-15}||");
                Console.WriteLine("-----------------------------------------------");

                for (int i = 0; i < matriz3.GetLength(0); i++)
                {
                    if (matriz3[i, 2] == Operaciones_Matrices_y_Arrays.ValorMin_ColumnaMatriz(matriz3, 2))
                    {
                        indiceMinFacturacion = i;

                        Console.WriteLine($"|| {matriz1[indiceMinFacturacion, 0],-3}||{matriz1[indiceMinFacturacion, 1],-20}||USD {matriz3[indiceMinFacturacion, 2],-11}||");
                    }
                }

                Console.WriteLine("-----------------------------------------------");

                Console.ReadKey();
            }

            #endregion

        }
        #endregion

        #region Ganancias
        /// <summary>
        /// Muestra los datos de ganancias
        /// </summary>
        /// <param name="columnasMatriz1"></param>
        /// <param name="matriz1"></param>
        /// <param name="columnasMatriz3"></param>
        /// <param name="matriz3"></param>
        /// 

        public static void MenuGanancias(string[] columnasMatriz1, string[,] matriz1, string[] columnasMatriz3, int[,] matriz3)
        {

            int opcion;
            int indiceMaxGanancias;
            int indiceMinGanancias;

            opcion = Validaciones.ValidacionInt($"{"6.2 Ganancias",20}\n{"-------------",20}" +
                                        $"\n\n1. Ganancias por producto " +
                                        $"\n2. Ganancias totales  " +
                                        $"\n3. Producto de mayor ganancia" +
                                        $"\n4. Producto de menor ganancia" +
                                        $"\n5. Volver al menú anterior" +
                                        $"\n\nOpción: "
                                        , 1, 5);

            #region Ganancia por producto
            if (opcion == 1)
            {
                Console.Clear();

                Console.WriteLine($"{"6.2 Ganancia",20}\n{"------------",20}");

                Console.WriteLine("\n-----------------------------------------------");
                Console.WriteLine($"||{"Ganancia por producto",33}{"||",12}");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine($"||{columnasMatriz1[0],3} ||{columnasMatriz1[1],-20}||{columnasMatriz3[3],-15}||");
                Console.WriteLine("-----------------------------------------------");

                for (int i = 0; i < matriz1.GetLength(0); i++)
                {

                    if (matriz1[i, 0] == "-1")
                    {

                        continue;

                    }
                    else
                    {

                        Console.WriteLine($"||{matriz1[i, 0],3}.||{matriz1[i, 1],-20}||USD {matriz3[i, 3],-11}||");

                    }
                }
                Console.WriteLine("-----------------------------------------------");

                Console.ReadKey();
            }
            #endregion

            #region Ganancias totales

            else if (opcion == 2)
            {
                Console.Clear();

                Console.WriteLine($"{"6.2 Ganancias",20}\n{"-------------",20}");


                Console.WriteLine("\n-----------------------------------------------");
                Console.WriteLine($"||   Ganancias totales : USD {Operaciones_Matrices_y_Arrays.SumatoriaColumnaMatriz(matriz3, 3),-10} {"||",7}");
                Console.WriteLine("-----------------------------------------------");

                Console.ReadKey();
            }
            #endregion

            #region Producto de mayor ganancia

            else if (opcion == 3)
            {
                Console.Clear();

                Console.WriteLine($"{"6.2 Ganancias",20}\n{"-------------",20}");

                Console.WriteLine("\n-----------------------------------------------");
                Console.WriteLine($"||{"Producto con mayor ganancia",33}{"||",12}");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine($"|| {columnasMatriz1[0],-3}||{columnasMatriz1[1],-20}||{columnasMatriz3[3],-15}||");
                Console.WriteLine("-----------------------------------------------");

                for (int i = 0; i < matriz3.GetLength(0); i++)
                {
                    if (matriz3[i, 3] == Operaciones_Matrices_y_Arrays.ValorMax_ColumnaMatriz(matriz3, 3))
                    {
                        indiceMaxGanancias = i;

                        Console.WriteLine($"|| {matriz1[indiceMaxGanancias, 0],-3}||{matriz1[indiceMaxGanancias, 1],-20}||USD {matriz3[indiceMaxGanancias, 3],-11}||");
                    }
                }

                Console.WriteLine("-----------------------------------------------");

                Console.ReadKey();
            }
            #endregion

            #region Producto de menor ganancia

            else if (opcion == 4)
            {
                Console.Clear();

                Console.WriteLine($"{"6.2 Ganancias",20}\n{"-------------",20}");

                Console.WriteLine("\n-----------------------------------------------");
                Console.WriteLine($"||{"Producto con menor ganancia",33}{"||",12}");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine($"|| {columnasMatriz1[0],-3}||{columnasMatriz1[1],-20}||{columnasMatriz3[3],-15}||");
                Console.WriteLine("-----------------------------------------------");

                for (int i = 0; i < matriz3.GetLength(0); i++)
                {
                    if (matriz3[i, 3] == Operaciones_Matrices_y_Arrays.ValorMin_ColumnaMatriz(matriz3, 3))
                    {
                        indiceMinGanancias = i;

                        Console.WriteLine($"|| {matriz1[indiceMinGanancias, 0],-3}||{matriz1[indiceMinGanancias, 1],-20}||USD {matriz3[indiceMinGanancias, 3],-11}||");
                    }
                }

                Console.WriteLine("-----------------------------------------------");

                Console.ReadKey();
            }
            #endregion
        }
        #endregion

        #region Datos de ventas
        /// <summary>
        /// Muestre los datos de ventas
        /// </summary>
        /// <param name="columnasMatriz1"></param>
        /// <param name="matriz1"></param>
        /// <param name="columnasMatriz3"></param>
        /// <param name="matriz3"></param>
        /// 

        public static void MenuDatosVentas(string[] columnasMatriz1, string[,] matriz1, string[] columnasMatriz3, int[,] matriz3)
        {

            int indiceMaxCantVentas;
            int indiceMinCantVentas;


            int opcion;

            opcion = Validaciones.ValidacionInt($"{"6.3 Datos de ventas",25}\n{"-------------------",25}" +
                                        $"\n\n1. Ventas por producto " +
                                        $"\n2. Cant. total de productos vendidos " +
                                        $"\n3. Producto más vendido" +
                                        $"\n4. Producto menos vendido" +
                                        $"\n5. Volver al menú anterior" +
                                        $"\n\nOpción: "
                                        , 1, 5);

            #region Ventas por producto
            if (opcion == 1)
            {
                Console.Clear();

                Console.WriteLine($"{"6.3 Datos de ventas",25}\n{"-------------------",25}");

                Console.WriteLine("\n-----------------------------------------------");
                Console.WriteLine($"||{"Ventas por producto",33}{"||",12}");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine($"||{columnasMatriz1[0],3} ||{columnasMatriz1[1],-20}||{columnasMatriz3[1],-15}||");
                Console.WriteLine("-----------------------------------------------");

                for (int i = 0; i < matriz1.GetLength(0); i++)
                {
                    if (matriz1[i, 0] == "-1")
                    {

                        continue;

                    }
                    else
                    {

                        Console.WriteLine($"||{matriz1[i, 0],3}.||{matriz1[i, 1],-20}|| {matriz3[i, 1],-14}||");

                    }
                }
                Console.WriteLine("-----------------------------------------------");

                Console.ReadKey();
            }
            #endregion

            #region Cantidad total de productos vendidos

            else if (opcion == 2)
            {
                Console.Clear();

                Console.WriteLine($"{"6.3 Datos de ventas",25}\n{"-------------------",25}");


                Console.WriteLine("\n-----------------------------------------------");
                Console.WriteLine($"||  Cant. total de productos vendidos : {Operaciones_Matrices_y_Arrays.SumatoriaColumnaMatriz(matriz3, 1),-1}  ||");
                Console.WriteLine("-----------------------------------------------");

                Console.ReadKey();
            }
            #endregion

            #region Producto más vendido

            else if (opcion == 3)
            {
                Console.Clear();

                Console.WriteLine($"{"6.3 Datos de ventas",25}\n{"-------------------",25}");

                Console.WriteLine("\n-----------------------------------------------");
                Console.WriteLine($"||{"Producto más vendido",33}{"||",12}");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine($"|| {columnasMatriz1[0],-3}||{columnasMatriz1[1],-20}||{columnasMatriz3[1],-15}||");
                Console.WriteLine("-----------------------------------------------");

                for (int i = 0; i < matriz3.GetLength(0); i++)
                {
                    if (matriz3[i, 1] == Operaciones_Matrices_y_Arrays.ValorMax_ColumnaMatriz(matriz3, 1))
                    {
                        indiceMaxCantVentas = i;

                        Console.WriteLine($"|| {matriz1[indiceMaxCantVentas, 0],-3}||{matriz1[indiceMaxCantVentas, 1],-20}|| {matriz3[indiceMaxCantVentas, 1],-14}||");
                    }
                }

                Console.WriteLine("-----------------------------------------------");

                Console.ReadKey();
            }
            #endregion

            #region Producto menos vendido

            else if (opcion == 4)
            {
                Console.Clear();

                Console.WriteLine($"{"6.3 Datos de ventas",25}\n{"-------------------",25}");

                Console.WriteLine("\n-----------------------------------------------");
                Console.WriteLine($"||{"Producto con menor ganancia",33}{"||",12}");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine($"|| {columnasMatriz1[0],-3}||{columnasMatriz1[1],-20}||{columnasMatriz3[1],-15}||");
                Console.WriteLine("-----------------------------------------------");

                for (int i = 0; i < matriz3.GetLength(0); i++)
                {
                    if (matriz3[i, 1] == Operaciones_Matrices_y_Arrays.ValorMin_ColumnaMatriz(matriz3, 1))
                    {
                        indiceMinCantVentas = i;

                        Console.WriteLine($"|| {matriz1[indiceMinCantVentas, 0],-3}||{matriz1[indiceMinCantVentas, 1],-20}|| {matriz3[indiceMinCantVentas, 1],-14}||");
                    }
                }

                Console.WriteLine("-----------------------------------------------");

                Console.ReadKey();
            }
            #endregion

        }


        #endregion

        #endregion
    }
}
