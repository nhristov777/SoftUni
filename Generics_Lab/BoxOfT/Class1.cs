using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
        private int count;
        private List<T> list;
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
            T removed = list[list.Count - 1];
            list.Remove(removed);
            return removed;
        }
    }
}
