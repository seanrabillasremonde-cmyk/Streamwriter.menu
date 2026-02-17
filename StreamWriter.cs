using System;
using System.IO;

class Program
{
    static void Main()
    {
        bool running = true;
        string fileName = "";

        while (running)
        {
            Console.WriteLine("\n==== MENU ====");
            Console.WriteLine("|1. Change File Name");
            Console.WriteLine("|2. Enter Text and Save");
            Console.WriteLine("|3. Display File Content");
            Console.WriteLine("|4.Exit");    
            Console.Write("|Choose: ");
            string choice = Console.ReadLine();

            switch (choice)
            {

                case "1":


                    Console.WriteLine("Enter file name: ");
                      fileName = Console.ReadLine() + ".txt";

                    using (StreamWriter writer = new StreamWriter(fileName))
                    {
                        Console.WriteLine("User created this file.");
                    }


                    break;

                case "2":
            
                    Console.Write("Enter text: ");
                    string userInput = Console.ReadLine();

                    using (StreamWriter writer = new StreamWriter(fileName))
                    {
                        writer.WriteLine(userInput);
                    }

                  Console.WriteLine("Saved successfully!"+ fileName);
                    break;

                case "3":
                    if (File.Exists(fileName))
                    {
                        using (StreamReader reader = new StreamReader(fileName))
                        {
                            string content = reader.ReadToEnd();
                            Console.WriteLine("\n--- File Content ---");
                            Console.WriteLine(content);
                        }
                    }
                    else
                    {
                        Console.WriteLine("File does not exist yet.");
                    }
                    break;

                case "4":
                    running = false;
                    Console.WriteLine("Exiting program...");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
