using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumPrime = 0;
            int sumNonPrime = 0;

            string input = Console.ReadLine();

            while (input != "stop")
            {
                int currentNum = int.Parse(input);

                if (currentNum < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    // Is Prime
                    bool isPrime = true;
                    for (int i = 2; i < currentNum; i++)
                    {
                        if (currentNum % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime == true)
                    {
                        sumPrime += currentNum;
                    }
                    else
                    {
                        sumNonPrime += currentNum;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Sum of all prime numbers is: {0}", sumPrime);
            Console.WriteLine("Sum of all non prime numbers is: {0}", sumNonPrime);
        }
    }
}