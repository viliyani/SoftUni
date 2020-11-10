using System;

namespace Inheritance
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine(new Person(name, age));
        }
    }
}
