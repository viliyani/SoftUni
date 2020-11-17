﻿using System;

namespace BoxData
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            try
            {
                Box box = new Box(length, width, height);

                Console.WriteLine($"Surface Area - {box.CalcSurfaceArea():f2}");
                Console.WriteLine($"Lateral Surface Area - {box.CalcLateralSurfaceArea():f2}");
                Console.WriteLine($"Volume - {box.CalcVolume():f2}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
