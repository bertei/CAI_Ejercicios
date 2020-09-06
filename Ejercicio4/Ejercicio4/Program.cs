using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    //Crear una aplicación que indique, cuando el usuario ingresa dos palabras, si éstas son un
    //anagrama.
    //Nota: Anagrama son palabras que reordenando sus letras forman una nueva, como "roma"
    //y "amor".
    class Program
    {
        static void Main(string[] args)
        {
            string palabra1, palabra2;
            Console.WriteLine("Ingrese la primera palabra a comparar: ");
            palabra1 = Console.ReadLine().ToLower(); //convierto el string a minuscula para que no haya errores
            Console.WriteLine("Ingrese la segunda palabra a comprar: ");
            palabra2 = Console.ReadLine().ToLower();

            //proceso, creo una estructura condicional y repetitiva. La primera condicion es que ambas palabras tengan la misma cantidad de caracteres.
            //La estructura repetitiva, es de dos for, el primero de la palabra 1 y el segundo de la palabra 2. A traves de un linear search, voy a ir comparando la primera iteracion
            //de la palabra 1 (iteracion 0) con las iteraciones de la palabra 2 (hasta que encuentre que el primer caracter de p1 sea igual al caracter de la p2 en la determinada iteracion)
            //una vez encontrado esta igualdad, remuevo ese caracter de la palabra2.
            //el loop va a terminar cuando palabra2 no tenga mas caracteres, lo q significa que ambas palabras son anagramas entre si. Caso contrario, no lo son.

            if (palabra1 != palabra2)
            {
                Console.WriteLine("Las palabras ingresadas no son anagramas.");
            }
            else
            {
                for (int a = 0; a < palabra1.Length; a++)
                {
                    for (int b = 0; b < palabra2.Length; b++)
                    {
                        if (palabra1[a] == palabra2[b]) //si la palabra1 en index a es igual a palabra2 en index b
                        {
                            palabra2.Remove(b, 1); //se borra el caracter de palabra2, en index b(el de la iteracion q este) en cantidad 1
                        }
                    }
                    if (palabra2.Length == 0)
                    {
                        Console.WriteLine("Las palabras ingresadas son anagramas.");
                    }
                    else
                    {
                        Console.WriteLine("Las palabras ingresadas no son anagramas.");
                    }
                }
            }
        }
    }
}
