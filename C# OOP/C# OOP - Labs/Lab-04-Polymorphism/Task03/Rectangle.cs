﻿namespace Shapess
{
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * width + 2 * height;
        }

        public override double CalculateArea()
        {
            return width * height;
        }

        public override string Draw()
        {
            return "rectangle";
        }
    }
}
