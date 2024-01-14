using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("                                            Programa en C#");
                Console.WriteLine("                                            Menu principal");
                Console.WriteLine("**************************************************************************************************************");
                Console.WriteLine("1  - Programa que lea el precio de un producto y muestre en la salida estandar el precio \n     del producto al aplicarle el ITBIS.");
                Console.WriteLine("2  - Expresion matematica como expresion en c# parte 1.");
                Console.WriteLine("3  - Expresion como expresion en c# parte 2.");
                Console.WriteLine("4  - Programa que lea la nota final de cuatro alumnos y calcule la nota final media de los \n     cuatro alumnos.");
                Console.WriteLine("5  - Programa que lea de la entrada estandar los dos catetos de un triangulo rectangulo y \n     escriba en la salida estandar su hipotenusa.");
                Console.WriteLine("6  - Programa que calcule las soluciones de una ecuacion de segundo grado de la forma ax^2 + bx + c = 0, \n     teniendo en cuenta que: x=(-b±√(b^2-4ac))/2a");
                Console.WriteLine("7  - Programa que lea un caracter e indique en la salida estandar si el caracter es una vocal minuscula, \n     es una vocal mayuscula o no es una vocal.");
                Console.WriteLine("8  - programa que lea tres numeros. Despues debe leer un cuarto numero e indicar si el numero coincide con\n     alguno de los introducidos con anterioridad.");
                Console.WriteLine("9  - Programa que tome cada 4 horas la temperatura exterior, leyendola durante un periodo de 24 horas. Es decir,\n     debe leer 6 temperaturas. Calcule la temperatura media del dia, la temperatura mas alta y la mas baja.");
                Console.WriteLine("10 - Programa que determine cuantos alumnos aprobaron los examenes.");
                Console.WriteLine("11 - Probrama que calcula 20 notas y la evalua calificandola con letras usando vectores.");
                Console.WriteLine("12 - Probrama que calcula 20 notas y la evalua calificandola con letras usando vectores en C++.");
                Console.WriteLine("13 - Salir del programa principal");
                Console.WriteLine("**************************************************************************************************************");
                Console.Write("\nElige una opcion: ");
                opcion = Convert.ToInt16(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        /*Process.Start(new ProcessStartInfo
                        {
                            FileName = "Ejer1C#.exe",
                            WorkingDirectory = @"D:\\Proyecto\\C#\\ProyectoC#\\Ejer1C#\\Ejer1C#\\bin\\Debug",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true,
                        });*/

                        Process.Start("D:\\Proyecto\\C#\\ProyectoC#\\Ejer1C#\\Ejer1C#\\bin\\Debug\\Ejer1C#.exe");
                        //System.Diagnostics.Process.Start($@"D:\Proyecto\C#\ProyectoC#\Ejer1C#\Ejer1C#\bin\Debug\Ejer1C#.exe");
                        break;
                    case 2: Process.Start("D:\\Proyecto\\C#\\ProyectoC#\\Ejer2C#\\bin\\Debug\\Ejer2C#.exe"); break;
                    case 3: Process.Start("D:\\Proyecto\\C#\\ProyectoC#\\Ejer3C#\\bin\\Debug\\Ejer3C#.exe"); break;
                    case 4: Process.Start("D:\\Proyecto\\C#\\ProyectoC#\\Ejer4C#\\bin\\Debug\\Ejer4C#.exe"); break;
                    case 5: Process.Start("D:\\Proyecto\\C#\\ProyectoC#\\Ejer5C#\\bin\\Debug\\Ejer5C#.exe"); break;
                    case 6: Process.Start("D:\\Proyecto\\C#\\ProyectoC#\\Ejer6C#\\bin\\Debug\\Ejer6C#.exe"); break;
                    case 7: Process.Start("D:\\Proyecto\\C#\\ProyectoC#\\Ejer7C#\\bin\\Debug\\Ejer7C#.exe"); break;
                    case 8: Process.Start("D:\\Proyecto\\C#\\ProyectoC#\\Ejer8C#\\bin\\Debug\\Ejer8C#.exe"); break;
                    case 9: Process.Start("D:\\Proyecto\\C#\\ProyectoC#\\Ejer9C#\\bin\\Debug\\Ejer9C#.exe"); break;
                    case 10: Process.Start("D:\\Proyecto\\C#\\ProyectoC#\\Ejer10C#\\bin\\Debug\\Ejer10C#.exe"); break;
                    case 11: Process.Start("D:\\Proyecto\\C#\\ProyectoC#\\EjerArreglo\\bin\\Debug\\EjerArreglo.exe"); break;
                    case 12: Process.Start("D:\\Proyecto\\C#\\ProyectoC#\\EjerArregloC++\\EjerArreglo.exe"); break;
                    case 13:
                        Console.WriteLine("Ha salido del programa.");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;

                    default: 
                        Console.WriteLine("No existe esta opcion.");
                        Console.ReadKey();
                        break;
                }

                Console.ReadKey();
            } while (true);
        }
    }
}
