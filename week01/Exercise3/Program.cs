using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        // This program contain a lot about while and for loop 
        // This is guessing game program
        string again = "Yes";

        while (again != "No")
        {


            // Get random magic number
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);

            // This valuable guessNumber is to run the while 
            int guessNumber = -1;

            // Get the user guess counting so make valuable
            int userGuessCounter = 0;

            // This while loops will run until user guess the magic number
            while (guessNumber != magicNumber)
            {
                // Get the user guess number 
                Console.Write("Enter your guess number : ");
                string userGuessNumber = Console.ReadLine();  // get the user input as a string valuable
                guessNumber = int.Parse(userGuessNumber);  // Then convert to int
                userGuessCounter += 1;

                // Check the user input and compare to magic number with if statement
                if (guessNumber < magicNumber)
                {
                    // Display lower than magicNumber 
                    Console.WriteLine("Try to guess higher!");
                }

                // Check the user input is high than magicNumber or not
                else if (guessNumber > magicNumber)
                {
                    // Display higher than magicNumber
                    Console.WriteLine("Try to guess lower!");
                }
            }

            // Display the results with guess amount
            Console.WriteLine("You guess the number correctly!");
            Console.WriteLine($"You took {userGuessCounter} times to guess it right.");


            Console.WriteLine("");
            Console.Write("Would you like to play again?(Yes or No) : ");
            again = Console.ReadLine();
        }

        Console.WriteLine("Thank you for playing our game.");
    }
}