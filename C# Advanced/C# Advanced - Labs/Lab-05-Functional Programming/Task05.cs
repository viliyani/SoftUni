using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);

                dict.Add(input[0], int.Parse(input[1]));
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            var filter = CreateFilter(condition, age);
            var write = CreateWriter(format);

            foreach (var item in dict)
            {
                if (filter(item.Value))
                {
                    write(item);
                }
            }
        }

        static Func<int, bool> CreateFilter(string condition, int compareAge)
        {
            if (condition == "older")
            {
                return x => x >= compareAge;
            }

            return x => x < compareAge;
        }

        static Action<KeyValuePair<string, int>> CreateWriter(string outputFormat)
        {
            switch (outputFormat)
            {
                case "name":
                    return x => Console.WriteLine(x.Key);
                case "age":
                    return x => Console.WriteLine(x.Value);
                default:
                    return x => Console.WriteLine($"{x.Key} - {x.Value}");
            }
        }

    }
}
