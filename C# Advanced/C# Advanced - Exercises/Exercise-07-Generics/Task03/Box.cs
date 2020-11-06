using System;
using System.Collections.Generic;

namespace GenericsExercise
{
    public class Box<T>
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
    }
}
