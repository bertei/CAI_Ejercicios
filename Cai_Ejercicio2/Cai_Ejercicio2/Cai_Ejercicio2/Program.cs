using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cai_Ejercicio2
{
    class Program
    {
        //        Ejercicio II
        //Crear una aplicación que cuente desde el número 1 hasta los últimos tres dígitos del propio
        //número de registro(en caso de ser comenzar con 0, sumarle 100) e identificar los múltiplos
        //de 3 y, también, aquellos que sean números primos.Para ambos casos(múltiplo de 3 y
        //primos), deben mostrar el número en cuestión y " Es divisible por 3", "Es primo" y, en caso
        //de ser ambos “Es primo y divisible por 3”.
        //Por ejemplo, con el primer número mostrará “1 – Es primo”.
        static void Main(string[] args)
        {
            int LargoArray = 370;
            int[] nrosreg = new int[LargoArray];
            int divisible = 0;

            int Fila;

            for (Fila = 1; Fila < nrosreg.Length; Fila++)
            {
                //estructura repetitiva que me acumule los numeros divisibles
                for (int a = 1; a <= Fila; a++)
                {
                    if (Fila % a == 0)
                    {
                        divisible++;
                    }
                }

                if (divisible <= 2 && Fila % 3 == 0)
                {
                    Console.WriteLine(Fila + " - Es multiplo de tres y numero primo.");
                }
                else if (divisible <= 2)
                {
                    Console.WriteLine(Fila + " - Es nro primo.");
                }
                else if (Fila % 3 == 0)
                {
                    Console.WriteLine(Fila + " - Es multiplo de tres.");
                }
                else
                {
                    Console.WriteLine(Fila);
                }
                divisible = 0;
            }
        }  
    }
}
