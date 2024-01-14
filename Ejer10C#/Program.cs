using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer10C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int estudiante;
            int aprob_todo = 0, aprob_algunos = 0,aprob_ultima = 0;
            int opcion;

            do
            {
                //Determinar cuantos estudiantes desea examinar
                Console.Write("Cantidad de Estudiantes a evaluar: ");
                estudiante = Convert.ToInt32(Console.ReadLine()); 

                //int[] cantidad_estudiantes = new int[estudiante]; //vector para agregar los estudiantes de acuerdo a cuantos estudaintes desea examinar
                int[] nota = new int[3]; // vector con limites de hasta 3 elementos para agregar las notas 


                for(int i = 0; i < estudiante; i++)
                {
                    Console.WriteLine($"\n---------------------------------------------------\n");
                    Console.WriteLine($"Ingrese las 3 notas del {i + 1}ro Estudiante\n");
                
                    for(int z = 0; z < nota.Length; z++) //para agregar las tres notas de los 3 examenes
                    {
                        Console.Write($"Ingresar la {z + 1}ra nota del estudiante: ");
                        nota[z] = Convert.ToInt32(Console.ReadLine());
                    }

                    //para contar los estudiante que pasaron todos los examen, algunos de los examen o solo el ultimo examen
                    if (nota[0] >= 70 && nota[1] >=70 && nota[2] >= 70)
                    {
                        aprob_todo++;
                    }
                    else if (nota[0] >= 70 || nota[1] >= 70 || nota[2] >= 70)
                    {
                        aprob_algunos++;
                    }
                
                    if (nota[2] >= 70 && nota[0] < 70 && nota[1] < 70)
                    {
                        aprob_ultima++;
                    }
                }

                Console.WriteLine("\n\nResultados----------------------------------------------\n");

                Console.WriteLine($"Total de los Alumnos que aprobaron todos los examenes {aprob_todo}");
                Console.WriteLine($"Total de los Alumnos que aprobaron algunos de los examenes {aprob_algunos}");
                Console.WriteLine($"Total de los Alumnos que aprobaron unicamente el ultimo de los examenes {aprob_ultima}");

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
