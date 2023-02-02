using System;

namespace softAdvanced
{
    internal class Program
    {
        static void Main()
        {
            int[] range = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int start = range[0];
            int end = range[1];

            Predicate<int> odd = x => x % 2 != 0;
            Predicate<int> even = x => x % 2 == 0;

            List<int> filter = new List<int>();
            for (int i = start; i <= end; i++)
                filter.Add(i);

            string cond = Console.ReadLine();
            if (cond == "odd")
            {
                foreach (var num in filter)
                    if (odd(num)) Console.Write($"{num} ");
            }
            else if (cond == "even")
            {
                foreach (var num in filter)
                    if (even(num)) Console.Write($"{num} ");
            }
        }
    }
}