using System;
using System.Collections.Generic;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();
            List<string> comments = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of comments")
                {
                    break;
                }

                comments.Add(input);
            }

            Console.WriteLine($"<h1>");
            Console.WriteLine($"\t{title}");
            Console.WriteLine($"</h1>");

            Console.WriteLine($"<article>");
            Console.WriteLine($"\t{content}");
            Console.WriteLine($"</article>");

            foreach (var comment in comments)
            {
                Console.WriteLine($"<div>");
                Console.WriteLine($"\t{comment}");
                Console.WriteLine($"</div>");
            }

        }
    }
}
