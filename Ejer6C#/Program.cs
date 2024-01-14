using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer6C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            double a, b, c, x1,x2, muti, raiz, suma, resta;
            int opcion;

            do
            {
                Console.WriteLine("Calculo de ecuaciones de 2do grado\n");

                Console.WriteLine("ax^2 + bx + c = 0\n");

                Console.Write("Ingrese el valor de a: ");
                a = double.Parse(Console.ReadLine());

                Console.Write("\nIngrese el valor de b: ");
                b = double.Parse(Console.ReadLine());

                Console.Write("\nIngrese el valor de c: ");
                c = double.Parse(Console.ReadLine());

            
                Console.WriteLine($"\n{a}x^2 + {b}x + {c} = 0\n");

                Console.WriteLine("Formula");
                Console.WriteLine("x=(-b±√(b^2-4ac)) / 2a\n");

                Console.WriteLine("Desarrollo");
                Console.WriteLine($"x = -({b}) ± √({b}^2 - 4({a})({c}) / 2({a})\n");
          
                double calculo = Math.Pow(b, 2) - 4 * a * c;

                if(calculo >= 0) 
                {
                    raiz = Math.Sqrt(calculo);//sacar raiz cuadrada
                    raiz = Math.Round(raiz, 2);//limitar la cantidad de decimales

                    muti = (2 * a);
                    muti = Math.Round(muti, 2);

                    Console.WriteLine($"   -({b}) ± " + raiz);
                    Console.WriteLine("x = --------------");
                    Console.WriteLine($"       {muti}\n");

                    suma = (0 - b) + raiz;
                    suma = Math.Round(suma, 2);
                    resta = (0 - b) - raiz;
                    resta = Math.Round(resta, 2);

                    x1 = (suma / muti);
                    x1 = Math.Round(x1, 2);
                    x2 = (resta / muti);
                    x2 = Math.Round(x2, 2);

                    Console.WriteLine("Resultados\n");
                    Console.WriteLine($"x = {suma} / {muti} = {x1}\n");
                    Console.WriteLine($"x = {resta} / {muti} = {x2}");
                }
                else
                {
                    double imaginario = (calculo * -1);
                    raiz = Math.Sqrt(imaginario);
                    raiz = Math.Round(raiz, 2);

                    muti = (2 * a);
                    muti = Math.Round(muti, 2);

                    Console.WriteLine($"   -({b}) ± " + raiz + " i");
                    Console.WriteLine("x = -----------------");
                    Console.WriteLine($"       {muti}\n");

                    suma = (0 - b) + raiz;
                    suma = Math.Round(suma, 2);
                    resta = (0 - b) - raiz;
                    resta = Math.Round(resta, 2);

                    x1 = (suma / muti);
                    x1 = Math.Round(x1, 2);
                    x2 = (resta / muti);
                    x2 = Math.Round(x2, 2);

                    Console.WriteLine("Resultados\n");
                    Console.Write("Suma ");
                    Console.WriteLine($"x = {suma} / {muti} i = {x1} i\n");
                    Console.Write("Resta ");
                    Console.WriteLine($"x = {resta} / {muti} i = {x2} i");
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
                        Environment.Exit(0);
                        break;
                }

                Console.ReadKey();
            } while (true);

        }
    }
}
