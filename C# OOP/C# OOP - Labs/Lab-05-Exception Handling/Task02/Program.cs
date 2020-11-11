using System;

namespace ExceptionHandling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    int number = ReadNumber(1, 100);

                    Console.WriteLine($"Number is: {number}");
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"Invalid number: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Good Bye");
            }

        }

        public static int ReadNumber(int start, int end)
        {
            int n = int.Parse(Console.ReadLine());

            if (!(n >= start && n <= end))
            {
                throw new ArgumentOutOfRangeException($"{n} is out of the range!");
            }

            return n;
        }
    }
}
