using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerArreglo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 20, suma = 0, Rg1 = 0, Rg2 = 0, Rg3 = 0, Rg4 = 0;
            int[] nota = new int[n];
            double prom;
            string calif;
            int opcion;

            do
            {
                Console.WriteLine("Calificaciones de 20 notas con Vector\n");

                for (int i = 0; i < n; i++)
                {
                    Console.Write("Ingrese la Nota # {0}: ", (i + 1));
                    string input = Console.ReadLine();
                    int parsedInput;
                    //nota[i] = int.Parse(Console.ReadLine());

                    while (!int.TryParse(input, out parsedInput) || parsedInput < 0 || parsedInput > 100)
                    {
                        Console.WriteLine("Valor de Nota incorecta. No se permiten letras o caracteres especiales\n");
                        Console.ReadKey();
                        Console.Clear();
                        Console.Write("Ingrese la Nota # {0}: ", (i + 1));
                        input = Console.ReadLine();

                        //nota[i] = int.Parse(Console.ReadLine());
                    }
                    nota[i] = parsedInput;

                    /*while(nota[i] < 0 || nota[i] > 100)
                    {
                        Console.WriteLine("Valor de Nota incorecta. Las Notas deben de ser de 1 a 100\n");
                        Console.ReadKey();
                        Console.Clear();
                        Console.Write("Ingrese la Nota # {0}: ", (i + 1));
                        nota[i] = int.Parse(Console.ReadLine());
                        nota[i]--;
                    }*/

                    if (nota[i] >= 90)
                    {
                        Rg1++;
                    }
                    else if (nota[i] >= 80)
                    {
                        Rg2++;
                    }
                    else if (nota[i] >= 70)
                    {
                        Rg3++;
                    }
                    else
                    {
                        Rg4++;
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    suma = suma + nota[i];
                }

                prom = suma / n;

                Console.Write("\nPromedio de las Notas ");
                Console.WriteLine(prom);

                //calificacion con letras de los promedios

                if (prom >= 90)
                {
                    calif = "A";
                    Console.Write("Pasa en ");
                    Console.Write(calif);
                    Console.WriteLine(". Esta Aprobado");

                }
                else if (prom >= 80 && prom <= 89)
                {
                    calif = "B";
                    Console.Write("Pasa en ");
                    Console.Write(calif);
                    Console.WriteLine(". Esta Aprobado");

                }
                else if (prom >= 70 && prom <= 79)
                {
                    calif = "C";
                    Console.Write("Pasa en ");
                    Console.Write(calif);
                    Console.WriteLine(". Esta Aprobado");

                }
                else
                {
                    calif = "F";
                    Console.Write("Pasa en ");
                    Console.Write(calif);
                    Console.WriteLine(". Esta Reprobado");

                }

                //Contabilizacion de las calificaciones en la nota

                Console.WriteLine("Resultados de las Notas ya calificadas\n");
                Console.Write("Nota entre 0 a 69: ");
                Console.WriteLine(Rg4);
                Console.Write("Nota entre 70 a 79: ");
                Console.WriteLine(Rg3);
                Console.Write("Nota entre 80 a 89: ");
                Console.WriteLine(Rg2);
                Console.Write("Nota entre 90 a 100: ");
                Console.WriteLine(Rg1);

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
