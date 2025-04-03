// A code template for the category of things known as PromptGenerator. The responsibility of a PromptGenerator is to generate random prompts for journaling or reflection.
public class PromptGenerator
{
    // A special method, called a constructor that is invoked using the new keyword followed by the class name and parentheses.
    public PromptGenerator()
    {
    }

    // A method that returns a random prompt from a predefined list of prompts.
    public string GetRandomPrompt()
    {
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of your day?",
            "How did I see the hand of the Lord in my life today?",
            "What challenges did you face today?",
            "What was the strongest emotion I felt today?",
            "What is something new you learned?",
            "Describe a moment that made you smile.",
            "What are you grateful for today?",
            "If I had one thing I could do over today, what would it be?"
        };
        Random random = new Random();
        return prompts[random.Next(prompts.Count)];
    }
}