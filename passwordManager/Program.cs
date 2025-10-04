using System;
using System.IO;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Start");

        string path = "sample.txt";
        File.WriteAllText(path, "Hello, File Handling in C#!!!!");
        Console.WriteLine("File created successfully.");




    }
}
