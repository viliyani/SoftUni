using System;
using Logger.Models.Contracts;
using System.IO;

namespace Logger.Models.PathManagment
{
    public class PathManager : IPathManager
    {
        private const string PATH_DELIMITER = "\\";

        private readonly string currentPath;
        private readonly string folderName;
        private readonly string fileName;

        private PathManager()
        {
            this.currentPath = this.GetCurrentPath();
        }

        public PathManager(string folderName, string fileName)
            : this()
        {
            this.folderName = folderName;
            this.fileName = fileName;
        }

        public string CurrentDirectoryPath
        {
            get
            {
                return this.currentPath + PATH_DELIMITER + this.folderName;
            }
        }

        public string CurrentFilePath
        {
            get
            {
                return this.CurrentDirectoryPath + PATH_DELIMITER + this.fileName;
            }
        }

        public void EnsureDirectoryAndFileExists()
        {
            if (!Directory.Exists(this.CurrentDirectoryPath))
            {
                Directory.CreateDirectory(this.CurrentDirectoryPath);
            }

            File.AppendAllText(this.CurrentFilePath, String.Empty);
        }

        public string GetCurrentPath()
        {
            return Directory.GetCurrentDirectory();
        }
    }
}
