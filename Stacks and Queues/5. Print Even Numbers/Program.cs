using System;

namespace Stacking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var queue = new Queue<int>();

            foreach (var number in nums)
            {
                if(number % 2 == 0) queue.Enqueue(number);
            }
            int[] queueArray = queue.ToArray();
            Console.WriteLine(String.Join(", ", queueArray));
        }
    }
}
