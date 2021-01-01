using System;
using Logger.Models.IOManagment.Contracts;

namespace Logger.Models.IOManagment
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
