using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 2: Se necesita un programa que utiliza 3 arreglos, en los dos primeros se colocan los promedios de dos grupos\r\nde 5 alumnos cada uno y el tercer arreglo almacenara el promedio mas alto de cada posición. Imprimir los\r\npromedios mas altos \r\n");
            double[] Promedios1 = new double[5];
            double[] Promedios2 = new double[5]; //Creamos los 3 arreglos
            double[] PromediosAltos = new double[5];

            for (int i = 0; i < 5; i++) // Pedimos sus valores
            {
                Console.WriteLine("Ingrese el promedio numero " + (i + 1) + " de los primeros promedios: ");
                Promedios1[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el promedio numero " + (i + 1) + " de los segundos promedios: ");
                Promedios1[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++) //Hacemos un ciclo de comparación, donde si el primer valor es mayor que el segundo valor se guarda en el arreglo de promedios altos
            {
                if (Promedios1[i] > Promedios2[i])
                {
                    PromediosAltos[i] = Promedios1[i];
                }
                else
                {
                    PromediosAltos[i] = Promedios2[i];
                }
            }

            for (int i = 0; i < 5; i++) //Presentamos los resultados del arreglo de promedio más alto
            {
                Console.WriteLine("");
                Console.WriteLine("Promedio mas alto " + (i + 1));
                Console.WriteLine(PromediosAltos[i]);
            }

        }
    }
}
