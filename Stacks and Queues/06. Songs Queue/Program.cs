using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            var queue = new Queue<string>(input);
            while (queue.Count > 0)
            {
                string[] cmd = Console.ReadLine().Split(" ");
                if (cmd[0] == "Play")
                {
                    queue.Dequeue();
                }
                else if(cmd[0] == "Add")
                {
                    string song = string.Join(" ",cmd.Skip(1));
                    if(!queue.Contains(song))
                        queue.Enqueue(song);
                    else Console.WriteLine($"{song} is already contained!");
                }
                else if(cmd[0] == "Show")
                {
                    string[] array = queue.ToArray();
                    Console.WriteLine(string.Join(", ", array));
                }
                
            }
            Console.WriteLine("No more songs!");
        }
    }
}
