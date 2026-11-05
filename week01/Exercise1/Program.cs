using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        // Activity 1 of display user first name and last name

        // Store a user name as a valuable
        string firstName = "";
        string lastName = "";

        // Ask for user first name 
        Console.Write("Enter your first name please : ");
        firstName = Console.ReadLine();

        // Ask for user last name
        Console.Write("Enter your last name please : ");
        lastName = Console.ReadLine();

        // Display the user name 
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}