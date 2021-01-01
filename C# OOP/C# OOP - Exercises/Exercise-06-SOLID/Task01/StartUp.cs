using Logger.Common;
using Logger.Factories;
using Logger.Models.Contracts;
using Logger.Models.Enumerations;
using Logger.Models.IOManagment.Contracts;
using System;
using System.Collections.Generic;
using Logger.Models;
using Logger.Models.IOManagment;
using Logger.Models.PathManagment;
using Logger.Models.Files;
using Logger.Core;
using Logger.Core.Contracts;

namespace Logger
{
    public class StartUp
    {
        private static readonly LayoutFactory layoutFactory = new LayoutFactory();
        private static readonly AppenderFactory appenderFactory = new AppenderFactory();

        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IPathManager pathManager = new PathManager("logs", "logs.txt");
            IFile file = new LogFile(pathManager);

            ILogger logger = SetUpLogger(n, reader, writer, file);

            IEngine engine = new Engine(logger, reader, writer);
            engine.Run();
        }

        private static ILogger SetUpLogger(int appendersCnt, IReader reader, IWriter writer, IFile file)
        {
            ICollection<IAppender> appenders = new HashSet<IAppender>();

            for (int i = 0; i < appendersCnt; i++)
            {
                string[] appendersArgs = reader.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string appenderType = appendersArgs[0];
                string layoutType = appendersArgs[1];

                bool hasError = false;

                Level level = ParseLevel(appendersArgs, writer, ref hasError);

                if (hasError)
                {
                    continue;
                }

                try
                {
                    ILayout layout = layoutFactory.CreateLayout(layoutType);
                    IAppender appender = appenderFactory.CreateAppender(appenderType, layout, level, file);

                    appenders.Add(appender);
                }
                catch (InvalidOperationException ioe)
                {
                    writer.WriteLine(ioe.Message);
                }
            }

            ILogger logger = new MyLogger(appenders);

            return logger;
        }

        private static Level ParseLevel(string[] levelStr, IWriter writer, ref bool hasError)
        {
            Level appenderLevel = Level.INFO;

            if (levelStr.Length == 3)
            {
                Level enumParsed;

                bool isEnumValid = Enum.TryParse(levelStr[2], out enumParsed);

                if (!isEnumValid)
                {
                    writer.WriteLine(GlobalConstants.InvalidLevelType);
                    hasError = true;
                }

                appenderLevel = enumParsed;
            }

            return appenderLevel;
        }
    }
}
