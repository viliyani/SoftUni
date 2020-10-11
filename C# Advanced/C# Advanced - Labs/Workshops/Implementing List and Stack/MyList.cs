using System;

namespace ImplementingDataStructures
{
    public class MyList<T>
    {
        private T[] data;
        private int capacity;

        public MyList() : this(4)
        {
        }

        public MyList(int capacity)
        {
            this.data = new T[capacity];
            this.capacity = capacity;
        }

        public int Count { get; private set; }

        public void Add(T number)
        {
            if (this.Count >= this.capacity)
            {
                this.Resize();
            }

            data[this.Count++] = number;
        }

        public void Clear()
        {
            this.Count = 0;
            this.data = new T[this.capacity];
        }

        public T RemoveAt(int index)
        {
            this.ValidateIndex(index);

            T element = this.data[index];

            for (int i = index; i < this.Count - 1; i++)
            {
                this.data[i] = this.data[i + 1];
            }

            this.Count--;

            return element;
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.data[i].Equals(element))
                {
                    return true;
                }
            }

            return false;
        }

        public void Swap(int index1, int index2)
        {
            this.ValidateIndex(index1);
            this.ValidateIndex(index2);

            T temp = this.data[index1];
            this.data[index1] = this.data[index2];
            this.data[index2] = temp;
        }

        public void InsertAt(int index, T number)
        {
            this.ValidateIndex(index);

            if (this.Count + 1 >= this.capacity)
            {
                this.Resize();
            }

            for (int i = this.Count; i >= index + 1; i--)
            {
                this.data[i] = this.data[i - 1];
            }

            this.data[index] = number;
            this.Count++;
        }

        public void Print()
        {
            for (int i = 0; i < this.Count; i++)
            {
                Console.Write(this.data[i] + " ");
            }
            Console.WriteLine();
        }

        public T this[int index]
        {
            get
            {
                this.ValidateIndex(index);

                return this.data[index];
            }
            set
            {
                this.ValidateIndex(index);

                this.data[index] = value;
            }
        }

        private void Resize()
        {
            this.capacity *= 2;

            T[] newData = new T[this.capacity];

            for (int i = 0; i < this.Count; i++)
            {
                newData[i] = data[i];
            }

            this.data = newData;
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                var message = this.Count == 0
                    ? "The list is empty"
                    : $"The list has {this.Count} elements and it is zero-based";

                throw new Exception($"Index out of range. {message}.");
            }
        }
    }
}
