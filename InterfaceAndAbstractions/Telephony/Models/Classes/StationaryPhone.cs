using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class StationaryPhone : ICallable
    {
        public string Call(string number)
        {
            if (!ValidPhoneNumber(number))
            { return "Invalid number!"; }
            return $"Dialing... {number}";
        }

        private static bool ValidPhoneNumber(string number)
        {
            foreach (var digit in number)
            {
                if (!Char.IsDigit(digit))
                { return false; }
            }
            return true;
        }

    }
}
