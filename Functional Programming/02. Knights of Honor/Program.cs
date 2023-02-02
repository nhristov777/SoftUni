using System;

namespace softAdvanced
{
    internal class Program
    {
        static void Main()
        {
            Action<string[]> action = n =>
            {
                foreach (var item in n)
                {
                    Console.WriteLine
                        (string.Join(Environment.NewLine, $"Sir {item}"));
                }
            };
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            action(names);
        }
    }
}
