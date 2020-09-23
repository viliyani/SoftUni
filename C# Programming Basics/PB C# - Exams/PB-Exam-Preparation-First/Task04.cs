using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            int musalaPeople = 0;
            int monblanPeople = 0;
            int kilimanPeople = 0;
            int ktwoPeople = 0;
            int everestPeople = 0;

            for (int i = 0; i < groups; i++)
            {
                int groupSize = int.Parse(Console.ReadLine());

                if (groupSize <= 5)
                {
                    musalaPeople += groupSize;
                }
                else if (groupSize >= 6 && groupSize <= 12)
                {
                    monblanPeople += groupSize;
                }
                else if (groupSize >= 13 && groupSize <= 25)
                {
                    kilimanPeople += groupSize;
                }
                else if (groupSize >= 26 && groupSize <= 40)
                {
                    ktwoPeople += groupSize;
                }
                else if (groupSize >= 41)
                {
                    everestPeople += groupSize;
                }
            }

            int total = musalaPeople + monblanPeople + kilimanPeople + ktwoPeople + everestPeople;

            double musalaPercent = musalaPeople * 1.0 / total * 100;
            double monblanPercent = monblanPeople * 1.0 / total * 100;
            double kilimanPercent = kilimanPeople * 1.0 / total * 100;
            double ktwoPercent = ktwoPeople * 1.0 / total * 100;
            double everestPercent = everestPeople * 1.0 / total * 100;

            Console.WriteLine($"{musalaPercent:f2}");
            Console.WriteLine($"{monblanPercent:f2}");
            Console.WriteLine($"{kilimanPercent:f2}");
            Console.WriteLine($"{ktwoPercent:f2}");
            Console.WriteLine($"{everestPercent:f2}");
        }
    }
}