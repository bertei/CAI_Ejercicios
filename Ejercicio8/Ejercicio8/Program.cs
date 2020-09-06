using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    //Crear una aplicación que, cuando el usuario ingrese una fecha, calcule la diferencia entre
    //ésta y el día de hoy, mostrando por pantalla "La diferencia de fechas es de *nnnnn* días."
    class Program
    {
        static void Main(string[] args)
        {
            string fechastring = "";
            DateTime fecha_hoy = DateTime.Now; //variable que tira la fecha del dia de hoy dia/mes/anio
            TimeSpan diferencia_fechas; //variable que representa un intervalo de tiempo
            DateTime fechasalida;
            int resultadodias;
            bool flag = false;
            do
            {
                Console.WriteLine("Ingrese una fecha en formato (dia/mes/anio).");
                fechastring = Console.ReadLine();
                if (!DateTime.TryParse(fechastring, out fechasalida))
                {
                    Console.WriteLine("Ingrese una fecha correcta.");
                }
                else
                {
                    flag = true;
                }

            } while (flag == false);
            //} while (DateTime.TryParse(fechastring, out fechasalida) != true); // ciclo se repite mientras lo que ingrese no sea una fecha valida, osea dif a true, pq si escribo bien es true y salgo del ciclo

            diferencia_fechas = fecha_hoy - fechasalida;
            resultadodias = diferencia_fechas.Days;


            Console.WriteLine("La diferencia entre la fecha de hoy y la ingresada es de: {0}.", resultadodias);
        }
    }
}
