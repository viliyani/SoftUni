using CommandPattern.Core;
using CommandPattern.Core.Contracts;
using System;

namespace CommandPattern
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            ICommandInterpreter ci = new CommandInterpreter();
            IEngine engine = new Engine(ci);
            engine.Run();
        }
    }
}
