using System;
using System.Text.RegularExpressions;

namespace Telephony
{
    public class Smartphone : ICallable, IBroweserable
    {

        public Smartphone()
        {

        }

        public void Call(string number)
        {
            var match = Regex.Match(number, @"^[0-9]*$");

            if (match.Success)
            {
                Console.WriteLine($"Calling: {number}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }

        public void BrowseWeb(string url)
        {
            var match = Regex.Match(url, @"[0-9]{1}");

            if (!match.Success)
            {
                Console.WriteLine($"Browsing: {url}");
            }
            else
            {
                Console.WriteLine("Invalid url!");
            }
        }


    }
}
