using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string maxName = "";
            int maxPoints = int.MinValue;

            string movie = Console.ReadLine();

            int counter = 0;

            while (movie != "STOP")
            {
                int currentPoints = 0;

                for (int i = 0; i < movie.Length; i++)
                {
                    if (movie[i] >= 'A' && movie[i] <= 'Z')
                    {
                        currentPoints += movie[i] - movie.Length;
                    }
                    else if (movie[i] >= 'a' && movie[i] <= 'z')
                    {
                        currentPoints += movie[i] - (movie.Length * 2);
                    }
                    else
                    {
                        currentPoints += movie[i];
                    }
                }

                if (currentPoints > maxPoints)
                {
                    maxName = movie;
                    maxPoints = currentPoints;
                }

                counter++;
                if (counter >= 7)
                {
                    Console.WriteLine("The limit is reached.");
                    break;
                }

                movie = Console.ReadLine();
            }

            Console.WriteLine($"The best movie for you is {maxName} with {maxPoints} ASCII sum.");
        }
    }
}