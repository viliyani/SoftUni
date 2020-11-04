using System;
using System.Linq;

namespace AlgorithmsIntro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(Sum(arr, 0));
        }

        private static int Sum(int[] arr, int idx)
        {
            if (idx == arr.Length)
            {
                return 0;
            }

            int sum = arr[idx] + Sum(arr, idx + 1);
            return sum;
        }
    }
}
