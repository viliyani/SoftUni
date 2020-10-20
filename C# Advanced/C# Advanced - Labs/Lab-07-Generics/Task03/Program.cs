using System;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<int> check = new EqualityScale<int>(1,1);

            Console.WriteLine(check.AreEqual());
        }
    }
}
