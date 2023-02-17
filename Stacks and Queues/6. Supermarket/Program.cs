using System;

namespace Queueing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var queue = new Queue<string>();

            while(input != "End")
            {
                if(input != "Paid")
                    queue.Enqueue(input);
                else
                {
                    while(queue.Count > 0)
                        Console.WriteLine(queue.Dequeue());
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
