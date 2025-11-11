using System;
using System.IO;
class Program
{   
    //This function takes filedir, org/account name, username, email and password as parameters
    //the variable "addedContent" is the collection of every parameter that comes after filedir
    public static void addpwd(string pwdHolderFile, string addedContent)
    {
        try
        {
            File.AppendAllText(pwdHolderFile, addedContent);
            Console.WriteLine("Password added successfully");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File Not Found");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error occured: {ex.Message}");
        }
    }
    public static void Main(string[] args)
    {
        //I'm going to start by creating the file and its directory in the location where the program is being run
        string currentDir = AppDomain.CurrentDomain.BaseDirectory; //working directory
        string pwdFolder = Path.Combine(currentDir, "pwdFolder"); //adds pwdFolder to working directory

        if (!Directory.Exists(pwdFolder))
        {
            Directory.CreateDirectory(pwdFolder);
            Console.WriteLine("Directory forcefully created");
        }
        //Creating new file 
        string pwdHolderFile = Path.Combine(pwdFolder, "pwdHolderFile.txt");

        if (!File.Exists(pwdHolderFile))
        {
            File.WriteAllLines(pwdHolderFile, "Password file created forcefully");
        }
        //File has been created
        string masterPwd = "p"; // Main password

        // Enter password
        Console.Write("Enter master password to view content >>  ");
        string pwd = Console.ReadLine();


        //Console.WriteLine("hey " + pwd);

        Console.Write("Would you like to view your existing passwords or add a new one (view, add) | type 'q' to quit >>  ");
        string mode = Console.ReadLine();
        while (true)
        {
            if (mode.ToLower() == "q")
            {
                break;
            }
            if (mode.ToLower() == "view")
            {

            }
            else if (mode.ToLower() == "add")
            {
                Console.Write("Enter Organization/Account name >> ");
                string org = Console.ReadLine();

                Console.Write("Enter Username >> ");
                string userName = Console.ReadLine();

                Console.Write("Enter e-mail >> ");
                string email = Console.ReadLine();

                Console.Write("Enter Password >> ");
                string password = Console.ReadLine();



                Console.Write($"You are about to save password as: \n" +
                    $"Organization/Account name: {org}\n" +
                    $"Username: {userName}\n" +
                    $"E-mail: {email}\n" +
                    $"Is this correct? (y/n) >> ");
                char choice = Console.ReadKey().KeyChar;

            }
            else { Console.WriteLine("Invalid mode."); }
        }
    }
}
