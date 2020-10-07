using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.None)
                .Select(double.Parse)
                .ToList()
                .ForEach(Proccess);
        }

        static void Proccess(double num)
        {
            num += num * 0.2;
            Console.WriteLine($"{num:f2}");
        }
    }
}
