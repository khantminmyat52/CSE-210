using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        // This is Activity 2 about displaying grades

        string letter = "";
        string sign = "";

        // Get the user grade percentage
        Console.Write("Enter your exam grade percentage : ");
        string userInput = Console.ReadLine();  // Get the user input as a string and store in valuable
        int grade = int.Parse(userInput); // then convert into int


        // Check what grade user get using if statement
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }

        // This following code will get + or - for letter according to user grade

        // Get grade reminder for last digit
        float gradeReminder = grade % 10;
        if (gradeReminder >= 7)
        {
            sign = "+";

            if (letter == "A" || letter == "F")
            {
                sign = "";
            }
        }
        else if (gradeReminder < 3)
        {
            sign = "-";

            if (letter == "F")
            {
                sign = "";
            }
        }
        
        // Print the result to console 
        Console.WriteLine($"You get {letter}{sign}.");

        // If user grade is 70 or over 70 this message will appear
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You made it!");
        }
        // If user grade is lower than 70 this message will appear
        if (grade < 70)
        {
            Console.WriteLine("OHH! You almost made it. But DO NOT give up!");
        }
    }
}