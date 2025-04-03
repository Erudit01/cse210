// A code template for the category of things known as Entry. The responsibility of an Entry is to store and manage journal entry data, including the date, prompt, and response.
public class Entry
{
    // The C# convention is to start member variables with an underscore _
    private string _date;
    private string _prompt;
    private string _response;

    // A special method, called a constructor that is invoked using the new keyword followed by the class name and parentheses.
    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    // A method that returns a formatted string representation of the entry.
    public override string ToString()
    {
        return $"Date: {_date} - Prompt: {_prompt}\n{_response}\n";
    }

    // A method that converts the entry into a text format suitable for saving to a file.
    public string ToText()
    {
        return $"{_date}#{_prompt}#{_response}";
    }
}