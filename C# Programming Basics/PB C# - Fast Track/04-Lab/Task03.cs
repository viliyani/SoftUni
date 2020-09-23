using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            char gender = Console.ReadLine()[0];

            if (gender == 'm')
            {
                if (age >= 16)
                {
                    Console.WriteLine("Mr.");
                }
                else
                {
                    Console.WriteLine("Master");
                }
            }

            if (gender == 'f')
            {
                if (age >= 16)
                {
                    Console.WriteLine("Ms.");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
            }
        }
    }
}