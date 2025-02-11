using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random Aleatorizar = new Random();
            float[] Numeros = new float[20]; //Se crea el arreglo en el que estarán los números
            int ContadorPar = 0; //Se crean 2 variables enteras para sevir de contadores par e impar
            int ContadorImpar = 0;

            Console.WriteLine("Ejercicios 6: Necesitamos un programa que capture 20 números y después de capturar los que haga revisión de estos para\r\nindicarnos cuantos son pares y cuantos son impares\r\n");
            for (int i = 0; i < 20; i++) 
            {
                Numeros[i] = Aleatorizar.Next(1, 100); //Se asignan valores aleatorios del 1 al 100 a las 20 posiciones del arrelo
                Console.WriteLine("Numero " + (i+1) + ": " + Numeros[i]); //Se imprime el valor asignado en cada ciclo
            }

            for (int i = 0; i < 20; i++) //Ciclo de comparación
            {
                if ((Numeros[i] % 2) == 0) //Si el número del arreglo es divisible entre 2 (Sin residuo), se suma uno al contador par
                {
                    ContadorPar++;
                }
                else //De lo contrario, se suma 1 al contador impar
                {
                    ContadorImpar++;
                }
            }

            Console.WriteLine("\r\nHay " + ContadorPar + " numeros pares en el arreglo"); //Se muestran los dos contadores
            Console.WriteLine("Hay " + ContadorImpar + " numeros impares en el arreglo");
        }
    }
}
