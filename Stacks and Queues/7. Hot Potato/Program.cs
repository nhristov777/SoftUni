using System;

namespace HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(Console.ReadLine());
            var queue = new Queue<string>(names);

            while(queue.Count > 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    if(i == n)
                        Console.WriteLine($"Removed {queue.Dequeue()}");
                    else 
                        queue.Enqueue(queue.Dequeue());
                }
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}