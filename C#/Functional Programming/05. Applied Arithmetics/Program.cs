using System;

namespace softAdvanced
{
    internal class Program
    {
        static void Main()
        {
            Func<int[], int[]> add = x =>
            {
                for (int i = 0; i < x.Length; i++)
                    x[i] += 1;
                return x;
            };
            Func<int[], int[]> multiply = x =>
            {
                for (int i = 0; i < x.Length; i++)
                    x[i] *= 2;
                return x;
            };
            Func<int[], int[]> subtract = x =>
            {
                for (int i = 0; i < x.Length; i++)
                    x[i] -= 1;
                return x;
            };
            Action<int[]> print = x =>
                Console.WriteLine(String.Join(" ", x));

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string cmd = Console.ReadLine();
            while (cmd != "end")
            {
                switch (cmd)
                {
                    case "add": add(numbers); break;
                    case "multiply": multiply(numbers); break;
                    case "subtract": subtract(numbers); break;
                    case "print": print(numbers); break;
                }
                cmd = Console.ReadLine();
            }
        }
    }
}
