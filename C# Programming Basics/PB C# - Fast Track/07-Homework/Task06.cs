using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                string currentNum = i.ToString();

                bool flag = true;

                for (int j = 0; j < currentNum.Length; j++)
                {
                    int digit = int.Parse(currentNum[j].ToString());
                    
                    if (digit == 0 || n % digit != 0)
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag == true)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}