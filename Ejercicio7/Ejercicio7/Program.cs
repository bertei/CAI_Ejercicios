using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    //Crear una aplicación que, cuando el usuario ingrese cinco números, indique cuál es mayor,
    //cuál es valor intermedio y cuál el menor.
    class Program
    {
        static void Main(string[] args)
        {
            int[] arraynros = new int[5];
            int maximo = 0;
            int minimo = 0;
            int promedio = 0;
            int sumatoria = 0;

            for (int i = 0; i < arraynros.Length; i++)
            {

                Console.WriteLine("Ingrese el numero " + (i + 1) + " de la lista.");
                arraynros[i] = Convert.ToInt32(Console.ReadLine());

                if (i == 0)
                {
                    maximo = arraynros[0];
                    minimo = arraynros[0];
                }
                if (arraynros[i] > maximo)
                {
                    maximo = arraynros[i];
                }
                if (arraynros[i] < minimo)
                {
                    minimo = arraynros[i];
                }
            }

            for (int i = 0; i < arraynros.Length; i++)
            {
                sumatoria += arraynros[i];
            }
            promedio = (sumatoria / arraynros.Length);


            Console.WriteLine("El numero maximo del array de nros es: {0}.", maximo);
            Console.WriteLine("El numero minimo del array de nros es: {0}.", minimo);
            Console.WriteLine("El promedio del array es: " + promedio);
        }
    }
}
