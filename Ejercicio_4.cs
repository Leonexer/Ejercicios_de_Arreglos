using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 4: Se necesita un programa que utilizar una matriz de 10 renglones y 3 columnas. En las dos primeras columnas se colocan los promedios de los 10 alumnos de dos grupos (A y B) y en la tercera columna se almacenara el promedio mas \r\nalto de cada posición. \r\n");

            Double[,] Promedios = new Double[10, 3]; //Creamos el arreglo bidimensional donde se almacenaran las calificaciones
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("Ingrese la calificación del alumno " + (j + 1) + " del grupo " + (i + 1));
                    Promedios[j, i] = Convert.ToDouble(Console.ReadLine()); //Pedimos la califiación de la posición i
                    if (Promedios[j, 0] > Promedios[j, 1]) //Comparamos la calificación ingresada a la del segundo alumno
                    {
                        Promedios[j, 2] = Promedios[j, 0];  //Se almacena  la primera si es más alta
                    }
                    else //De lo contrario se almacena la segunda calificación  ingresada
                    {
                        Promedios[j, 2] = Promedios[j, 1];
                    }
                }
            }
        }
    }
