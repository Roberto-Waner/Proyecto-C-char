using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precio, ITBIS = 18, tasa, total;
            int opcion;

            while (true)
            {
                Console.WriteLine("Programa que calcule el Impuesto sobre Transferencias de Bienes Industrializados y Servicios(ITBIS).\n");

                Console.WriteLine("Ingrese el precio del producto: ");
                Console.Write("RD$ ");
                precio = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                tasa = (precio * ITBIS) / 100;
                total = (tasa + precio);

                Console.WriteLine("Precio del producto al aplicale el (ITBIS).\n");
                Console.WriteLine("ITBIS a aplicar el (18%): " + tasa + " RD$ pesos");
                Console.WriteLine("Precio total a pagar: " + total + " RD$ pesos");
                
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
            }
        }
    }
}
