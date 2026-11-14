using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Journal theJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        int choice = 0;

        Console.WriteLine("Welcome to the Journal Program!");

        // Main menu loop
        while (choice != 5)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string responseStr = Console.ReadLine();
            if (int.TryParse(responseStr, out choice))
            {
                if (choice == 1)
                {
                    // Get a random prompt and display it to the user
                    string prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string userEntry = Console.ReadLine();

                    // CREATIVITY REQUIREMENT: Prompting user for their mood/emotional state to store alongside the entry.
                    Console.Write("How are you feeling today? (e.g., Happy, Grateful, Reflective): ");
                    string userMood = Console.ReadLine();

                    string currentDate = DateTime.Now.ToShortDateString();

                    // Create a new Entry object and assign values
                    Entry newEntry = new Entry();
                    newEntry._date = currentDate;
                    newEntry._promptText = prompt;
                    newEntry._entryText = userEntry;
                    newEntry._mood = userMood; // Assigning the creativity field

                    theJournal.AddEntry(newEntry);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("\n--- Journal Entries ---");
                    theJournal.DisplayAll();
                }
                else if (choice == 3)
                {
                    Console.Write("What is the filename to load from? ");
                    string filename = Console.ReadLine();
                    theJournal.LoadFromFile(filename);
                }
                else if (choice == 4)
                {
                    Console.Write("What is the filename to save to? ");
                    string filename = Console.ReadLine();
                    theJournal.SaveToFile(filename);
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}