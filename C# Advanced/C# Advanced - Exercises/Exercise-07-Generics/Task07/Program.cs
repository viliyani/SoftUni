using System;
using System.Collections.Generic;

namespace GenericsExercise
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Tupple<string, int> person = new Tupple<string, int>("Peter", 32);

            Console.WriteLine(person.Item1);
            Console.WriteLine(person.Item2);
        }
    }
}
