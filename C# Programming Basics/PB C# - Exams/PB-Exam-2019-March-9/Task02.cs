using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string match1 = Console.ReadLine();
            string match2 = Console.ReadLine();
            string match3 = Console.ReadLine();

            int wins = 0;
            int losts = 0;
            int drawns = 0;

            if (Convert.ToInt32(match1[0]) > Convert.ToInt32(match1[2]))
            {
                wins++;
            }
            else if (Convert.ToInt32(match1[0]) < Convert.ToInt32(match1[2]))
            {
                losts++;
            }
            else if (Convert.ToInt32(match1[0]) == Convert.ToInt32(match1[2]))
            {
                drawns++;
            }

            if (Convert.ToInt32(match2[0]) > Convert.ToInt32(match2[2]))
            {
                wins++;
            }
            else if (Convert.ToInt32(match2[0]) < Convert.ToInt32(match2[2]))
            {
                losts++;
            }
            else if (Convert.ToInt32(match2[0]) == Convert.ToInt32(match2[2]))
            {
                drawns++;
            }

            if (Convert.ToInt32(match3[0]) > Convert.ToInt32(match3[2]))
            {
                wins++;
            }
            else if (Convert.ToInt32(match3[0]) < Convert.ToInt32(match3[2]))
            {
                losts++;
            }
            else if (Convert.ToInt32(match3[0]) == Convert.ToInt32(match3[2]))
            {
                drawns++;
            }

            // Print result
            Console.WriteLine("Team won {0} games.", wins);
            Console.WriteLine("Team lost {0} games.", losts);
            Console.WriteLine("Drawn games: {0}", drawns);
        }
    }
}