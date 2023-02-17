using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Tire
    {
        private int age;
        private double pressure;
        private Tire[] tires;

        public int Age{ get { return age; } set { age = value; } }
        public double Pressure { get { return pressure; } set { pressure = value; } }
        public Tire[] Tires { get { return tires; } set { tires = value; } }

        public Tire(int year, double pressure)
        {
            this.Pressure = pressure;
            this.Age = year;
        }
    }
}
