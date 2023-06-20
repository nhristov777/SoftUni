using System;

namespace softAdvanced
{
    internal class Program
    {
        static void Main()
        {
            int range = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            List<int> numbers = new List<int>();
            for (int i = 1; i <= range; i++)
                numbers.Add(i);
            Predicate<int> divisible = x =>
            {
                int trues = 0;
                foreach (var divider in dividers)
                    if (x % divider == 0) trues++;
                if (trues == dividers.Length) return true;
                else return false;
            };
            Func<List<int>, Predicate<int>, List<int>> filter
                = (numbers, divisible) =>
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (!divisible(numbers[i]))
                        { numbers.Remove(numbers[i]); i--; }
                    }
                    return numbers;
                };
            Console.WriteLine(string.Join(" ", filter(numbers, divisible)));
        }
    }
}
