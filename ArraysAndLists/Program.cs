using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - When you post a message on Facebook, depending on the number of people who like your post, 
            //    Facebook displays different information.

            //    If no one likes your post, it doesn't display anything.
            //    If only one person likes your post, it displays: [Friend's Name] likes your post.
            //    If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
            //    If more than two people like your post, it displays: 
            //        [Friend 1], [Friend 2] and[Number of Other People] others like your post.
            //    Write a program and continuously ask the user to enter different names, 
            //        until the user presses Enter (without supplying a name). 
            //        Depending on the number of names provided, display a message based on the above pattern.
            Console.WriteLine("#1. Facebook.\nPlease type a friend's name and press enter. Repeat until finished. Press Enter with no text when complete.");
            var friends = new List<string>();
            var friend = "";
            while (true)
            {
                friend = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(friend))
                {
                    break;
                }
                friends.Add(friend);
            }

            var count = friends.Count;
            //var newTotal = count--;
            switch (count)
            {
                case 0:
                    Console.WriteLine("");
                    break;
                case 1:
                    Console.WriteLine($"{friends[0]} like your post.");
                    break;
                case 2:
                    Console.WriteLine($"{friends[0]} and {friends[1]} like your post.");
                    break;
                default:
                    Console.WriteLine($"{friends[0]}, {friends[1]} and {friends.Count - 2} others like your post.");
                    break;
            }


            //2- Write a program and ask the user to enter their name.
            //            Use an array to reverse the name and then store the result in a new string. 
            //            Display the reversed name on the console.
            Console.WriteLine("\n#2. Name reversal. \nPlease enter your name.");
            var name = Console.ReadLine();
            var length = name.Length;
            var nameArray = name.ToCharArray();
            Array.Reverse(nameArray);
            var reverseName = "";
            foreach (var letter in nameArray)
            {
                reverseName += letter;
            }
            Console.WriteLine($"You're name in reverse is {reverseName}");

            //3- Write a program and ask the user to enter 5 numbers.
            //    If a number has been previously entered, display an error message and ask the user to re-try. 
            //    Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
            Console.WriteLine("\n#3. Numbers. Please enter 5 different numbers.");
            var numbers = new List<int>();
            while (numbers.Count < 5)
            {
                var number = int.Parse(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine($"You've already entered {number}. Please enter a new number.");
                    continue;
                }
                numbers.Add(number);
            }
            numbers.Sort();
            Console.WriteLine("Your number list is: ");
            foreach (var num in numbers) Console.WriteLine(num);

            //4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
            //        The list of numbers may include duplicates.Display the unique numbers that the user has entered.
            Console.WriteLine("\n#4. Number list.\nPlease enter as many numbers as you'd like. Type 'Quit' to exit.");
            var numbers2 = new List<int>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input.ToLower() == "quit") break;
                var number = int.Parse(input);
                if (numbers2.Contains(number)) continue;
                numbers2.Add(number);
            }
            numbers2.Sort();
            Console.WriteLine("All unique numbers on your list are:");
            foreach (var num in numbers2) Console.WriteLine(num);


            //5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
            //    If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; 
            //    otherwise, display the 3 smallest numbers in the list.
            Console.WriteLine("\n#5. Comma separated numbers.\nPlease enter a list of numbers separated by commas. You must enter at least 5 numbers.");
            var input2 = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input2) || input2.Length < 5)
            {
                Console.WriteLine("Invalid List. Please try again.");
                input2 = Console.ReadLine();
            }
            var inputArray = input2.Split(",");
            Array.Sort(inputArray);
            Console.WriteLine($"The three smallest numbers in your list are {inputArray[0]}, {inputArray[1]}, and {inputArray[2]}");
        }
    }
}
