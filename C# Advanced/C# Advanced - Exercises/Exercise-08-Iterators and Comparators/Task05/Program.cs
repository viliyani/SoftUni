using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] options = input.Split();

                people.Add(new Person(options[0], int.Parse(options[1]), options[2]));
            }

            int idx = int.Parse(Console.ReadLine()) - 1;

            int countMatches = 0;
            int countNotMatches = 0;

            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].CompareTo(people[idx]) == 0)
                {
                    countMatches++;
                }
                else
                {
                    countNotMatches++;
                }
            }

            int total = countMatches + countNotMatches;

            if (total <= 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{countMatches} {countNotMatches} {total}");
            }
        }
    }
}
