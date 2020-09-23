using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int newMinutes = minutes + 15;
            int newHours = newMinutes / 60;

            newMinutes = newMinutes % 60;
            newHours = newHours + hours;

            newHours = newHours % 24;

            if (newMinutes < 10)
            {
                Console.WriteLine("{0}:0{1}", newHours, newMinutes);
            }
            else
            {
                Console.WriteLine("{0}:{1}", newHours, newMinutes);
            }
        }
    }
}