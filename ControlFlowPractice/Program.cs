using System;

namespace ControlFlowPractice
{
    class Program
    {
        static void Main(string[] args)
        {
          //1 - Write a program and ask the user to enter a number.
        //   The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console.
        //   Otherwise, display "Invalid". 
        //  (This logic is used a lot in applications where values entered into input boxes need to be validated.)

            Console.WriteLine("Enter a number between 1 and 10.");
            var number = int.Parse(Console.ReadLine());

            if (number > 0 && number < 11)
                Console.WriteLine("Valid.");
            else
                Console.WriteLine("Invalid");

//        2- Write a program which takes two numbers from the console and displays the maximum of the two.
            Console.WriteLine("Please enter a number.");
            var num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a second number.");
            var num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine($"{num1} is the larger number.");
            else
                Console.WriteLine($"{num2} is the larger number.");

//        3- Write a program and ask the user to enter the width and height of an image.
//          Then tell if the image is landscape or portrait.            
            Console.WriteLine("Please enter the width of the image.");
            var width = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the height of the image.");
            var height = int.Parse(Console.ReadLine());

            var portrait = width < height;

            var type = portrait ? "portrait" : "landscape";

            Console.WriteLine($"The image is a {type}.");

            //4 - Your job is to write a program for a speed camera.
            //    For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
            //    Write a program that asks the user to enter the speed limit.
            //    Once set, the program asks for the speed of a car.
            //    If the user enters a value less than the speed limit, program should display Ok on the console.
            //    If the value is above the speed limit, the program should calculate the number of demerit points.
            //    For every 5km / hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
            //    If the number of demerit points is above 12, the program should display License Suspended.
            Console.WriteLine("Please enter the speed limit.");
            var speedLimit = int.Parse(Console.ReadLine());
            Console.WriteLine($"The speed limit is {speedLimit}.\nWhat was the speed of the car?");
            var carSpeed = int.Parse(Console.ReadLine());

            if (carSpeed < speedLimit)
                Console.WriteLine("Ok.");
            else
            {
                var difference = carSpeed - speedLimit;
                switch (difference)
                {
                    case 5:
                        Console.WriteLine("1 demerit point.");
                        break;
                    case 10:
                        Console.WriteLine("2 demerit points.");
                        break;
                    case 15:
                        Console.WriteLine("3 demerit points.");
                        break;
                    case 20:
                        Console.WriteLine("4 demerit points.");
                        break;
                    case 25:
                        Console.WriteLine("5 demerit points.");
                        break;
                    case 30:
                        Console.WriteLine("6 demerit points.");
                        break;
                    case 35:
                        Console.WriteLine("7 demerit points.");
                        break;
                    case 40:
                        Console.WriteLine("8 demerit points.");
                        break;
                    default:
                        Console.WriteLine("License Suspended");
                        break;

                }
            }
        }
    }
}
