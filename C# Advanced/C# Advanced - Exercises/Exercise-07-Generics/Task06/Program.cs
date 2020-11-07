using System;

namespace GenericsExercise
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<double> box = new Box<double>();

            box.Data.Add(3.14);
            box.Data.Add(4.45);
            box.Data.Add(5.24);
            box.Data.Add(6.53);

            box.Swap(1,2);

            Console.WriteLine(box.CountGreater(1));
        }
    }
}
