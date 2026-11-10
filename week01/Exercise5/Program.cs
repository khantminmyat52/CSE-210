using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        // This is exercise 5
        // In this program, the main focus is about function

        // Create a function for display the message
        static void DisplayWelcome() // This function will just display the message
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName() // This function will ask the user name and return as a string 
        {
            // Ask the user name 
            Console.Write("What is your name ? ");
            string userName = Console.ReadLine(); // Stored in a valuable 
            return userName;
        }
        static int PromptUserNumber() // This function will ask the user favorite number and return as a int
        {
            // Ask the user favorite number 
            Console.Write("Enter your favorite number : ");
            string userInput = Console.ReadLine(); // Stored the user input as a string first
            int userNumber = int.Parse(userInput); // Then convert into int

            return userNumber;
        }

        // Create the function to make the user fav number convert squared number 
        static int SquareNumber(int number) // This function will take one parameter and make it squared. Then return as int
        {
            int squaredNumber = number * number;
            return squaredNumber;
        }

        // Create the final function to display the result
        static void DisplayResult(string userName , int squaredNumber) // This function will display the final result
        {
            Console.WriteLine($"{userName}, the square of your favorite number is {squaredNumber}");
            return;
        }

        string userName = PromptUserName();
        int SquaredNumber = PromptUserNumber();

        DisplayResult(userName, SquareNumber(SquaredNumber));

    }
}         
        