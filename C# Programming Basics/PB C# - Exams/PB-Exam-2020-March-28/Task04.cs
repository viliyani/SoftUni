using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            int musala = 0;
            int monblan = 0;
            int kilin = 0;
            int k2 = 0;
            int everest = 0;

            for (int i = 0; i < groups; i++)
            {
                int groupSize = int.Parse(Console.ReadLine());

                if (groupSize <= 5)
                {
                    musala += groupSize;
                }
                else if (groupSize <= 12)
                {
                    monblan += groupSize;
                }
                else if (groupSize <= 25)
                {
                    kilin += groupSize;
                }
                else if (groupSize <= 40)
                {
                    k2 += groupSize;
                }
                else if (groupSize > 40)
                {
                    everest += groupSize;
                }
            }

            int total = musala + monblan + kilin + k2 + everest;

            Console.WriteLine($"{musala * 1.0 / total * 100:f2}%");
            Console.WriteLine($"{monblan * 1.0 / total * 100:f2}%");
            Console.WriteLine($"{kilin * 1.0 / total * 100:f2}%");
            Console.WriteLine($"{k2 * 1.0 / total * 100:f2}%");
            Console.WriteLine($"{everest * 1.0 / total * 100:f2}%");
        }
    }
}