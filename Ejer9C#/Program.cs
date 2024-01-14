using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer9C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> List_temperaturas = new List<double>();
            double max_temp = double.MaxValue;
            double min_temp = double.MinValue;
            double suma_temp = 0, Temperatura, prom_temp;
            int contador_temperatura = 0;
            int opcion;

            do
            {
                for (int i = 0;i < 24; i += 4)
                {
                    Console.Write($"Temperatura exterior a las {i} horas: ");
                    Temperatura = Convert.ToDouble(Console.ReadLine());
                    List_temperaturas.Add(Temperatura);
                    Console.Write("\n");
                }

                for (int i = 0;i < List_temperaturas.Count;i++)
                {
                    if(i == 0)
                    {
                        max_temp = min_temp = List_temperaturas[i];
                    }
                    else
                    {
                        if(List_temperaturas[i] > max_temp)
                        {
                            max_temp = List_temperaturas[i];
                        }
                        else if(List_temperaturas[i] < min_temp)
                        {
                            min_temp = List_temperaturas[i];
                        }
                    }
                    suma_temp += List_temperaturas[i];

                    if (List_temperaturas[i] > 30)
                    {
                        contador_temperatura++;
                    }
                }

                prom_temp = suma_temp / List_temperaturas.Count;
                prom_temp = Math.Round(prom_temp,2);

                Console.WriteLine("Resultados de la Temperatura\n");

                Console.Write($"La Temperatura Media del dia es: {prom_temp}\n\n");
                Console.Write($"La Temperatura Mas Alta es: {max_temp}\n\n");
                Console.Write($"La Temperatura Mas Baja es: {min_temp}\n\n");
                Console.Write($"La Temperatura ha superado los 30 grados Celsius {contador_temperatura} veces.\n\n");

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
