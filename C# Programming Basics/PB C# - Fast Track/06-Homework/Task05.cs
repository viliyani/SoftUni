using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());

            int counter = 0;

            double lv2 = Math.Floor(money);
            double stotinki2 = 100 * (money - lv2);

            int lv = Convert.ToInt32(lv2);
            int stotinki = Convert.ToInt32(stotinki2);

            while (lv > 0)
            {
                if (lv >= 1.99)
                {
                    lv -= 2;
                    counter++;
                }
                if (lv >= 0.98 && lv < 1.99)
                {
                    lv -= 1;
                    counter++;
                }
            }

            while (stotinki > 0)
            {
                if (stotinki >= 50)
                {
                    stotinki -= 50;
                    counter++;
                }
                if (stotinki >= 20 && stotinki < 50)
                {
                    stotinki -= 20;
                    counter++;
                }
                if (stotinki >= 10 && stotinki < 20)
                {
                    stotinki -= 10;
                    counter++;
                }
                if (stotinki >= 5 && stotinki < 10)
                {
                    stotinki -= 5;
                    counter++;
                }
                if (stotinki >= 2 && stotinki < 5)
                {
                    stotinki -= 2;
                    counter++;
                }
                if (stotinki >= 1 && stotinki < 2)
                {
                    stotinki -= 1;
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}