using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //Creating a stack
        Stack<String> stack = new Stack<String>();

        stack.Push("Minecraft");
        stack.Push("Horizon");
        stack.Push("SpiderMan");
        stack.Push("FIFA");

        //stack.Pop();
        //Console.WriteLine(stack);


        // Reading a stack
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }

    }
}