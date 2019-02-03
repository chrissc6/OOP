using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class StopWatch
    {
        private DateTime _StartTime;

        public void StartTime()
        {
            _StartTime = DateTime.Now;
        }

        public void StopTime()
        {
            TimeSpan elapsed = DateTime.Now - _StartTime;
            Console.WriteLine("Elapsed Time: {0}m {1}s {2}ms", elapsed.Minutes, elapsed.Seconds, elapsed.Milliseconds);
        }
    }
}
