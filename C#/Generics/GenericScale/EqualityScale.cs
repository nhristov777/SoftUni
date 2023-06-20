using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericScale
{
    public class EqualityScale<T> where T : IComparable<T>
    {
        private readonly T left;
        private readonly T right;

        public EqualityScale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }

        public bool AreEqual()
        {
            if (left.CompareTo(right) == 0)
            { return true; }
            return false;
        }
    }
}
