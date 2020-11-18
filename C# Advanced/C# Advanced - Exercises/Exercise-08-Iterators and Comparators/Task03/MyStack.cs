using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomStack
{
    public class MyStack : IEnumerable<int>
    {
        private List<int> data;
        private int index;

        public MyStack()
        {
            data = new List<int>();
            index = 0;
        }

        public void Push(int element)
        {
            data.Add(element);
            index++;
        }

        public int Pop()
        {
            int popElement = Peek();
            index--;

            return popElement;
        }

        public int Peek()
        {
            ValidateThereAreElements();

            return data[index - 1];
        }

        private void ValidateThereAreElements()
        {
            if (!HasElements())
            {
                throw new InvalidOperationException("There are no elements in the Stack!");
            }
        }

        public bool HasElements()
        {
            return index > 0;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = data.Count - 1; i >= 0; i--)
            {
                yield return data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
