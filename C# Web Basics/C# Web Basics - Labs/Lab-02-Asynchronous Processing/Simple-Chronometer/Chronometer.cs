using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousDemo
{
    public class Chronometer : IChronometer
    {
        private long milliseconds;

        private bool isRunning;

        private List<string> laps;


        public Chronometer()
        {
            laps = new List<string>();
            Reset();
        }

        public string GetTime => GetTimeString(milliseconds);

        public IReadOnlyList<string> Laps
        {
            get
            {
                return laps.AsReadOnly();
            }
        }

        public string Lap()
        {
            string lap = GetTime;

            laps.Add(lap);

            return lap;
        }

        public void Reset()
        {
            Stop();
            milliseconds = 0;
            laps.Clear();
        }

        public void Start()
        {
            isRunning = true;

            Task.Run(() =>
            {
                while (isRunning)
                {
                    Thread.Sleep(1);
                    milliseconds++;
                }
            });
        }

        public void Stop()
        {
            isRunning = false;
        }

        private string GetTimeString(long milliseconds)
        {
            return $"{milliseconds / (60 * 1000):D2}:{milliseconds / 1000:D2}:{milliseconds % 1000:D4}";
        }
    }

}
