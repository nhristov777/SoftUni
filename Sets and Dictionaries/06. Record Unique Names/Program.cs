﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sex
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();
            for (int i = 0; i < count; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }
            foreach (var name in names)
                Console.WriteLine(name);
        }
    }
}