using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        // This activity is mainly focus on about list 

        // Create a int list for user number
        List<int> numbers = new List<int>();

        // ---------------------------------------------------------------
        // Create a valuable to store user input number 
        int userNumber = -1;

        // Create a valuable to store total sum
        float total = 0;

        // Create a valuable to store an average number of the list
        float average = 0;

        // Create a valuable to store the largest number in the list
        int largestNumber = 0;

        // Create a valuable to store the smallest positive number in the list
        int smallestPosNumber = 999999999;
        // -------------------------------------------------------------------

        // Use while loop to get series of number from user
        while (userNumber != 0)
        {
            // Take user input
            Console.Write("Enter the number you like (enter 0 to quit!) : ");
            string userNum = Console.ReadLine(); // store the user input as string 
            userNumber = int.Parse(userNum); // Convert a string to int number 

            // Check user enter 0 or not if not 0 add into numbers list
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
            else
            {
                Console.WriteLine("Thank you! Here are some calculation of your number!");
            }
        }
        // Iterating though number list using foreach loops
        foreach (int number in numbers)
        {
            // using if statement to get the largest number 
            if (number > largestNumber)
            {
                largestNumber = number;
            }        

            // Get the smallest number from the list
            if (number < smallestPosNumber && number > 0 )
            {
                smallestPosNumber = number;
            }

            total += number; // plus all of the numbers in a list one by one

            // Get the average number from list 
            average = total / numbers.Count;
        }

        // Display the result 
        Console.WriteLine($"The sum of total is {total}");
        Console.WriteLine($"The average number is {average}");
        Console.WriteLine($"The largest number is {largestNumber}");
        Console.WriteLine($"The smallest positive number is {smallestPosNumber}");
        Console.WriteLine("The sorted number list is : ");

        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine($"{number}");
        }
    }
}   