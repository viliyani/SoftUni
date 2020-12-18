using System;
using FizzBuzz.Contracts;

namespace FizzBuzz.Tests.Fakes
{
    public class FakeConsoleWriter : IWriter
    {
        public void WriteLine(string input)
        {
            Result += input;
        }

        public string Result { get; private set; }
    }
}
