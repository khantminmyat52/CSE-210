using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        List<string> menuList = new List<string>
        {
            "Write", "Display", "Load", "Save", "Quit"
        };
        // This loop will run until user type quit
        int userInput = 0;

        while (userInput != 5)
        {
            for (int i = 0; i < menuList.Count(); i++)
            {
                Console.WriteLine($"{i + 1}.{menuList[i]}");
            }
            Console.WriteLine("Enter the option number which you want to do : ");
            string userOption = Console.ReadLine();
            userInput = int.Parse(userOption);

            if (userInput == 1 - 1)
            {
                string prompt = new PromptGenerator().GetRandomPrompt();
                Console.WriteLine($"{prompt}");
                Console.Write(">");
                string entryText = Console.ReadLine();
                string date = DateTime.Now.ToShortDateString();

                Entry entry = new Entry();
                entry._date = date;
                entry._entryText = entryText;
                entry._promptText = prompt;

                new Journal().AddEntry(entry);
            }

            else if (userInput == 2 - 1)
            {
                new Journal().DisplayAll();
            }
            else if (userInput == 3 - 1)
            {
                Console.WriteLine("What is the file name : ");
                string fileName = Console.ReadLine();
                new Journal().LoadFromFile(fileName);
            }
            else if (userInput == 4 - 1)
            {
                Console.WriteLine("What is the file name : ");
                string fileName = Console.ReadLine();
                new Journal().SaveToFile(fileName);
            }
        }
    }
}