using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        private string name;
        private int age;
        public int Age { get { return age; } set { age = value; } }
        public string Name { get { return name; } set { name = value; } }
        public Person(string name, int age)
        {
            this.name = name;
            this.age =  age;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new();
            stringBuilder.Append(String.Format("Name: {0}, Age: {1}",
                                 this.Name,
                                 this.Age));

            return stringBuilder.ToString();
        }

    }
}
