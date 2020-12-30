using System;

namespace Singleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var db1 = SingletonDataContainer.Instance;
            var db2 = SingletonDataContainer.Instance;

            Console.WriteLine(db1.GetPopulation("Sofia"));
            Console.WriteLine(db2.GetPopulation("Moskva"));
        }
    }
}
