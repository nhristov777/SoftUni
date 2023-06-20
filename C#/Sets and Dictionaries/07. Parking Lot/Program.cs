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
            HashSet<string> codes = new HashSet<string>();
            string input = Console.ReadLine();
            while (input != "END")
            {
                //direction, code
                string[] cmd = input.Split(", ");
                string direction = cmd[0];
                string code = cmd[1];

                if (direction == "IN")
                    codes.Add(code);
                else codes.Remove(code);

                input = Console.ReadLine();
            }
            if (codes.Count > 0)
                foreach (var code in codes)
                    Console.WriteLine(code);
            else Console.WriteLine("Parking Lot is Empty");
        }
    }
}
