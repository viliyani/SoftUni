using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Party!")
            {
                string[] options = input.Split();

                if (options[0] == "Remove")
                {
                    if (options[1] == "StartsWith")
                    {
                        names.RemoveAll(name => name.StartsWith(options[2]));
                    }
                    else if (options[1] == "EndsWith")
                    {
                        names.RemoveAll(name => name.EndsWith(options[2]));
                    }
                    else if (options[1] == "Length")
                    {
                        names.RemoveAll(name => name.Length == int.Parse(options[2]));
                    }
                }
                else if (options[0] == "Double")
                {
                    if (options[1] == "StartsWith")
                    {
                        names.AddRange(names.Where(name => name.StartsWith(options[2])).ToList());
                    }
                    else if (options[1] == "EndsWith")
                    {
                        names.AddRange(names.Where(name => name.EndsWith(options[2])).ToList());
                    }
                    else if (options[1] == "Length")
                    {
                        names.AddRange(names.Where(name => name.Length == int.Parse(options[2])).ToList());
                    }
                }
            }

            if (names.Count > 0)
            {
                Console.WriteLine($"{String.Join(", ", names.OrderBy(x => x))} are going to the party!");
            }
            else
            {
                Console.WriteLine($"Nobody is going to the party!");
            }

        }
    }
}
