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
            List<string> filters = new List<string>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Print")
            {
                string[] options = input.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

                if (options[0] == "Add filter")
                {
                    filters.Add($"{options[1]};{options[2]}");
                }
                else if (options[0] == "Remove filter")
                {
                    filters.Remove($"{options[1]};{options[2]}");
                }
            }

            foreach (var filter in filters)
            {
                string[] options = filter.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

                if (options[0] == "Starts with")
                {
                    names.RemoveAll(name => name.StartsWith(options[1]));
                }
                else if (options[0] == "Ends with")
                {
                    names.RemoveAll(name => name.EndsWith(options[1]));
                }
                else if (options[0] == "Length")
                {
                    names.RemoveAll(name => name.Length == int.Parse(options[1]));
                }
                else if (options[0] == "Contains")
                {
                    names.RemoveAll(name => name.Contains(options[1]));
                }
            }

            Console.WriteLine(String.Join(" ", names));
        }
    }
}
