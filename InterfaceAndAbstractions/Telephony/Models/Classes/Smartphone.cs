using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowse
    {
        public string Browse(string url)
        {
            if(!ValidURL(url))
            { return "Invalid URL!"; }
            return $"Browsing: {url}!";
        }
        public string Call(string number)
        {
            if (!ValidPhoneNumber(number))
            { return "Invalid number!"; }
            return $"Calling... {number}";
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
        private static bool ValidURL(string url)
        {
            foreach (var letter in url)
            {
                if (Char.IsDigit(letter))
                { return false; }
            }
            return true;
        }
    }
}
