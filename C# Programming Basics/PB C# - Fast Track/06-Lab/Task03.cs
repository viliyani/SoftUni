using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int num;
            int sum = 0;

            while (true)
            {
                input = Console.ReadLine();
                if (input == "Stop")
                {
                    Console.WriteLine(sum);
                    break;
                }
                else
                {
                    num = int.Parse(input);
                    sum += num;
                }
            }
        }
    }
}