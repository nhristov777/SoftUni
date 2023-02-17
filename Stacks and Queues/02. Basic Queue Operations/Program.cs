using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //N push, S pop, X search
            var stack = new Queue<int>();
            int[] commands = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int push = commands[0];
            int pop = commands[1];
            int search = commands[2];

            foreach (int number in numbers) stack.Enqueue(number);
            for (int i = 1; i <= pop; i++)
            {
                stack.Dequeue();
            }
            if (stack.Contains(search)) Console.WriteLine("true");
            else if (stack.Count == 0) Console.WriteLine(0);
            else Console.WriteLine(SmallestNumber(stack));
        }
        public static int SmallestNumber(Queue<int> stack)
        {
            int min = int.MaxValue;
            foreach (var number in stack)
            {
                min = Math.Min(min, number);
            }
            return min;
        }
    }
}
