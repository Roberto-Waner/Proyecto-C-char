using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer2C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, opcion;
            double totalAB, totalCD, divi;

            do
            {
                Console.WriteLine("Expresion matematica como expresion en c#");

                Console.WriteLine(" A + B ");
                Console.WriteLine("--------");
                Console.WriteLine(" C + D \n\n");

                Console.Write("Ingrese el valor de A: ");
                A = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese el valor de B: ");
                B = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese el valor de C: ");
                C = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese el valor de D: ");
                D = Convert.ToInt32(Console.ReadLine());

                //Console.Clear();

                Console.WriteLine("\n "+ A + " + " +  B);
                Console.WriteLine("-----------");
                Console.WriteLine(" "+ C + " + " + D + "\n");

                totalAB = (A + B);
                totalCD = (C + D);
                divi = (totalAB / totalCD);

                //limitar los decimales
                totalAB = Math.Round(totalAB, 2);
                totalCD = Math.Round(totalCD, 2);
                divi = Math.Round(divi, 2);

                Console.WriteLine("Suma de los valores A, B, C y D\n");
                Console.WriteLine("  "+ totalAB);
                Console.WriteLine("------------");
                Console.WriteLine("  " + totalCD + "\n");

                Console.WriteLine("Division del total de los valores A + B y C + D\n");
                Console.WriteLine("Total = " +  divi);

                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("\nPresione Enter");
                Console.ReadKey();

                //darle una opcion al usuario para continuar o finalizar el programa
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
            }while (true);
        }
    }
}
