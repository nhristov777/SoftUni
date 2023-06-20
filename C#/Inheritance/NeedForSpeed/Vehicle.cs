using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private double defaultFuelConsumption;
        private double fuelConsumption = 1.25;//virtual
        private double fuel;
        private int horsePower;
        public int HorsePower { get { return horsePower; } set { horsePower = value; } }
        public double Fuel { get { return fuel; } set { fuel = value; } }
        public virtual double FuelConsumption 
        { get { return fuelConsumption; } set { fuelConsumption = value; } }
        public double DefaultFuelConsumption
        { get { return defaultFuelConsumption; } set { defaultFuelConsumption = value; } }
        public Vehicle(int horsePower, double fuel)
        {
            this.horsePower = horsePower;
            this.fuel = fuel;
        }
        public virtual void Drive(double km)
        {
            fuel -= fuelConsumption * km;
        }
    }
}
