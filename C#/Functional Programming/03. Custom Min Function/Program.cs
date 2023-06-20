using System;

namespace softAdvanced
{
    internal class Program
    {
        static void Main()
        {
            Func<int[], int> min = x =>
            {
                int min = int.MaxValue;
                foreach (var item in x)
                {
                    min = Math.Min(item, min);
                }
                return min;
            };
            int[] nums = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            Console.WriteLine(min(nums));
        }
    }
}
