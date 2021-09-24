using System;

namespace Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.Write("Digite um numero em metros:");
            string numero = Console.ReadLine();
            double medidaM = Convert.ToDouble(numero);
            double medidaCm = medidaM * 100;
            double medidaKm = medidaM / 1000;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine();
            Console.WriteLine("--- Equivalência ---");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine($"{medidaCm}cm");
            Console.WriteLine($"{medidaM}m");
            Console.WriteLine($"{medidaKm:2}km");
            Console.WriteLine();
        }
    }
}
