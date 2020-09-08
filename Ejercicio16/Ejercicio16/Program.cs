using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    //Crear una aplicación que, cuando el usuario ingrese un número, lo muestre por pantalla e
    //indique cuántos dígitos tiene.
    //Si el usuario ingresa 5629, mostrará “Número ingresado: 5629 – Tiene 4 dígitos”.
    class Program
    {
        static void Main(string[] args)
        {
            string numero = "";
            int salidanumero;
            int cantdigitos = 0;
            bool flag = false;

            do
            {
                Console.WriteLine("Ingrese el numero, del cual se calculara la cantidad de digitos que tiene: ");
                numero = Console.ReadLine();
                if (!int.TryParse(numero, out salidanumero))
                {
                    Console.WriteLine("Error. Debe ingresar un dato numerico.");
                    flag = false;
                }
                else if (string.IsNullOrEmpty(numero))
                {
                    Console.WriteLine("Error. Debe ingresar un dato numerico.");
                    flag = false;
                }
                else
                {
                    cantdigitos = numero.Length;
                    flag = true;
                }
            } while (flag == false);
            Console.WriteLine("El numero ingresado {0}, tiene {1} digitos.", salidanumero, cantdigitos);
        }
    }
}
