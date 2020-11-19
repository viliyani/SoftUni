using System;
using System.Text.RegularExpressions;

namespace Telephony
{
    public class StationaryPhone : ICallable
    {
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
    }
}
