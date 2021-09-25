using System;

namespace Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            double m, cm, km;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n======== Medidas ========\n");
            Console.ResetColor();

            Console.WriteLine("Digite a medida em metros\npara converter em km e\nem cm.\n");

            Console.Write("Digite um número em metros: ");
            m = Convert.ToDouble(Console.ReadLine());

            cm = m * 100;

            km = m / 1000;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n=== Equivalência ===\n");
            Console.ResetColor();

            Console.WriteLine($"{cm} cm\n{m} m\n{km:N2} km\n");
        }
    }
}
