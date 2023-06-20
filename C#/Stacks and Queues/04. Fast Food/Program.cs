using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var stack = new Stack<int>();
            stack.Push(food);
            int completed = 0;
            int ordersLeft = 0;
            for(int i = 0; i < orders.Length; i++)
            {
                int amount = stack.Peek();
                if (amount >= orders[i])
                {
                    amount -= orders[i];
                    stack.Pop();
                    stack.Push(amount);
                    completed++;
                }
                else { ordersLeft = i; break; }
            }
            Console.WriteLine(BiggestNumber(orders));
            if(completed == orders.Length)
                Console.WriteLine("Orders complete.");
            else
            {
                Console.Write("Orders left: ");
                for (int i = ordersLeft; i < orders.Length; i++)
                {
                    Console.Write(orders[i] + " ");
                }
            }
        }
        public static int BiggestNumber(int[] array)
        {
            int max = int.MinValue;
            foreach (var number in array)
            {
                max = Math.Max(max, number);
            }
            return max;
        }
    }
}
