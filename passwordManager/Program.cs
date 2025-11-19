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
            Console.WriteLine("\nPassword added successfully");
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
    public static void viewpwd(string pwdHolderFile)
    {
        if (File.Exists(pwdHolderFile))
        {
            string content = File.ReadAllText(pwdHolderFile);
            Console.WriteLine(content);
        }
        else
        {
            Console.WriteLine("File doesn't exist");
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
            File.WriteAllText(pwdHolderFile, " \n");
        }
        //File has been created
        string masterPwd = "p"; // Main password

        // Enter password
        Console.Write("Enter master password to view content >>  ");
        string pwd = Console.ReadLine();


        //Console.WriteLine("hey " + pwd);

        
        
        while (true)
        {
            Console.Write("Would you like to view your existing passwords or add a new one (view, add) | type 'q' to quit >>  ");
            string mode = Console.ReadLine();

            if (mode.ToLower() == "q")
            {
                break;
            }
            if (mode.ToLower() == "view")
            {
                viewpwd(pwdHolderFile);
            }
            else if (mode.ToLower() == "add")
            {
                while (true)
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
                        $"Password: {password}\n" +
                        $"Is this correct? (y/n) | type 'q' to quit >> ");
                    string choice = Console.ReadLine();
                    Console.WriteLine();

                    if (choice.Trim().ToLower() == "y")
                    {
                        //PwdEntry format
                        string pwdEntry = $"----------------------------------------------------------------------------\n" +
                            $"Organization/Account name : {org}\n" +
                        $"Username: {userName}\n" +
                        $"E-mail: {email}\n" +
                        $"Password: {password}\n" +
                        "----------------------------------------------------------------------------";

                        //Append file with password
                        //I almost forgot I previosly created a function
                        addpwd(pwdHolderFile, pwdEntry);

                    }
                    else if (choice.Trim().ToLower() == "n")
                    {
                        Console.WriteLine("\nRe-Enter correct password");
                        continue;
                    }
                    else if (choice.Trim().ToLower() == "q")
                    {
                        Console.WriteLine("\nThanks for using this password manager");
                        break;
                    }
                    else { Console.WriteLine("Invalid character"); }

                    
                }
            }
            else { Console.WriteLine("Invalid mode."); }
        }
    }
}
