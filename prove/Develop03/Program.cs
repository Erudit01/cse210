using System;

class Program
{
    static void Main()
    {
        Library library = new Library("scriptures.txt");
        Random random = new Random();
        
        while (true)
        {
            Scripture scripture = library.GetRandomScripture(random);
            if (scripture == null)
            {
                Console.WriteLine("No scriptures found.");
                return;
            }

            while (!scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetRenderedText());
                Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
                string input = Console.ReadLine()?.Trim().ToLower();

                if (input == "quit") return;

                scripture.HideWords(random, 3);
            }
        }
    }
}