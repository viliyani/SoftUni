using System;

namespace ExceptionHandling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                string[] weekendDays = new string[2];
                weekendDays[0] = "Saturday";
                weekendDays[1] = "Sunday";

                for (int i = 0; i <= 2; i++)
                {
                    Console.WriteLine(weekendDays[i].ToString());
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index is out of range!");
            }
        }
    }
}
