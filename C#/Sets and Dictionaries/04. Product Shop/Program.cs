using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sex
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var market = new Dictionary<string, Dictionary<string, double>>();

            while (input != "Revision")
            {
                //shop product price
                string[] info = input.Split(", ");
                string marketName = info[0];
                string marketProduct = info[1];
                double price = double.Parse(info[2]);

                if (!market.ContainsKey(marketName))
                {
                    market.Add(marketName, new Dictionary<string, double>());
                    market[marketName].Add(marketProduct, price);
                }
                else
                    market[marketName][marketProduct] = price;
                input = Console.ReadLine();
            }
            market = market.OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            foreach (var shop in market)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
            }
        }
    }
}
