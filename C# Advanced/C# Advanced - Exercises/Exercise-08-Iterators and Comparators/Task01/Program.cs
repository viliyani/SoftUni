using System;
using System.Linq;

namespace Iterators
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ListyIterator<string> list;

            string input = Console.ReadLine();

            string[] options = input.Split();

            if (options.Length > 1)
            {
                list = new ListyIterator<string>(options.Skip(1).ToArray());
            }
            else
            {
                list = new ListyIterator<string>();
            }

            while ((input = Console.ReadLine()) != "END")
            {
                try
                {
                    if (input == "Move")
                    {
                        Console.WriteLine(list.Move());
                    }
                    else if (input == "Print")
                    {
                        list.Print();
                    }
                    else if (input == "HasNext")
                    {
                        Console.WriteLine(list.HasNext());
                    }
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
            }



        }
    }
}
