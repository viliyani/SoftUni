using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterators
{
    public class ListyIterator<T> : IEnumerable<T>
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
            if (this.HasNext())
            {
                this.idx++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            return this.idx + 1 < this.data.Count;
        }

        public void Print()
        {
            ValidateThereAreItems();

            Console.WriteLine(this.data[this.idx]);
        }

        public void PrintAll()
        {
            ValidateThereAreItems();

            foreach (var item in this.data)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }

        private void ValidateThereAreItems()
        {
            if (this.data.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.data.Count; i++)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
