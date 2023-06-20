using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelRate;
        private double distance;

        private List<Car> cars;

        public string Model { get { return model; } set { model = value; } }
        public double FuelAmount { get { return fuelAmount; } set { fuelAmount = value; } }
        public double FuelRate { get { return fuelRate; } set { fuelRate = value; } }
        public double Distance { get { return distance; } set { distance = value; } }

        public Car()
        {
            Distance = 0;
            cars = new List<Car>();
        }
        public Car(string model, double fuelAmount, double fuelConsumption) : this()
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelRate = fuelConsumption;
        }
    }
}
