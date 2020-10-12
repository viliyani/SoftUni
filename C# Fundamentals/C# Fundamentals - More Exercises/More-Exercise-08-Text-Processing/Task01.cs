using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                string input = Console.ReadLine();

                bool hasPerson = true;

                int idxNameStart = input.IndexOf('@');
                int idxNameEnd = input.IndexOf('|');
                string name = String.Empty;

                if (idxNameStart != -1 && idxNameEnd != -1)
                {
                    name = input.Substring(idxNameStart + 1, idxNameEnd - idxNameStart - 1);
                }
                else
                {
                    hasPerson = false;
                }

                int idxAgeStart = input.IndexOf('#');
                int idxAgeEnd = input.IndexOf('*');
                string age = String.Empty;

                if (idxAgeStart != -1 && idxAgeEnd != -1)
                {
                    age = input.Substring(idxAgeStart + 1, idxAgeEnd - idxAgeStart - 1);
                }
                else
                {
                    hasPerson = false;
                }

                if (hasPerson)
                {
                    Console.WriteLine($"{name} is {age} years old.");
                }
            }

        }
    }
}
