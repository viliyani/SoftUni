using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());

            double price = meters * 7.61;
            double discount = price * 0.18;
            double final = price - discount;

            string formatFinal = String.Format("{0:0.00}", final);
            string formatDiscount = String.Format("{0:0.00}", discount);

            Console.WriteLine($"The final price is: {formatFinal} lv.");
            Console.WriteLine($"The discount is: {formatDiscount} lv.");
        }
    }
}