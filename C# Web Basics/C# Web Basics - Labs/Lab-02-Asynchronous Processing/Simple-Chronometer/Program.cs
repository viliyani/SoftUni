using System;

namespace AsynchronousDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IChronometer chronometer = new Chronometer();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "exit")
                {
                    break;
                }

                if (command == "start")
                {
                    chronometer.Start();
                }
                else if (command == "stop")
                {
                    chronometer.Stop();
                }
                else if (command == "lap")
                {
                    Console.WriteLine(chronometer.Lap());
                }
                else if (command == "laps")
                {
                    int lapsCount = chronometer.Laps.Count;

                    if (lapsCount == 0)
                    {
                        Console.WriteLine("Laps: no laps");
                    }
                    else
                    {
                        Console.WriteLine("Laps:");
                        for (int i = 0; i < lapsCount; i++)
                        {
                            Console.WriteLine($"{i}. {chronometer.Laps[i]}");
                        }
                    }

                }
                else if (command == "time")
                {
                    Console.WriteLine(chronometer.GetTime);
                }
                else if (command == "reset")
                {
                    chronometer.Reset();
                }

            }
        }
    }
}
