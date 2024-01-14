using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Ejer4C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] alumnos = new int[4];
            int[] nota = new int[3];
            int nota_final = 0, opcion;
            double nota_media = 0, promedio;

            Console.WriteLine("Programa que calcula la nota media de 4 alumnos");

            while (true)
            {
                for (int i = 0; i < alumnos.Length; i++)
                {
                    Console.WriteLine($"\n---------------------------------------------------\n");
                    Console.WriteLine("Ingrese las notas del Alumno #{0}: ", i + 1);
                    Console.WriteLine($"*********************************\n");

                    for (int j = 0; j < nota.Length; j++)
                    {
                        Console.Write($"Ingresa la {j + 1}ra nota de la asignatura del alumno: ");
                        nota[j] = int.Parse(Console.ReadLine());
                        nota_final += nota[j];// Sumar las notas   
                    }
                    promedio = ((double)nota_final / nota.Length);
                    promedio = Math.Round(promedio, 2); //para limitar la cantidad de decimales

                    Console.Write($"Su nota final es:{promedio}");
                    nota_final = 0;
                    nota_media += promedio;
                }

                //Calcular la media
                Console.WriteLine($"\n---------------------------------------------------\n");
                nota_media = (nota_media / alumnos.Length);
                nota_media = Math.Round(nota_media, 2);

                // Mostrar la nota media en la salida
                Console.WriteLine("La nota media de los 4 alumnos es: {0} ", nota_media);
                
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
