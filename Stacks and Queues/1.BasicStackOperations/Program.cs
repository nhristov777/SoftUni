using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //N push, S pop, X search
            var stack = new Stack<int>();
            int[] commands = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int push = commands[0];
            int pop = commands[1];
            int search = commands[2];
            
            foreach (int number in numbers) stack.Push(number);
            for (int i = 1; i <= pop; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(search)) Console.WriteLine("true");
            else Console.WriteLine(SmallestNumber(stack));
        }
        public static int SmallestNumber(Stack<int> stack)
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
