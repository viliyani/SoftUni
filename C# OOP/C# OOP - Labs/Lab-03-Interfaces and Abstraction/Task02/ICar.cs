using System;

namespace Cars
{
    public interface ICar
    {
        string Model { get; set; }
        string Color { get; set; }

        string Start();
        string Stop();

        string ToString();
    }
}
