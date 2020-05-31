using System;

namespace Stopwatch
{
    class StopWatch
    {
        private TimeSpan _now { get; set; } 
        public TimeSpan StopTime { get; set; }

        public TimeSpan Now(bool alreadyStarted)
        {
            // figures the start time
            var _now = DateTime.Now.TimeOfDay;
            var intro = alreadyStarted == true ? "stop" : "start";
            Console.WriteLine($"The {intro} time is {_now}");
            return _now;
        }

        public TimeSpan Diff(TimeSpan start, TimeSpan stop)
        {
            var diff = stop - start;
            return diff;
        }

        public TimeSpan Total(TimeSpan diff, TimeSpan total)
        {
            total += diff;
            return total;
        }
    }    
}
    