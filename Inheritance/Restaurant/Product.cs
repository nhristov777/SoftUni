using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Product
    {
        public virtual decimal Price { get; set; }
        public virtual string Name { get; set; }
        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
