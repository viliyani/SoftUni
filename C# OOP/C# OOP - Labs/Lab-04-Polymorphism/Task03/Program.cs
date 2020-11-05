using System;

namespace Shapess
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Shape circle = new Circle(2);
            Shape rectangle = new Rectangle(3,4);

            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(rectangle.CalculateArea());

            Console.WriteLine(circle.Draw());
            Console.WriteLine(rectangle.Draw());
        }
    }
}
