using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1: utilice unarreglo de seis posiciones para almacenar los 5 parciales de un alumno y sacar su promedio; que sera guardado en el ultimo espacio
            double[] parciales = new double[6];

            Console.WriteLine("Ingrese las calificaciones de los 5 parciales: "); //Pedir las calificaciones de los parciales al usuario 
            for (int i = 0; i < parciales.Length - 1; i++) //Ciclo para pedir los parciales
            {
                parciales[i] = Convert.ToDouble(Console.ReadLine()); //Se convierte el dato leido a double para que sea compatible con el arreglo
            }

            for (int i = 0; i < parciales.Length - 1; i++) //Ciclo para calcular el promedio
            {
                parciales[5] = parciales[5] + parciales[i]; //Se suman todas las calificaciones en la ultima posicion
            }
            parciales[5] = parciales[5] / 5; //Se divide la suma entre 5 para sacar el promedio

            Console.WriteLine("Su promedio final es de " + parciales[5]); //Se presentan los resultados
        }
    }
}
