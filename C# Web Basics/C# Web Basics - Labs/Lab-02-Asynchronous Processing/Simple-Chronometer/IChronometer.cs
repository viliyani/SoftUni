using System.Collections.Generic;

namespace AsynchronousDemo
{
    public interface IChronometer
    {
        string GetTime { get; }

        IReadOnlyList<string> Laps { get; }

        void Start();

        void Stop();

        string Lap();

        void Reset();

    }

}
