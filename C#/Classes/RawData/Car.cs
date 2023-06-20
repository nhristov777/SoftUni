using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    internal class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tire[] tires;
        public string Model { get { return model; } set { model = value; } }
        public Engine Engine { get { return engine; } set { engine = value; } }
        public Cargo Cargo { get { return cargo; } set { cargo = value; } }
        public Tire[] Tires { get { return tires; } set { tires = value; } }

        public Car(string model, int speed, int power, int weight, string type
            , double pressure1, int age1, double pressure2, int age2, double pressure3, int age3,
            double pressure4, int age4)
        {
            Model = model;
            Engine = new Engine(speed, power);
            Cargo = new Cargo(type, weight);
            Tires = new Tire[4]
            {
                new Tire(age1, pressure1),
                new Tire(age2, pressure2),
                new Tire(age3, pressure3),
                new Tire(age4, pressure4),
            };
        }
    }
}
