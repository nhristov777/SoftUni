﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfo
{
    internal class Citizen : IPerson
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Citizen(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
