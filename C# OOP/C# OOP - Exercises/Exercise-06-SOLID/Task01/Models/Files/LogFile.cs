using System;
using Logger.Models.Contracts;
using System.IO;
using System.Linq;
using Logger.Models.Enumerations;
using Logger.Common;

namespace Logger.Models.Files
{
    public class LogFile : IFile
    {
        private readonly IPathManager pathManager;

        public LogFile(IPathManager pathManager)
        {
            this.pathManager = pathManager;
            this.pathManager.EnsureDirectoryAndFileExists();
        }

        public string Path
        {
            get
            {
                return this.pathManager.CurrentFilePath;
            }
        }

        public long Size
        {
            get
            {
                return this.CalculateFileSize();
            }
        }

        public string Write(ILayout layout, IError error)
        {
            string format = layout.Format;

            DateTime dateTime = error.DateTime;
            string message = error.Message;
            Level level = error.Level;

            string formattedMessage = String.Format(format,
                        dateTime.ToString(GlobalConstants.DateTimeFormat),
                        level.ToString(),
                        message);

            return formattedMessage;
        }

        private long CalculateFileSize()
        {
            string fileText = File.ReadAllText(this.Path);

            return fileText
                .ToCharArray()
                .Where(c => Char.IsLetter(c))
                .Sum(c => c);
        }
    }
}
