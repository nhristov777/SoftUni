using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSwapInt
{
    public class Box<T> where T : IComparable
    {
        private int count;
        private readonly List<T> list;
        public int Count { get { return this.count; } }

        public Box()
        {
            count = 0;
            list = new List<T>();
        }
        public void Add(T element)
        {
            count++;
            list.Add(element);
        }
        public T Remove()
        {
            count--;
            T removed = list[^1];
            list.Remove(removed);
            return removed;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (T item in list)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }

            return sb.ToString();
        }
        public int Compare(T compare)
        {
            int counter = 0;
            foreach (T item in list)
            {
                if (item.CompareTo(compare) > 0) counter++;
            }
            return counter;
        }
        public void Swap(int first, int second)
        {
            (list[first], list[second]) = (list[second], list[first]);
        }
    }
}
