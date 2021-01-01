using System;
using Logger.Core.Contracts;
using Logger.Models.Contracts;
using Logger.Models.IOManagment.Contracts;
using Logger.Factories;
using Logger.Models.Enumerations;
using Logger.Common;
using System.Globalization;
using Logger.Models.Errors;

namespace Logger.Core
{
    public class Engine : IEngine
    {
        private readonly ILogger logger;
        private readonly IReader reader;
        private readonly IWriter writer;

        public Engine(ILogger logger, IReader reader, IWriter writer)
        {
            this.logger = logger;
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            string command;

            while ((command = reader.ReadLine()) != "END")
            {
                string[] errorArgs = command
                    .Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                string levelStr = errorArgs[0];
                string dateTimeStr = errorArgs[1];
                string message = errorArgs[2];

                Level level;

                bool isEnumValid = Enum.TryParse(levelStr, out level);

                if (!isEnumValid)
                {
                    this.writer.WriteLine(GlobalConstants.InvalidLevelType);
                    continue;
                }

                DateTime dateTime;

                bool isDateTimeValid = DateTime.TryParseExact(dateTimeStr, GlobalConstants.DateTimeFormat,
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None, out dateTime);

                if (!isDateTimeValid)
                {
                    this.writer.WriteLine(GlobalConstants.InvalidDateTimeFormat);
                    continue;
                }

                IError error = new Error(dateTime, message, level);

                this.logger.Log(error);
            }

            this.writer.WriteLine(this.logger.ToString());
        }
    }
}
