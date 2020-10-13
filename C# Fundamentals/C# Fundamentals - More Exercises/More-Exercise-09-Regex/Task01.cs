using System;
using System.Text.RegularExpressions;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++)
            {
                string ticket = input[i];

                if (ticket.Length == 20)
                {
                    string leftHalf = ticket.Substring(0, 10);
                    string rightHalf = ticket.Substring(10, 10);

                    string pattern1 = @"(?<symbol>[@#$^]{6,})";
                    var match1 = Regex.Match(leftHalf, pattern1);

                    string pattern2 = @"(?<symbol>[@#$^]{6,})";
                    var match2 = Regex.Match(rightHalf, pattern2);

                    if ((match1.Success && match2.Success) && (match1.Groups["symbol"].Value == match2.Groups["symbol"].Value) && (match1.Groups["symbol"].Value.Length == match2.Groups["symbol"].Value.Length))
                    {
                        int winLength = match1.Groups["symbol"].Value.Length;
                        string winSymbol = match1.Groups["symbol"].Value;
                        if (winLength == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {winLength}{winSymbol[0]} Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {winLength}{winSymbol[0]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
