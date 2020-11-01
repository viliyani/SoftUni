using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();

            DateModifier dateMod = new DateModifier();

            Console.WriteLine(dateMod.CalcDatesDiff(date1, date2));
        }
    }
}
