using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());;

            int current = 1;
            bool flag = false;
            
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{current} ");
                    if (current >= n)
                    {
                        flag = true;
                        break;
                    }
                    current++;
                }

                Console.WriteLine();

                if (flag == true)
                {
                    break;
                }
            }
        }
    }
}