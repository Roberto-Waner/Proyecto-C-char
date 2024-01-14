using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer8C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num_igual, num1, num2, num3;
            int opcion;

            do
            {
                Console.WriteLine("Comparacion de tres numeros y determinar cual de los 3 son iguales al 4to numero.\n");

                Console.Write("Ingresa el Primer numero: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresa el Segundo numero: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresa el Tercer numero: ");
                num3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nAhora vamos a comparar");

                Console.Write("\nIngresa el numero que quieres comparar: ");
                num_igual = int.Parse(Console.ReadLine());

                if(num_igual == num1)
                {
                    Console.WriteLine($"El numero {num_igual} es igual al Primer numero.");
                }
                else if(num_igual == num2)
                {
                    Console.WriteLine($"El numero {num_igual} es igual al Segundo numero.");
                }
                else if(num_igual == num3)
                {
                    Console.WriteLine($"El numero {num_igual} es igual al Tercer numero.");
                }
                else
                {
                    Console.WriteLine($"El numero {num_igual} no es igual a ninguno de los 3 numero anteriores.");
                }

                //darle una opcion al usuario para continuar o finalizar el programa
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("\nPresione Enter");
                Console.ReadKey();

                Console.WriteLine("\nDesea realizar otro calculo o finalizar");
                Console.WriteLine("Ingrese 1 para continual. Despues de elegir esta opcion precionar Enter 2 veces");
                Console.WriteLine("Ingrese 0 para finalizar");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        break;
                    case 0:
                        Console.WriteLine("Programa finalizado");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opcion invalida, por favor ingrese 0 o 1");
                        Console.ReadKey();
                        break;
                }

                Console.ReadKey();
            } while (true);
        }
    }
}
