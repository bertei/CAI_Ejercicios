using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
    //Crear una aplicación que, cuando el usuario ingrese un número, indique la cantidad de
    //números primos entre el cero y él, y su factorial.
    //Por ejemplo, si el usuario ingresa 5, indicará “Hasta el 5 hay 3 números primos y el factorial
    //de 5 es 120”.
    class Program
    {
        static void Main(string[] args)
        {

        }

        private static bool ValidarNumero(string numero, int salidanumero)
        {
            bool flag = false;
            if (!int.TryParse(numero, out salidanumero))
            {
                Console.WriteLine("Error. Ingresar dato numerico positivo.");
            }
            else if (salidanumero < 0)
            {
                Console.WriteLine("Error. Ingresar dato numerico positivo.");
            }
            else
            {
                flag = true;
            }
            return flag;
        }

        private static int NumeroPrimo(int numero)
        {

        }
    }
}
