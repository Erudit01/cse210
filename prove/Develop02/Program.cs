using System;
class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator aPrompt = new PromptGenerator();
        Console.WriteLine("Welcome to the Journal Program!");
        while (true)
        {
            Console.Write("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Exit\nWhat would you like to do? ");
            
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                string prompt = aPrompt.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();
                myJournal.AddEntry(prompt, response);
            }
            else if (choice == "2")
            {
                myJournal.DisplayEntries();
            }
            else if (choice == "3")
            {
                Console.WriteLine("What's the filename?");
                string fileName = Console.ReadLine();
                myJournal.ReadFromFile(fileName);
            }
            else if (choice == "4")
            {
                Console.WriteLine("What's the filename?");
                string fileName = Console.ReadLine();
                myJournal.SaveToFile(fileName);
            }
            else if (choice == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again.");
            }
        }
    }
}