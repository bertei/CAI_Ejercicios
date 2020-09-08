using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    //Crear una aplicación que, cuando el usuario ingrese un número, muestre su tabla de
    //multiplicar por pantalla.
    class Program
    {
        static void Main(string[] args)
        {
            int nro;
            int resultado = 0;
            Console.WriteLine("Ingrese el numero a mostrar su tabla de multiplicar: ");
            nro = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                resultado = nro * i;
                Console.WriteLine("{0} x {1} = {2}.", nro, i, resultado);
            }
        }
    }
}
