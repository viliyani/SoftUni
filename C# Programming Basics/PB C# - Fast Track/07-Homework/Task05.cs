using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    for (int k = 'a'; k < 'a' + l; k++)
                    {
                        for (int p = 'a'; p < 'a' + l; p++)
                        {
                            for (int t = 1; t <= n; t++)
                            {
                                if (t > i && t > j)
                                {
                                    char position3 = (char)k;
                                    char position4 = (char)p;
                                    Console.Write("{0}{1}{2}{3}{4} ", i, j, position3, position4, t);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}