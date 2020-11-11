using System;

namespace ExceptionHandling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                double number = Convert.ToDouble("string10.30");

                Console.WriteLine($"Number: {number}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception!");
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("InvalidCastException exception!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("OverflowException exception!");
            }
        }
    }
}
