using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Restantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Se necesita de un programa que utiliza un arreglo de 5 renglones y cuatro columnas para almacenar \r\nlos 3 parciales y su promedio de 5 alumnos \r\n");
            double[,] Calificaciones = new double[5, 4]; //Creamos el arreglo de 5 renglones y 4 columnas

            //Ciclo para pedir las calificaciones al usuario
            for (int i = 0; i < 5; i++) //La i representa la posición en el arreglo del alumno
            {
                for (int j = 0; j < 3 ; j++) //La j representa la posición de la calificación del alumno i 
                {
                    Console.WriteLine("Ingrese la calificación del parcial " + (j + 1) + " del alumno " + (i + 1) + ":");
                    Calificaciones[i,j] = Convert.ToDouble(Console.ReadLine()); //Leemos el valor pedido y lo convertimos a Double para que sea compatible con la matriz
                }
            }
            for (int i = 0;i < 5; i++) //Ciclo para calcular promedios y mostrarlos en pantalla
            {
                Calificaciones[i, 3] = (Calificaciones[i,0] + Calificaciones[i,1] + Calificaciones[i,2]) / 3; //Se realiza la sumatoria y división para almacenar el valor del promedio en la 3ra posición
                Console.WriteLine("El promedio del alumno "+ (i+1) +" es de "+ Calificaciones[i,3]); //Imprimimos los promedios
            }
        }
    }
