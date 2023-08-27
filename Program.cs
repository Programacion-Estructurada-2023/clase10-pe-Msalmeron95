using System;
using System.Collections;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Onteniendo e dato atraves del terminal.
            Console.WriteLine("Ingresa un numero entre 1 y 6:");
            int numero_Mes = Convert.ToInt32(Console.ReadLine());

            //Creando la estructura selectiva SWITCH.
            switch (numero_Mes)
            {
                case 1:
                    Console.WriteLine("\nEl numero ingresado " + numero_Mes + " corresponde a el mes de Enero");
                    break;
                case 2:
                    Console.WriteLine("\nEl numero ingresado " + numero_Mes + " corresponde a el mes de Febrero");
                    break;
                case 3:
                    Console.WriteLine("\nEl numero ingresado " + numero_Mes + " corresponde a el mes de Marzo");
                    break;
                case 4:
                    Console.WriteLine("\nEl numero ingresado " + numero_Mes + " corresponde a el mes de Abril");
                    break;
                case 5:
                    Console.WriteLine("\nEl numero ingresado " + numero_Mes + " corresponde a el mes de Mayo");
                    break;
                case 6:
                    Console.WriteLine("\nEl numero ingresado " + numero_Mes + " corresponde a el mes de Junio");
                    break;
                default:
                    Console.WriteLine("\nEl número ingresado no corresponde a un mes del primer semestre.");
                    break;
            }
            Console.ReadLine(); 
        }
    }
}