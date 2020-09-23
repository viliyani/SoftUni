using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());

                Console.WriteLine("{0:F3}", (side * side));
            }
            else if (figure == "rectangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());

                Console.WriteLine("{0:F3}", (side1 * side2));
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                Console.WriteLine("{0:F3}", (Math.PI * radius * radius));
            }
            else if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                Console.WriteLine("{0:F3}", (0.5 * side * height));
            }
        }
    }
}