using System;

namespace softAdvanced
{
    internal class Program
    {
        static void Main()
        {
            static double vat(double x) => x * 1.20;
            List<double> prices = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(vat)
                .ToList();
            foreach (var price in prices)
                Console.WriteLine($"{price:f2}");
        }
    }
}
