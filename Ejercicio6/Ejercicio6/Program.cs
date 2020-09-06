using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    //Crear una aplicación que, cuando el usuario ingrese dos números, realice la operación
    //aritmética(a+b)* (a-b) e indique por pantalla el resultado.
    class Program
    {
        static void Main(string[] args)
        {
            string n1, n2;
            int salidanro1 = 0;
            int salidanro2 = 0;
            int operacion = 0;
            bool flag;

            do
            {
                Console.WriteLine("Ingrese el primer numero.");
                n1 = Console.ReadLine();
                flag = ValidarNro(n1, ref salidanro1);
                Console.WriteLine("Ingrese el segundo numero.");
                n2 = Console.ReadLine();
                flag = ValidarNro(n2, ref salidanro2);
            } while (flag == false);
            operacion = (salidanro1 + salidanro2) * (salidanro1 - salidanro2);
            Console.WriteLine("El resultado es de : " + operacion);
        }

        private static bool ValidarNro(string numero, ref int salidanro)
        {
            bool flag = false;
            if (!int.TryParse(numero, out salidanro))
            {
                Console.WriteLine("Debe ingresar un dato numerico.");
            }
            else if (salidanro < 0)
            {
                Console.WriteLine("Debe ingresar un numero positivo.");
            }
            else
            {
                flag = true;
            }

            return flag;
        }
    }
}
