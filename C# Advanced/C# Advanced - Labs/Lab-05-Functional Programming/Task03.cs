using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> check = WordCheck;

            List<string> words = Console.ReadLine()
                .Split()
                .Where(check)
                .ToList();

            Console.WriteLine(String.Join(Environment.NewLine, words));
        }

        static bool WordCheck(string str)
        {
            if (str[0] >= 'A' && str[0] <= 'Z')
            {
                return true;
            }
            return false;
        }

    }
}
