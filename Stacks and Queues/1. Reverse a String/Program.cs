using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantExhibition
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();
            string text = Console.ReadLine();
            foreach (var item in text) stack.Push(item);
            while (stack.Count > 0) Console.Write(stack.Pop());
        }
    }
}
