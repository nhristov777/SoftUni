using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sex
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            input = input.OrderByDescending(x => x).Take(3).ToList();
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
