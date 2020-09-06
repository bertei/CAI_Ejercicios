using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    //Crear una aplicación que pida al usuario su nombre e indique por pantalla “¡Hola,
    //* usuario*!” si ingresa su nombre, en caso contrario dirá “No te conozco”.
    //Por ejemplo, si el usuario es Suyai, e ingresa el nombre “Suyai” dirá “¡Hola, Suyai!”, si no,
    //“No te conozco”
    class Program
    {
        static void Main(string[] args)
        {
            string nombre_usuario = "";
            int comprobacion_nombre;
            bool flag = false;

            do
            {
                Console.WriteLine("Ingrese su nombre: ");
                nombre_usuario = Console.ReadLine();

                if (string.IsNullOrEmpty(nombre_usuario))
                {
                    Console.WriteLine("No te conozco.");
                }
                else if (int.TryParse(nombre_usuario, out comprobacion_nombre))
                {
                    Console.WriteLine("No te conozco.");
                }
                else
                {
                    Console.WriteLine("Hola, {0}.", nombre_usuario);
                    flag = true;
                }
            } while (flag == false);
        }
    }
}
