using System;

namespace GenericsExercise
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();

            box.Data.Add(3);
            box.Data.Add(4);
            box.Data.Add(5);
            box.Data.Add(6);

            box.Swap(1,2);

            box.Print();
        }
    }
}
