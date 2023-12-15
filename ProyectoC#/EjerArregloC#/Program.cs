namespace EjerArregloC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 20, suma = 0, Rg1 = 0, Rg2 = 0, Rg3 = 0, Rg4 = 0;
            int[] nota = new int[n];
            double prom;
            string calif;

            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Calificaciones de notas con Vector\n\n");

            for(int i = 0; i < n; i++)
            {

                Console.Write("Ingrese la Nota # {0}", (i + 1), ": ");
                nota[i] = int.Parse(Console.ReadLine());

                if (nota[i] < 0 && nota[i] > 100)
                {
                    Console.WriteLine("Valor de Nota incorecta. Las Notas deben de ser de 1 a 100\n\n");
                    Console.ReadKey();
                    Console.Clear();
                    i--;

                }else if (nota[i] >= 90)
                {
                    Rg1++;
                }else if (nota[i] >= 80)
                {
                    Rg2++;
                }else if (nota[i] >= 70)
                {
                    Rg3++;
                }
                else
                {
                    Rg4++;
                }
            }

            for(int i = 0;i < n; i++)
            {
                suma += nota[i];
            }

            prom = double.Parse(Console.ReadLine());
            
            prom = suma/n;

            Console.WriteLine(prom);


        }
    }
}