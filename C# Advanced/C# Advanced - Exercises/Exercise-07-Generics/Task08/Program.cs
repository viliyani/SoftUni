using System;
using System.Collections.Generic;

namespace GenericsExercise
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Tupple<string, int, double> person = new Tupple<string, int, double>("Peter", 32, 3.14);

            Console.WriteLine(person.Item1);
            Console.WriteLine(person.Item2);
            Console.WriteLine(person.Item3);
        }
    }
}
