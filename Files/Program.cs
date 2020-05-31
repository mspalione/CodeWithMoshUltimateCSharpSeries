using System;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "TextFile1.txt";
            //1 - Write a program that reads a text file and displays the number of words.
            var content = File.ReadAllText(path);
            var words = content.Split(" ");
            var length = words.Length;
            Console.WriteLine($"The total number of words in this file is {length}");


            //2 - Write a program that reads a text file and displays the longest word in the file.        
            var count = 0;
            var wordLength = 0;
            var longestWord = "";
            foreach (var word in words)
            {
                wordLength = word.Length;
                if (wordLength > count)
                {
                    count = wordLength;
                    longestWord = word;
                }
            }
            Console.WriteLine($"The longest word in the file is {longestWord} with {count} letters.");
        
        }
    }
}
