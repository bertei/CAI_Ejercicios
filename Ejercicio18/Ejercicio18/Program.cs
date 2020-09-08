using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero;
            int salidanumero = 0;
            string resultado;
            bool flag;

            do
            {
                Console.WriteLine("Ingrese el numero decimal a convertir en binario: ");
                numero = Console.ReadLine();
                flag = ValidarNumero(numero, ref salidanumero);
                resultado = ConvertirBinario(salidanumero);
            } while (flag == false);

            Console.WriteLine("El numero ingresado es {0} y su conversion a binario es {1}.", numero, resultado);

            Console.WriteLine("----------------------------------------------------------------------");

            do
            {
                Console.WriteLine("Ingrese el numero decimal a convertir en octal: ");
                numero = Console.ReadLine();
                flag = ValidarNumero(numero, ref salidanumero);
                resultado = ConvertirOctal(salidanumero);
            } while (flag == false);

            Console.WriteLine("El numero ingresado es {0} y su conversion a octal es {1}.", numero, resultado);

        }

        private static bool ValidarNumero(string nro, ref int salidanro)
        {
            bool flag = false;
            if(!int.TryParse(nro, out salidanro))
            {
                Console.WriteLine("Error, el dato ingresado debe ser numerico.");
            }
            else if (salidanro < 0)
            {
                Console.WriteLine("Error, el dato ingresado debe ser positivo.");
            }
            else
            {
                flag = true;
            }
            return flag;
        }

        private static string ConvertirBinario(int numero)
        {
            int residuo = 0;
            string resultado = "";

            do
            {
                residuo = numero % 2; //almacena el residuo de la division
                numero = numero / 2; //el numero sera igual a si mismo dividido en 2 (Es para redondear)
                resultado = residuo + resultado; //voy acumulando en cadena de cararcter (resultado) los residuos del ciclo hasta que numero es diferente a 0
            } while (numero != 0);

            return resultado;
        }

        private static string ConvertirOctal(int numero)
        {
            int residuo = 0;
            string resultado = "";

            do
            {
                residuo = numero % 8; //almacena el residuo de la division
                numero = numero / 8; //el numero sera igual a si mismo dividido en 2 (Es para redondear)
                resultado = residuo + resultado;
            } while (numero != 0);

            return resultado;
        }

        
    }
}
