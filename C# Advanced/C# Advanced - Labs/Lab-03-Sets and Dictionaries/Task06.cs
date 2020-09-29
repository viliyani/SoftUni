using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> numbers = new HashSet<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] options = input.Split(new string[] { ", " }, StringSplitOptions.None);

                if (options[0] == "IN")
                {
                    numbers.Add(options[1]);
                }
                else if (options[0] == "OUT")
                {
                    numbers.Remove(options[1]);
                }

            }

            if (numbers.Count > 0)
            {
                foreach (var item in numbers)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine($"Parking Lot is Empty");
            }

        }
    }
}
