using System;
using System.Collections.Generic;
using System.Linq;

namespace LoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
            //    Display the count on the console.
            Console.WriteLine("Program one: numbers divisible by three.");
            var numbers = new List<int>();
            for(var i = 0; i < 100; i++)
            {
                var number = i + 1;
                if(number % 3 == 0)
                numbers.Add(number);
            }
            Console.WriteLine($"The total number of numbers divisible by three between the numbers one and one hundred are {numbers.Count}");

            //2 - Write a program and continuously ask the user to enter a number or "ok" to exit. 
            //    Calculate the sum of all the previously entered numbers and display it on the console.
            Console.WriteLine("\nProgram two: adding all entered numbers.");
            var instructions = "Enter a number or 'ok' to exit.";
            var add = 0;
            while (true)
            {
                Console.WriteLine(instructions);
                var response = Console.ReadLine();
                if (response == "ok") break;
                add += int.Parse(response);
            }

            Console.WriteLine($"I've been adding all your numbers. The total is {add}");

            //3 - Write a program and ask the user to enter a number. 
            //    Compute the factorial of the number and print it on the console. 
            //    For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
            Console.WriteLine("\nProgram three: number factoral.\n Enter a number.");
            var num = int.Parse(Console.ReadLine());
            var fact = num;
            for (var i = num - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine($"\nFactorial of Given Number is: {num}! = {fact}.");


            //4 - Write a program that picks a random number between 1 and 10.
            //    Give the user 4 chances to guess the number.
            //    If the user guesses the number, display “You won"; otherwise, display “You lost". 
            //    (To make sure the program is behaving correctly, you can display the secret number on the console first.)
            Console.WriteLine("\nProgram four: number guess.\nYou have four chances to guess the number I'm thinking of.\nFirst guess: ");
            var rand = new Random();
            var secretNumber = rand.Next(1, 10);
            var guess = 0;
            for(var i = 0; i < 4; i++)
            {
                guess = int.Parse(Console.ReadLine());
                if(guess == secretNumber)
                {
                    Console.WriteLine($"You won! The secret number was {secretNumber}");
                    break;
                }

                Console.WriteLine("Wrong. Guess again.");
            }


            //5 - Write a program and ask the user to enter a series of numbers separated by comma.
            //    Find the maximum of the numbers and display it on the console. 
            //    For example, if the user enters “5, 3, 8, 1, 4", the program should display 8."
            Console.WriteLine("\nProgram five: comma separated numbers.\nEnter a series of numbers with each number separated by a comma.");
            var numberInput = Console.ReadLine();
            var numberArray = numberInput.Split(',');
            var numberList = new List<int>();
            foreach(var number in numberArray)
            {
                numberList.Add(int.Parse(number));
            }
            Console.WriteLine($"The largest number in your list is {numberList.Max()}");
            
        }
    }
}
