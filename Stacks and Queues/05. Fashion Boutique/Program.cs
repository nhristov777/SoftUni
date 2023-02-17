using System;
using System.Linq;
using System.Collections.Generic;
namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int rackSize = int.Parse(Console.ReadLine());
            int currentRack = 0;
            int racks = 1;
            var stack = new Stack<int>(clothes.Reverse());

            while(stack.Count > 0)
            {
                currentRack += stack.Peek();
                if (currentRack < rackSize)
                { stack.Pop(); }
                else if (currentRack == rackSize)
                {
                    currentRack = stack.Pop();
                    racks++;
                }
                else//dont add to currRack, take new rack
                {
                    currentRack = stack.Pop();
                    racks++;
                }
            }
            Console.WriteLine(racks);
        }
    }
}
