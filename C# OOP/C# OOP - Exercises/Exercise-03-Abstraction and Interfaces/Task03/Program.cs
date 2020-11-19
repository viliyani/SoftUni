using System;

namespace Telephony
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            string[] urls = Console.ReadLine().Split();

            var lg = new Smartphone();

            foreach (var number in numbers)
            {
                lg.Call(number);
            }

            foreach (var url in urls)
            {
                lg.BrowseWeb(url);
            }
        }
    }
}
