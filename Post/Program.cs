using System;

namespace Post
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 2: Design a StackOverflow Post
            //Design a class called Post.This class models a StackOverflow post.
            //It should have properties for title, description and the date/time it was created.
            //We should be able to up-vote or down-vote a post.We should also be able to see the current vote value.
            //    In the main method, create a post, up-vote and down-vote it a few times and then display the the current vote value.
            //    In this exercise, you will learn that a StackOverflow post should provide methods for up-voting and down-voting.
            //    You should not give the ability to set the Vote property from the outside, because otherwise, 
            //    you may accidentally change the votes of a class to 0 or to a random number.
            //And this is how we create bugs in our programs. The class should always protect its state and hide its implementation detail.
            //Educational tip: The aim of this exercise is to help you understand that classes should encapsulate data AND behaviour around that data. 
            //    Many developers (even those with years of experience) tend to create classes that are purely data containers, 
            //and other classes that are purely behaviour (methods) providers.This is not object-oriented programming. 
            //    This is procedural programming. Such programs are very fragile.Making a change breaks many parts of the code.

            var upvote = 0;
            var downvote = 0;
            var title = "";
            var description = "";
            var created = "";
            var stop = false;
            var input = "";
            var post = new Post();
            Console.WriteLine("Please submit your stack overflow post. What is your title?");
            title = post.TitlePost();
            Console.WriteLine($"The title of your post is '{title}'. \nWhat is your post?");
            description = post.DescribePost();
            created = post.CreatePost();
            Console.WriteLine($"The description of your post is '{description}'. \nYour post was successfully created on {created}.\nTo upvote this post, please enter '+'. To downvote this post, please enter '-'. Type 'q' to quit.");
            while (stop == false)
            {
                input = Console.ReadLine();
                if (input == "q")
                {
                    stop = true;
                    continue;
                }
                else if (input == "+") upvote = post.Upvote(upvote);
                else if (input == "-") downvote = post.Downvote(downvote);
                else
                {
                    Console.WriteLine("Invalid input. Please type '+', '-', or 'q'.");
                    continue;
                }

                Console.WriteLine($"Upvotes: {upvote}\nDownvotes: {downvote}");
            }
        }
    }
}
