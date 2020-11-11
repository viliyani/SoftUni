using System;

namespace ExceptionHandling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                int num1, num2;
                byte result;

                num1 = 30;
                num2 = 60;

                result = Convert.ToByte(num1 * num2);

                Console.WriteLine($"{0} x {1} = {2}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception!");
            }
        }
    }
}
