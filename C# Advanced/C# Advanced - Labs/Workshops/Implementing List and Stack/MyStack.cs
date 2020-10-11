using System;

namespace ImplementingDataStructures
{
    public class MyStack
    {
        private int[] data;
        private int capacity;

        public MyStack() : this(4)
        {
        }

        public MyStack(int capacity)
        {
            this.data = new int[capacity];
            this.capacity = capacity;
        }

        public int Count { get; private set; }

        public void Push(int number)
        {
            if (this.Count == this.capacity)
            {
                this.Resize();
            }
            this.data[this.Count++] = number;
        }

        public int Pop()
        {
            this.ValidateIsEmpty();
            return this.data[(this.Count--) - 1];
        }

        public int Peek()
        {
            this.ValidateIsEmpty();
            return this.data[this.Count - 1];
        }

        public void Clear()
        {
            this.data = new int[this.capacity];
        }

        public void Print()
        {
            for (int i = 0; i < this.Count; i++)
            {
                Console.Write(this.data[i] + " ");
            }
            Console.WriteLine();
        }

        public void ForEach(Action<int> action)
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                action(this.data[i]);
            }
        }

        private void Resize()
        {
            this.capacity *= 2;

            int[] newData = new int[this.capacity];

            for (int i = 0; i < this.Count; i++)
            {
                newData[i] = data[i];
            }

            this.data = newData;
        }

        private void ValidateIsEmpty()
        {
            if (this.Count == 0)
            {
                throw new Exception("Stack is empty");
            }
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                var message = this.Count == 0
                    ? "The stack is empty"
                    : $"The stack has {this.Count} elements";

                throw new Exception($"Index out of range. {message}.");
            }
        }

    }
}
