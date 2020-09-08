using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    //Crear una aplicación que, cuando el usuario ingrese un número, calcule el factorial del
    //mismo y lo muestre por pantalla.
    //Nota: El factorial de un número es el producto de todos los números enteros positivos desde
    //1 hasta n. Por ejemplo: 5! = 1 x 2 x 3 x 4 x 5 = 120.
    class Program
    {
        static void Main(string[] args)
        {
            Ej13();
            Ej13v2();
        }

        //SIN RECURSIVIDAD, de 2 hasta n 2x3x4x5xn...
        public static void Ej13()
        {
            int n;
            double acumulador = 1;

            Console.WriteLine("Ingrese el numero factorial: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n <= 1)
            {
                Console.WriteLine("El factorial del numero ingresado, es 1.");
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    acumulador *= i;
                }
                Console.WriteLine("!{0} = {1}.", n, acumulador);
            }
        }
        //Sin recursividad, de n hasta 1
        public static void Ej13v2()
        {
            int n;
            double factorial;

            Console.WriteLine("Ingrese el numero factorial: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine("!{0} = 1.", n);
            }
            else
            {
                factorial = n; //factorial va a ser igual al numero ingresado(ej n=5)
                for (int i = n; i > 1; i--) //en primera iteracion i = 5, 5>1 verd, i-- 
                {
                    factorial = factorial * (i - 1); //5=5*(5-1) == 20 -- 20 = 20 * (4-1) == 60 y asi sucesivamente hasta que i = 1 entonces no entra en al condicion del ciclo
                }
                Console.WriteLine("!{0} = {1}.", n, factorial);
            }
        }
    }
}
