using System;

namespace BoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get
            {
                return length;
            }
            private set
            {
                ValidateSide(value, nameof(Length));
                length = value;
            }
        }

        public double Width
        {
            get
            {
                return width;
            }
            private set
            {
                ValidateSide(value, nameof(Width));
                width = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            private set
            {
                ValidateSide(value, nameof(Height));
                height = value;
            }
        }

        public double CalcSurfaceArea()
        {
            return (2 * length * width) + (2 * length * height) + (2 * width * height);
        }

        public double CalcLateralSurfaceArea()
        {
            return (2 * length * height) + (2 * width * height);
        }

        public double CalcVolume()
        {
            return length * width * height;
        }

        public void ValidateSide(double side, string paramName)
        {
            if (side <= 0)
            {
                throw new ArgumentException($"{paramName} cannot be zero or negative.");
            }
        }
    }
}
