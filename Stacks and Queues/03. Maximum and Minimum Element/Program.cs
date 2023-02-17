using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] query = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                if (query[0] == 1)
                { stack.Push(query[1]); }
                else if (query[0] == 2)
                { if (stack.Count > 0) stack.Pop(); }
                else if (query[0] == 3)
                {
                    if (stack.Count > 0)
                        Console.WriteLine(BiggestNumber(stack));
                }
                else if (query[0] == 4)
                {
                    if (stack.Count > 0)
                        Console.WriteLine(SmallestNumber(stack));
                }
            }
            int[] toArray = stack.ToArray();
            Console.WriteLine(String.Join(", ", toArray));
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
        public static int BiggestNumber(Stack<int> stack)
        {
            int max = int.MinValue;
            foreach (var number in stack)
            {
                max = Math.Max(max, number);
            }
            return max;
        }
    }
}
