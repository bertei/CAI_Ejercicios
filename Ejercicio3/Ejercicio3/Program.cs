using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    //Crear una aplicación que indique, cuando el usuario ingresa una palabra, si ésta es un
    //palíndromo.
    //Nota: Palíndromo son palabras que al derecho y al revés se leen igual, como "ananá".
    class Program
    {
        static void Main(string[] args)
        {
            string palabra, palabra_inversa, caracter;
            int tamano_palabra;
            palabra_inversa = "";

            Console.WriteLine("Ingrese la palabra que quiere verificar si es palindrome: ");
            palabra = Console.ReadLine();
            tamano_palabra = palabra.Length - 1; //guardo en la variable int, el tamano en integers del string palabra

            for (int x = tamano_palabra; x >= 0; x--)
            {
                caracter = palabra.Substring(x, 1); //x = tamano-1, osea me agarra de a 1 letra del string ya que el loop resta, entiendo que me agarra la ultima letra
                palabra_inversa += caracter;
            }

            //estructura condicional
            if (palabra == palabra_inversa)
            {
                Console.WriteLine("La palabra ingresada es palindrome.");
            }
            else
            {
                Console.WriteLine("La palabra ingresada no es palindrome.");
            }
        }
    }
}
