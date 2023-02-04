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
            double[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToArray();

            var numbers = new Dictionary<double, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!numbers.ContainsKey(input[i]))
                    numbers.Add(input[i], 1);
                else
                    numbers[input[i]]++;
            }
            foreach (var item in numbers)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
