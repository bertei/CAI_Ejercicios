using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    //Crear una aplicación que tome los nombres y sueldos de cinco empleados, para mostrar por
    //pantalla el sueldo mayor y el nombre del empleado.
    class Program
    {
        static void Main(string[] args)
        {
            int[] sueldos_empleados = new int[2];
            string[] nombres_empleados = new string[2];
            float mayor_sueldo = 0;
            int posmax = 0;


            for (int i = 0; i < nombres_empleados.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre del empleado {0}: ", (i + 1));
                nombres_empleados[i] = Console.ReadLine();
                Console.WriteLine("Ingrese el sueldo del empleado {0}: ", (i + 1));
                sueldos_empleados[i] = Convert.ToInt32(Console.ReadLine());


            }

            for (int x = 0; x < nombres_empleados.Length; x++)
            {
                if (sueldos_empleados[x] > mayor_sueldo)
                {
                    mayor_sueldo = sueldos_empleados[x];
                    posmax = x;
                }
            }
            Console.WriteLine("El mayor sueldo es de: {0} y corresponde al empleado: {1}.", mayor_sueldo, nombres_empleados[posmax]);
        }
    }
}
