using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int cakePieces = width * height;
            int total = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    break;
                }

                int pieces = int.Parse(input);

                total += pieces;

                if (total >= cakePieces)
                {
                    break;
                }
            }

            if (total > cakePieces)
            {
                Console.WriteLine("No more cake left! You need {0} pieces more.", (total - cakePieces));
            }
            else
            {
                Console.WriteLine("{0} pieces are left.", (cakePieces - total));
            }
        }
    }
}