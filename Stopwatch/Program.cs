using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1: Design a StopwatchDesign a class called Stopwatch.
            //The job of this class is to simulate a stopwatch.It should provide two methods: Start and Stop.
            //We call the start method first, and the stop method next.
            //Then we ask the stopwatch about the duration between start and stop. Duration should be a value in TimeSpan.
            //Display the duration on the console. We should also be able to use a stopwatch multiple times.
            //So we may start and stop it and then start and stop it again. 
            //Make sure the duration value each time is calculated properly. 
            //We should not be able to start a stopwatch twice in a row (because that may overwrite the initial start time). 
            //So the class should throw an InvalidOperationException if its started twice. 

            //Educational tip: The aim of this exercise is to make you understand that a class should be always in a valid state.
            //We use encapsulation and information hiding to achieve that.The class should not reveal its implementation detail.
            //It only reveals a little bit, like a blackbox.From the outside, you should not be able to misuse a class 
            //because you shouldn’t be able to see the implementation detail.
            var stopwatch = new StopWatch();
            Console.WriteLine("To begin the stop watch, type 'start' and hit enter. To end the stopwatch, type 'stop' and hit enter. Type 'q' to quit.");
            var input = Console.ReadLine().ToLower();
            var alreadyStarted = false;
            var start = TimeSpan.Zero;
            TimeSpan stop;
            var quit = false;
            var total = TimeSpan.Zero;

            while (quit == false)
            {
                if (input == "start" && alreadyStarted == false)
                {
                    start = stopwatch.Now(alreadyStarted);
                    alreadyStarted = true;
                    input = Console.ReadLine();
                }
                else if (input == "stop" && alreadyStarted == true)
                {
                    stop = stopwatch.Now(alreadyStarted);
                    alreadyStarted = false;
                    var diff = stopwatch.Diff(start, stop);
                    total += stopwatch.Total(diff, total);
                    Console.WriteLine($"Total time: {total}");
                    input = Console.ReadLine();
                }
                else if (input == "start" && alreadyStarted == true)
                {
                    Console.WriteLine("You've already started the stopwatch. Try typing 'stop'.");
                    input = Console.ReadLine();
                }
                else if (input == "stop" && alreadyStarted == false)
                {
                    Console.WriteLine("You need to start the stopwatch before stopping it. Try typing 'start'.");
                    input = Console.ReadLine();
                }
                else if (input == "q")
                {
                    quit = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    input = Console.ReadLine();
                }
            }
            
        }
    }
}
