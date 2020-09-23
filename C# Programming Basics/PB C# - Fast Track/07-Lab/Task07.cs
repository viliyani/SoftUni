using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();

            int ticketsStandard = 0;
            int ticketsStudent = 0;
            int ticketsKid = 0;

            while (movieName != "Finish")
            {
                int availableSeats = int.Parse(Console.ReadLine());

                int seatsTaken = 0;
                string ticketType = Console.ReadLine();

                while (ticketType != "End")
                {
                    if (ticketType == "standard")
                    {
                        ticketsStandard++;
                    }
                    else if (ticketType == "student")
                    {
                        ticketsStudent++;
                    }
                    else if (ticketType == "kid")
                    {
                        ticketsKid++;
                    }

                    seatsTaken++;
                    if (seatsTaken == availableSeats)
                    {
                        break;
                    }
                    ticketType = Console.ReadLine();
                }

                double percentageFull = seatsTaken * 1.0 / availableSeats * 100;
                Console.WriteLine($"{movieName} - {percentageFull:F2}% full.");

                movieName = Console.ReadLine();
            }

            int totalTickets = ticketsStandard + ticketsStudent + ticketsKid;
            Console.WriteLine("Total tickets: {0}", totalTickets);
            Console.WriteLine("{0:F2}% student tickets.", (ticketsStudent * 1.0 / totalTickets * 100));
            Console.WriteLine("{0:F2}% standard tickets.", (ticketsStandard * 1.0 / totalTickets * 100));
            Console.WriteLine("{0:F2}% kids tickets.", (ticketsKid * 1.0 / totalTickets * 100));
        }
    }
}