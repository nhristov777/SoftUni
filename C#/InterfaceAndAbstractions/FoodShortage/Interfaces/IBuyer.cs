using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage
{
    public interface IBuyer
    {
        int Food { get; set; }
        string Name { get; set; }
        void BuyFood();
    }
}
