using System;

namespace softAdvanced
{
    internal class Program
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split()
                .Where(s => s.Length <= length)
                .ToArray();
            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
