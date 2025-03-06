using System;
class Program
{
    static void Main(string[] args)
    {

        string cont = "yes";

        while (cont == "yes" || cont == "y")
        {
            // For Parts 1 and 2, where the user specified the number...
            // Console.Write("What is the magic number? ");
            // int magicNumber = int.Parse(Console.ReadLine());
            
            // For Part 3, where we use a random number
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;

            int gCounter = 1;

            // We could also use a do-while loop here...
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher\n");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower\n");
                }
                else
                {
                    Console.Write($"\nYou guessed it!\nYou guessed this many times: {gCounter}\n");
                }

                gCounter += 1;
            }

            Console.Write("Do you want to play again? ");
            cont = Console.ReadLine().ToLower();
        }
    }
}