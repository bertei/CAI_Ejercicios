using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    //Crear una aplicación que lea un carácter tecleado por el usuario e indique si se trata de una
    //vocal, una cifra numérica o una consonante.
    //Nota: Incluir todas las validaciones que considere necesarias (los caracteres especiales no
    //deben tenerse en cuenta).
    class Program
    {
        static void Main(string[] args)
        {
            char userinputchar;
            string userinput;
            bool flag = false;

            do
            {
                flag = false;
                Console.WriteLine("Ingrese un caracter, y la computadora determinara si es una vocal, consonante o dato numerico.");
                userinput = Console.ReadLine();
                if (!char.TryParse(userinput, out userinputchar))
                {
                    Console.WriteLine("Error, no se ha ingresado un caracter. No se permiten cadenas de texto.");
                    flag = true;
                }
            } while (flag);

            if (char.IsDigit(userinputchar))
            {
                Console.WriteLine("Se ha ingresado un dato numerico, este es: {0}.", userinputchar);
            }
            else if (char.IsLetter(userinputchar))
            {
                switch (userinputchar)
                {
                    case 'a':
                        Console.WriteLine("Se ha ingresado una vocal: {0}.", userinputchar);
                        break;
                    case 'e':
                        Console.WriteLine("Se ha ingresado una vocal: {0}.", userinputchar);
                        break;
                    case 'i':
                        Console.WriteLine("Se ha ingresado una vocal: {0}.", userinputchar);
                        break;
                    case 'o':
                        Console.WriteLine("Se ha ingresado una vocal: {0}.", userinputchar);
                        break;
                    case 'u':
                        Console.WriteLine("Se ha ingresado una vocal: {0}.", userinputchar);
                        break;
                    default:
                        Console.WriteLine("Se ha ingresado la consonante: {0}.", userinputchar);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Lo ingresado no es un dato numerico ni una vocal o consonante.");
            }
        }
    }
}
