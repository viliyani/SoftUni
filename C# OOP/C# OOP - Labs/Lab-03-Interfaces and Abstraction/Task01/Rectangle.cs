using System;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void Draw()
        {
            for (int row = 0; row < Height; row++)
            {
                if (row == 0 || row == Height - 1)
                {
                    Console.WriteLine(new string('*', Width));
                }
                else
                {
                    for (int col = 0; col < Width; col++)
                    {
                        if (col == 0 || col == Width - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
