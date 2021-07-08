using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_Parcial
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "ISTEGaming";
            Console.WindowWidth = Console.LargestWindowWidth;

            const int CANT_PRODUCTOS = 15;
            string[] categorias = { "Consola", "Juego Físico", "Accesorio" };

            #region Arrays Productos

            int[] idProducto = new int[CANT_PRODUCTOS]
            {20,1,10,-1,22,-1,2,12,13,3,-1,11,14,-1,21};

            string[] nombreProducto = new string[CANT_PRODUCTOS]
            {"Auriculares","PS5","FIFA 21","Espacio Disp.","Soporte Consola","Espacio Disp.","Nintendo Switch","Mario Kart","GTA V",
             "Xbox Series X","Espacio Disp.","Resident Evil 8","Yakuza 0","Espacio Disp.","Joystick"};

            string[] categoriaProducto = new string[CANT_PRODUCTOS]
            {"Accesorio","Consola","Juego Físico","Espacio Disp.","Accesorio","Espacio Disp.","Consola","Juego Físico",
             "Juego Físico","Consola","Espacio Disp.","Juego Físico","Juego Físico","Espacio Disp.","Accesorio" };

            #endregion

            #region Matriz Productos

            string[] columnasProducto = { "ID", "Producto", "Categoria" };
            string[,] matrizProductos = new string[CANT_PRODUCTOS, columnasProducto.Length];
            Operaciones_Matrices_y_Arrays.CargarMatrizString3Columnas(matrizProductos, idProducto, nombreProducto, categoriaProducto);

            #endregion

            #region Arrays Inventario

            int[] costoProducto = new int[CANT_PRODUCTOS]
            {10,276,25,-1,5,-1,200,15,20,300,-1,35,17,-1,50 };

            int[] stock = new int[CANT_PRODUCTOS]
            {160,0,20,-1,50,-1,15,17,5,99,-1,13,7,-1,42};

            #endregion

            #region Matriz Inventario

            string[] columnasInventario = { "Costo", "Stock" };
            int[,] matrizInventario = new int[CANT_PRODUCTOS, columnasInventario.Length];
            Operaciones_Matrices_y_Arrays.CargarMatrizInt2Columnas(matrizInventario, costoProducto, stock);

            #endregion

            #region Arrays Datos Ventas

            int[] precio = new int[CANT_PRODUCTOS]
            {25,550,50,-1,15,-1,300,35,22,500,-1,60,25,-1,100};

            int[] cantVentas = new int[CANT_PRODUCTOS]
            {200,10,300,-1,5,-1,50,26,100,2,-1,65,19,-1,123};

            int[] facturacion = new int[CANT_PRODUCTOS];
            Operaciones_Matrices_y_Arrays.MultiplicadorArrays(precio, cantVentas, facturacion);

            int[] ganancia = new int[CANT_PRODUCTOS];
            Operaciones_Matrices_y_Arrays.CalculadorGanancias(costoProducto, cantVentas, facturacion, ganancia);

            #endregion

            #region Matriz Datos Ventas

            string[] columnasDatosVentas = { "Precio de Venta", "Cant. Ventas", "Facturación", "Ganancia" };
            int[,] matrizDatosVentas = new int[CANT_PRODUCTOS, columnasDatosVentas.Length];
            Operaciones_Matrices_y_Arrays.CargarMatrizInt4Columnas(matrizDatosVentas, precio, cantVentas, facturacion, ganancia);

            #endregion


            Console.WriteLine("Bienvenido, presione cualquier tecla para comenzar.");
            Console.ReadKey();

            Menus.MenuPrincipal(categorias, columnasProducto, matrizProductos, columnasInventario, matrizInventario, columnasDatosVentas, matrizDatosVentas);

        }
    }
}
