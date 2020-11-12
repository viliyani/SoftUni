using System;

namespace CustomRandomList
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            RandomList list = new RandomList();

            list.Add("Hello");
            list.Add("world");
            list.Add("Pesho");
            list.Add("computer");
            list.Add("programming");
            list.Add("C#");
            list.Add("random string");
            list.Add("good morning!");

            Console.WriteLine(list.RandomString());
        }
    }
}
