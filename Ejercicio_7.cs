using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;         

namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random Aleatorizar = new Random();
            double[] Numero = new double[20]; //Arreglo para los numeros
            double[] Cuadrado = new double[20]; //Arreglo para almacenar los cuadrados de los numeros
            double[] Cubo = new double[20]; //Arreglo para almacenar el cubo de los numeros

            Console.WriteLine("Ejercicio 7: Se necesita un programa que capture 20 números en tres diferentes arreglos,en el primero se almacena el \r\nnumero tal cual se tecleo, en el segundo se almacena el cuadrado de dicho numero y en el tercero su cubo.\r\n");

            for (int i = 0; i < Numero.Length; i++) //Ciclo para asingar los valores a los arreglos
            {
                Numero[i] = Aleatorizar.Next(1, 10); //Se asigna un valor aleatorio del 1 al 10
                Console.WriteLine("Valor " + (i+1) + ": "+ Numero[i]);//Se imprime el valor asignado
                Cuadrado[i] = Math.Pow(Numero[i],2); //Se asigna su valor al cuadrado utilizando la funcion Math.Pow(Base, exponente) usando de exponente 2 (al cuadrado)
                Console.WriteLine("Al cuadrado:" + Cuadrado[i]); //Se imprime el resultado
                Cubo[i] = Math.Pow(Numero[i], 3);//Se asigna su valor al cubo utilizando la funcion Math.Pow(Base, exponente) usando de exponente 3 (al cubo)
                Console.WriteLine("Al cubo:" + Cubo[i]+ "\r\n"); //Se imprime el resultado
            }
        }
    }
}
