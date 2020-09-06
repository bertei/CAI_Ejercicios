using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    //Crear una aplicación que, cuando el usuario ingresa un número de 5 cifras, lo invierta y
    //muestre por pantalla “El número invertido es: * nnnnn*”. Por ejemplo, si el usuario ingresa
    //“12345”, mostrará por pantalla “54321”.
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "";
            string outputString;

            Console.WriteLine("Ingrese los caracteres a invertir.");
            inputString = Console.ReadLine();
            outputString = ReverseString(inputString);

            Console.WriteLine("String original : " + inputString);
            Console.WriteLine("String invertida: " + outputString);


        }

        private static string ReverseString(string inputString)
        {
            string reversedString = "";
            for (int count = inputString.Length - 1; count >= 0; count--)
            {
                reversedString += inputString[count];
            }

            return reversedString;
        }
    }
}
