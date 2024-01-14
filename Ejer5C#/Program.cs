using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer5C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cateto_opuesto, cateto_adyacente, hipotenusa;
            int opcion;

            do
            {
                Console.WriteLine("programa que lea de la entrada estandar los dos catetos de un triangulo rectangulo \ny escriba en la salida estandar su hipotenusa.\n");

                Console.WriteLine("Teorema de Pitagoras: h^2 = C.O^2 + C.A^2\n");

                Console.Write("Ingrese el valor del Cateto Opuesto: ");
                cateto_opuesto = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nIngrese el valor del Cateto Adyacente: ");
                cateto_adyacente = Convert.ToDouble(Console.ReadLine());

                //de acuaerdo a la formula del teorema de pitagoras
                hipotenusa = Math.Sqrt(Math.Pow(cateto_opuesto, 2) + Math.Pow(cateto_adyacente, 2));
                hipotenusa = Math.Round(hipotenusa, 2);

                Console.WriteLine("\nLos valores introducidos son:\n");
                Console.WriteLine($"h^2 = ({cateto_opuesto})^2 + ({cateto_adyacente})^2");
                Console.WriteLine($"\nValor de la Hipotenusa: {hipotenusa}");

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
