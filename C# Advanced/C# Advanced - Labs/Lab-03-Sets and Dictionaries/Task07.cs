using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "PARTY")
                {
                    break;
                }

                int number;

                if (int.TryParse(input[0].ToString(), out number))
                {
                    vipGuests.Add(input);
                }
                else
                {
                    regularGuests.Add(input);
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                int number;

                if (int.TryParse(input[0].ToString(), out number))
                {
                    vipGuests.Remove(input);
                }
                else
                {
                    regularGuests.Remove(input);
                }
            }
            Console.WriteLine($"{vipGuests.Count + regularGuests.Count}");
            if (vipGuests.Count > 0)
            {
                Console.WriteLine(String.Join(Environment.NewLine, vipGuests));
            }
            if (regularGuests.Count > 0)
            {
                Console.WriteLine(String.Join(Environment.NewLine, regularGuests));
            }
        }
    }
}
