using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantExhibition
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            foreach (var item in numbers)
            {
                stack.Push(item);
            }
            while (input.ToLower() != "end")
            {
                string[] cmd = input.Split(' ');
                if (cmd[0].ToLower() == "add")
                {
                    int n1 = int.Parse(cmd[1]);
                    int n2 = int.Parse(cmd[2]);
                    stack.Push(n1);
                    stack.Push(n2);
                }
                else if (cmd[0].ToLower() == "remove")
                {
                    int count = int.Parse(cmd[1]);
                    if (count <= stack.Count)
                        for (int i = 0; i < count; i++)
                            stack.Pop();
                }
                input = Console.ReadLine();
            }
            int sum = 0;
            while (stack.Count > 0)
                sum += stack.Pop();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
