using System;

namespace ExceptionHandling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine(Math.Sqrt(number));
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good Bye");
            }

        }
    }
}
