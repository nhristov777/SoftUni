using System;

namespace TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string vehicle = Console.ReadLine();
            int passed = 0;
            var queue = new Queue<string>();

            while(vehicle != "end")
            {
                if(vehicle != "green") queue.Enqueue(vehicle);
                else
                {
                    for (int i = 1; i <= n; i++)
                    {
                        if (queue.Count == 0) break;
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        passed++;
                    }
                }
                vehicle = Console.ReadLine();
            }
            Console.WriteLine($"{passed} cars passed the crossroads.");
        }
    }
}