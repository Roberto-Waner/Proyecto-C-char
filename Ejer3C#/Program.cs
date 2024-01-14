using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D,opcion;
            double resta, divi, suma;

            do
            {
                Console.WriteLine("Expresiones matematicas\n");

                Console.WriteLine("        B");
                Console.WriteLine("A + ----------");
                Console.WriteLine("      C - D\n");

                Console.Write("Ingrese el valor de A: ");
                A = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese el valor de B: ");
                B = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese el valor de C: ");
                C = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese el valor de D: ");
                D = Convert.ToInt32(Console.ReadLine());

                resta = (C - D);
                divi = (B / resta);
                suma = (A + divi);

                //limitador de decimales
                divi = Math.Round(divi, 2);
                suma = Math.Round(suma, 2);

                Console.WriteLine("\nDesarrollo\n");

                Console.WriteLine("\n          "+ B);
                Console.WriteLine(A +" +  ------------");
                Console.WriteLine("        "+ C +" - "+ D +"\n");

                Console.WriteLine("Siguiente Desarrollo\n");

                Console.WriteLine("\n          " + B);
                Console.WriteLine(A + " +  ------------");
                Console.WriteLine("         " + resta + "\n");

                Console.WriteLine("Siguiente Desarrollo\n");

                Console.WriteLine(A +" + "+  divi +"\n");

                Console.WriteLine("Resultado Final\n");

                Console.WriteLine("Suma "+ suma);

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
            }while (true);
        }
    }
}
