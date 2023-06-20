using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantExhibition
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();

            int startIndex = 0;
            int endIndex = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                    stack.Push(i);
                else if (input[i] == ')')
                {
                    endIndex = i;
                    startIndex = stack.Pop();
                    string substring = input.Substring(startIndex, endIndex - startIndex + 1);
                    Console.WriteLine(substring);
                }
            }
        }
    }
}
