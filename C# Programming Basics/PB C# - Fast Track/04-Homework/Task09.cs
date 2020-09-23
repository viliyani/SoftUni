using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int examTimeHour = int.Parse(Console.ReadLine());
            int examTimeMin = int.Parse(Console.ReadLine());
            int arriveTimeHour = int.Parse(Console.ReadLine());
            int arriveTimeMin = int.Parse(Console.ReadLine());

            // Calculate hour and minutes - 30 minutes before the exam
            int beforeHour = 0;
            int beforeMin = 0;

            if (examTimeMin >= 30)
            {
                beforeHour = examTimeHour;
                beforeMin = examTimeMin - 30;
            }
            else
            {
                beforeHour = examTimeHour - 1;
                beforeMin = 60 - (30 - examTimeMin);
            }

            // Check Late
            if ((arriveTimeHour > examTimeHour))
            {
                Console.WriteLine("Late");

                int diffMin = arriveTimeMin - examTimeMin;

                if (diffMin >= 0)
                {
                    if (diffMin < 10)
                    {
                        Console.WriteLine("{0}:0{1} hours after the start", (arriveTimeHour - examTimeHour), diffMin);
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1} hours after the start", (arriveTimeHour - examTimeHour), diffMin);
                    }
                }
                else
                {
                    diffMin = Math.Abs(diffMin);

                    if (diffMin < 10)
                    {
                        Console.WriteLine("{0}:0{1} hours after the start", (arriveTimeHour - examTimeHour - 1), diffMin);
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1} hours after the start", (arriveTimeHour - examTimeHour - 1), diffMin);
                    }
                }
            }
            else if (arriveTimeHour == examTimeHour && arriveTimeMin > examTimeMin)
            {
                Console.WriteLine("Late");

                int diffMin = arriveTimeMin - examTimeMin;

                if (diffMin < 10)
                {
                    Console.WriteLine("0{0} minutes after the start", diffMin);
                }
                else
                {
                    Console.WriteLine("{0} minutes after the start", diffMin);
                }
            }
            // Check On Time
            else if ((examTimeHour == arriveTimeHour && ((examTimeMin - arriveTimeMin) <= 30)) || ((arriveTimeHour == examTimeHour - 1) && (((60 - arriveTimeMin) + examTimeMin) <= 30)))
            {
                Console.WriteLine("On time");

                if (examTimeHour == arriveTimeHour && ((examTimeMin - arriveTimeMin) <= 30))
                {
                    int diffMin = examTimeMin - arriveTimeMin;

                    if (diffMin > 0 && diffMin < 10)
                    {
                        Console.WriteLine("0{0} minutes before the start", diffMin);
                    }
                    else
                    {
                        Console.WriteLine("{0} minutes before the start", diffMin);
                    }
                }
                else if (((arriveTimeHour == examTimeHour - 1) && (((60 - arriveTimeMin) + examTimeMin) <= 30)))
                {
                    int diffMin = examTimeMin - arriveTimeMin;

                    if (diffMin >= 0)
                    {
                        if (diffMin < 10)
                        {
                            Console.WriteLine("{0}:0{1} hours before the start", (examTimeHour - arriveTimeHour), diffMin);
                        }
                        else
                        {
                            Console.WriteLine("{0}:{1} hours before the start", (examTimeHour - arriveTimeHour), diffMin);
                        }
                    }
                    else
                    {
                        diffMin = Math.Abs(diffMin);

                        if (diffMin < 10)
                        {
                            Console.WriteLine("{0}:0{1} hours before the start", (examTimeHour - arriveTimeHour - 1), diffMin);
                        }
                        else
                        {
                            Console.WriteLine("{0}:{1} hours before the start", (examTimeHour - arriveTimeHour - 1), diffMin);
                        }
                    }
                }
            }
            // Check Early
            else if (
                (arriveTimeHour == examTimeHour && ((examTimeMin - arriveTimeMin) > 30)) ||
                (arriveTimeHour == (examTimeHour) && ((60 - arriveTimeMin + examTimeMin) > 30)) ||
                (examTimeHour - 1 >= arriveTimeHour)
                )
            {
                Console.WriteLine("Early");
            }
        }
    }
}