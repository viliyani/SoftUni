using System;
using System.Collections.Generic;

namespace Iterators
{
    public class ListyIterator<T>
    {
        private List<T> data;
        private int idx;

        public ListyIterator()
        {
            this.data = new List<T>();
            this.idx = 0;
        }

        public ListyIterator(params T[] elements) : this()
        {
            foreach (var el in elements)
            {
                this.data.Add(el);
            }
        }

        public bool Move()
        {
            if (this.idx + 1 == this.data.Count)
            {
                return false;
            }

            this.idx += 1;

            return true;
        }

        public bool HasNext()
        {
            if (this.idx + 1 == this.data.Count)
            {
                return false;
            }

            return true;
        }

        public void Print()
        {
            if (this.data.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(this.data[this.idx]);
        }

    }
}
