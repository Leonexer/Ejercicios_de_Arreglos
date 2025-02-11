using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 5: Un supermercado necesita un programa en donde almacenar sus ingresos, los cuales son la sumatoria\r\nde todas las ventas realizadas a los clientes (100 clientes)\r\n");
            Random VentaAleatoria = new Random(); //Variable para aleatorizar las ventas
            float[] Ventas = new float[101];
            for (int i = 0; i < 100; i++) //Se asigna un valor aleatorio a los espacios del arreglo y se imprime dicho valor
            {
                Ventas[i] = VentaAleatoria.Next(20, 100); //Se asigna un valor aleatorio del 20 al 100 en el espacio "i" del arreglo Ventas
                Console.WriteLine("Venta total del cliente numero " + (i + 1)+ ": $" + Ventas[i]); //Se imprime el valor asignado en la posicion del cliente
            }

            for (int i = 0;i < 100;i++) //Ciclo para la sumatioria del total
            {
                Ventas[100] = Ventas[100] + Ventas[i]; //Se suma uno por uno el valor y se guarda en la última posición
            }
            Console.WriteLine("");
            Console.WriteLine("\r\nVentas totales: $ "+ Ventas[100]); //Se imprimen los resultados
        }
    }
}
