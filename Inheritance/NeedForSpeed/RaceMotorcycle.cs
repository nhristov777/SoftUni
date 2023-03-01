using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        public RaceMotorcycle(int hp, double fuel)
            : base(hp, fuel)
        {
            FuelConsumption = 8;
        }
    }
}
