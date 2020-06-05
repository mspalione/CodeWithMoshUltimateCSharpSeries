using System;
using System.Collections;

namespace DesignAStack
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var stack = new Stack();
                stack.Push(1);
                stack.Push(2);
                stack.Push(3);


                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new InvalidOperationException();
            }
            
        }
    }
}
