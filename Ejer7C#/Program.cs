using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer7C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char caracter;
            int opcion;

            do
            {
                while (true)
                {
                    Console.Write("\nIngrese un caracter: ");
                    try
                    {
                        caracter = Convert.ToChar(Console.ReadLine());
                    
                        if(Char.IsLetter(caracter))
                        {
                            break;
                        }
                        else if(Char.IsDigit(caracter))
                        {
                            Console.WriteLine("\nNo se permiten numeros.");
                        }
                        else if(Char.IsSymbol(caracter))
                        {
                            Console.WriteLine("\nNo se permiten simbolos.");
                        }
                        else
                        {
                            Console.WriteLine("\nSolo se permite un Caracter.");
                        }

                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("\nSolo se permite un Caracter.");
                    }
                }

                Console.Write("\n");

                switch (caracter)
                {
                    case 'A':
                        Console.WriteLine($"{caracter} es una vocal Mayuscula.");
                        break;

                    case 'E':
                        Console.WriteLine($"{caracter} es una vocal Mayuscula.");
                        break;

                    case 'I':
                        Console.WriteLine($"{caracter} es una vocal Mayuscula.");
                        break;

                    case 'O':
                        Console.WriteLine($"{caracter} es una vocal Mayuscula.");
                        break;

                    case 'U':
                        Console.WriteLine($"{caracter} es una vocal Mayuscula.");
                        break;

                    case 'a':
                        Console.WriteLine($"{caracter} es una vocal Minuscula.");
                        break;

                    case 'e':
                        Console.WriteLine($"{caracter} es una vocal Minuscula.");
                        break;

                    case 'i':
                        Console.WriteLine($"{caracter} es una vocal Minuscula.");
                        break;

                    case 'o':
                        Console.WriteLine($"{caracter} es una vocal Minuscula.");
                        break;

                    case 'u':
                        Console.WriteLine($"{caracter} es una vocal Minuscula.");
                        break;

                    default:
                        Console.WriteLine($"{caracter} este caracter no es una vocal.");
                        break;
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
