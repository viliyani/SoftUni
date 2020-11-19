using System;
using System.Collections.Generic;

namespace BorderControl
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<IIdentifiable> list = new List<IIdentifiable>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] options = input.Split();

                if (options.Length == 3)
                {
                    list.Add(new Citizen(options[0], int.Parse(options[1]), options[2]));
                }
                else if (options.Length == 2)
                {
                    list.Add(new Robot(options[0], options[1]));
                }
            }

            string validEndsNumber = Console.ReadLine();

            foreach (var item in list)
            {
                if (item.ValidateId(validEndsNumber))
                {
                    Console.WriteLine(item.Id);
                }
            }

        }
    }
}
