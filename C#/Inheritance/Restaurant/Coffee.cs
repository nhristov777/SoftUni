using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        public double Caffeine { get; set; }
        public double CoffeeMilliliters
        { get; set; } = 50;
        public decimal CoffeePrice { get; set; } = 3.50M;
        public Coffee(string name, double caffeine)
            : base(name, 0, 0)
        {
            this.Caffeine = caffeine;
        }
    }
}
