using System;

namespace DefiningClasses
{
    public class Cargo
    {
        public string Type { get; set; }

        public Cargo(string type)
        {
            this.Type = type;
        }
    }
}
