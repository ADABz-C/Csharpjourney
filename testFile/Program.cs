using System.IO;

internal class Program
{
    static void Main(string[] args)
    {
        //File Operations
        string path = "C:\\Users\\chide\\source\\repos\\Csharpjourney\\testFile\\files\\example.txt";

        //Reading file

        if (File.Exists(path))
        {
            string content = File.ReadAllText(path);
            Console.WriteLine(content);

        }
        else
        {
            Console.WriteLine("File doesn't exist twin");
        }

        //Writing to file (overwrite)
        string writeContent = "New written line";
        File.WriteAllText(path, writeContent); //(path), (new content)
                                               //Adding/appending to file
        string addedContent = "\nI've append a 2nd line";
        File.AppendAllText(path, addedContent);

        //File Directory and operations
        string directoryPath = "C:\\Users\\chide\\source\\repos\\Csharpjourney\\testFile\\newFilesFolder\\";
        string filePath = Path.Combine(directoryPath, "example2.txt");



        if (!Directory.Exists(filePath))
        {
            Directory.CreateDirectory(directoryPath);
            Console.WriteLine("Directory Created");

        }
        File.WriteAllText(filePath, "example 2 created bro");

        if (!File.Exists(filePath))
        {
            File.WriteAllText(filePath, "The conditional statement created this created");
            Console.WriteLine("File Created inside directorty");
        }


        //Creating files in the current working directory
        string currentDirectory = AppDomain.CurrentDomain.BaseDirectory; // Checks for program's location
        string newFolderPath = Path.Combine(currentDirectory, "workingFolder"); //adds workingFolder to programs location

        if (!Directory.Exists(newFolderPath))
        {
            Directory.CreateDirectory(newFolderPath);
        }
        //Directory.CreateDirectory(newFolderPath) creates directory if it doesn't exist and does nothing if it doesn't exist

        string newFilePath = Path.Combine(newFolderPath, "example3.txt");

        File.WriteAllText(newFilePath, "File created in the directory you also created");



        if (!File.Exists(newFilePath))
        {
            File.WriteAllText(newFilePath, "This condition printed 'Hello World'");
            Console.WriteLine("Your condition came in clutch");
        }

        //Reading new file

        //I'm going to start reading from my created file
        if (File.Exists(newFilePath))
        {
            Console.WriteLine("Beginning of reading new files");
            string newContent = File.ReadAllText(newFilePath);

            Console.WriteLine(newContent);

        }
        else
        {
            Console.WriteLine("File doesn't exist");


        }

        string newdir = Path.GetDirectoryName(filePath);
        Console.WriteLine(newdir);

    }
}
