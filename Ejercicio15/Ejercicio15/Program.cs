using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        //Crear una aplicación que verifique, en tres oportunidades, si la clave ingresada por el usuario
        //es correcta.La clave será el nombre del usuario, si acierta mostrará por pantalla
        //“Bienvenido, *usuario*”, si no acierta mostrará “Acceso denegado.La contraseña no es
        //correcta”, y cuando se cumplan los tres intentos mostrará “Clave bloqueada”.
        static void Main(string[] args)
        {
            string user_input;
            int intentos = 3;
            int acumulador = 0;
            bool flag = false;
            do
            {
                flag = false;
                Console.WriteLine("Ingrese la clave: ");
                user_input = Console.ReadLine().ToLower();
                if (string.IsNullOrEmpty(user_input))
                {
                    Console.WriteLine("Error. Le quedan {0} intentos.", (intentos - 1));
                    intentos--;
                    acumulador++;
                }
                else if (user_input == "bernardo")
                {
                    Console.WriteLine("Bienvenido, {0}.", user_input);
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Error. Le quedan {0} intentos.", (intentos - 1));
                    intentos--;
                    acumulador++;
                }
            } while (intentos > 0 && flag != true);

            if(acumulador == 3)
            {
                Console.WriteLine("Clave bloqueada.");
            }
        }
    }
}
