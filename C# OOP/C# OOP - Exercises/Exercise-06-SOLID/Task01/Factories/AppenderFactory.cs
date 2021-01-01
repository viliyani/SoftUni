using Logger.Common;
using Logger.Models.Appenders;
using Logger.Models.Contracts;
using Logger.Models.Enumerations;
using System;

namespace Logger.Factories
{
    public class AppenderFactory
    {
        public AppenderFactory()
        {

        }

        public IAppender CreateAppender(string appenderTypeStr, ILayout layout, Level level, IFile file = null)
        {
            IAppender appender;

            if (appenderTypeStr == "ConsoleAppender")
            {
                appender = new ConsoleAppender(layout, level);
            }
            else if (appenderTypeStr == "FileAppender" && file != null)
            {
                appender = new FileAppender(layout, level, file);
            }
            else
            {
                throw new InvalidOperationException(GlobalConstants.InvalidAppenderType);
            }

            return appender;
        }

    }
}
