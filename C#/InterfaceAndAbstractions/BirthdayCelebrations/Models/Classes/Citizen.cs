﻿using BirthdayCelebrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    public class Citizen : IIdentifiable, IBirthable
    {
        public string Id {get; private set;}
        public int Age { get; private set; }
        public string Name { get; private set; }
        public string Birthdate { get; private set; }
        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }
    }
}
