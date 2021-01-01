﻿using System;
using Logger.Models.IOManagment.Contracts;
using System.IO;

namespace Logger.Models.IOManagment
{
    public class FileWriter : IWriter
    {
        public FileWriter(string filePath)
        {
            this.FilePath = filePath;
        }

        public string FilePath { get; }

        public void Write(string text)
        {
            File.AppendAllText(this.FilePath, text);
        }

        public void WriteLine(string text)
        {
            File.AppendAllText(this.FilePath, text + Environment.NewLine);
        }
    }
}
