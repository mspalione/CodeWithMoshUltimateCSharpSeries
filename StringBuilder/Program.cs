using System;
using System.Collections.Generic;

namespace StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Write a program and ask the user to enter a few numbers separated by a hyphen.
            //    Work out if the numbers are consecutive.
            //    For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
            //    display a message: "Consecutive"; otherwise, display "Not Consecutive".
            Console.WriteLine("#1. Consecutive Numbers.\nPlease enter a few numbers separated by hyphens.");
            var input = Console.ReadLine();
            var stringExtractor = new StringExtractor();
            var inputList = stringExtractor.InputList(input);
            var count = inputList.Count - 1;
            var breakCheck = false;

            if (inputList[0] > inputList[1])
            {
                for (int i = 0; i < count; i++)
                {
                    var check = inputList[i];
                    var value = check - 1;
                    var nextIndex = i + 1;
                    if (value != inputList[nextIndex])
                    {
                        Console.WriteLine("Not Consecutive.");
                        breakCheck = true;
                    }
                    if (breakCheck == true) break;
                }
                if (breakCheck != true) Console.WriteLine("Consecutive.");
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    var check = inputList[i];
                    var value = check + 1;
                    var nextIndex = i + 1;
                    if (value != inputList[nextIndex])
                    {
                        Console.WriteLine("Not Consecutive.");
                        breakCheck = true;
                    }
                    if (breakCheck == true) break;
                }
                if (breakCheck != true) Console.WriteLine("Consecutive.");
            }

            //2 - Write a program and ask the user to enter a few numbers separated by a hyphen.
            //    If the user simply presses Enter, without supplying an input, exit immediately; 
            //    otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.
            Console.WriteLine("\n#2. Duplicate Check.\nPlease enter a few numbers separated by hyphens");
            input = Console.ReadLine();
            var dupCheck = false;
            if (!String.IsNullOrWhiteSpace(input))
            {
                var stringExtractor2 = new StringExtractor();
                inputList = stringExtractor2.InputList(input);
                var listCheck = new List<int>();
                foreach (var num in inputList)
                {
                    if (!listCheck.Contains(num)) listCheck.Add(num);
                    else
                    {
                        dupCheck = true;
                        break;
                    }
                }

                var dupMessage = dupCheck == true ? "Duplicate." : "No duplicates.";
                Console.WriteLine(dupMessage);
            }


            //3 - Write a program and ask the user to enter a time value in the 24 - hour time format(e.g. 19:00). 
            //    A valid time should be between 00:00 and 23:59.
            //    If the time is valid, display "Ok"; otherwise, display "Invalid Time".
            //    If the user doesn't provide any values, consider it as invalid time.
            Console.WriteLine("\n#3. Time.\nPlease enter a time value in the 24 hour time format.");
            input = Console.ReadLine();
            var inputTime = input.Split(':');
            var intInput1 = int.Parse(inputTime[0]);
            var intInput2 = int.Parse(inputTime[1]);
            if ((intInput1 >= 00 && intInput1 <= 23) && (intInput2 >= 00 && intInput2 <= 59))
            {
                Console.WriteLine("Ok.");
            }
            else Console.WriteLine("Invalid Time");

            //4 - Write a program and ask the user to enter a few words separated by a space.
            //    Use the words to create a variable name with PascalCase. 
            //    For example, if the user types: "number of students", display "NumberOfStudents".
            //    Make sure that the program is not dependent on the input.
            //    So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
            Console.WriteLine("#4. PascalCase.\nPlease enter a few words separated by a space.");
            input = Console.ReadLine();
            var pascalArray = input.Split(" ");
            var pascalCase = "";
            foreach (var word in pascalArray)
            {
                pascalCase += char.ToUpper(word[0]) + word.ToLower().Substring(1);
            }

            Console.WriteLine(pascalCase);

            //5 - Write a program and ask the user to enter an English word.
            //    Count the number of vowels(a, e, o, u, i) in the word. 
            //    So, if the user enters "inadequate", the program should display 6 on the console.        
            Console.WriteLine("#5. Vowel count.\nPlease enter an English word.");
            input = Console.ReadLine();
            var lower = input.ToLower();
            count = 0;
            var length = input.Length;
            var letter = "";
            for (int i = 0; i < length; i++)
            {
                letter = lower[i].ToString();

                if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
                {
                    count++;
                }
            }
            Console.WriteLine($"There are {count} vowels in the word {input}.");
        }

       
    }

}
