using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage
{
    public class Citizen : IBuyer
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
        public string BirthDate { get; set; }
        public int Food { get; set; }

        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Id = id;
            Age = age;
            BirthDate = birthdate;
            Food = 0;
        }

        public void BuyFood()
        { Food += 10; }

    }
}
