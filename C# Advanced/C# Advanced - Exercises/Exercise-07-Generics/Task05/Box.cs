using System;
using System.Collections.Generic;

namespace GenericsExercise
{
    public class Box<T> where T : IComparable
    {
        public List<T> Data { get; set; }

        public Box()
        {
            this.Data = new List<T>();
        }

        public void Swap(int idx1, int idx2)
        {
            T temp = Data[idx1];
            Data[idx1] = Data[idx2];
            Data[idx2] = temp;
        }

        public void Print()
        {
            Console.WriteLine(String.Join(" ", this.Data));
        }

        public int CountGreater(T greater)
        {
            int counter = 0;

            foreach (var item in Data)
            {
                if (greater.CompareTo(item) > 0)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
