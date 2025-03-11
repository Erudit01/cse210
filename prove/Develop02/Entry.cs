// A code template for the category of things known as Entry. The
// responsibility of an Entry is to.
public class Entry
{
    // The C# convention is to start member variables with an underscore _
    private string _date;
    private string _prompt;
    private string _response;

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    // A method that displays the person's full name as used in western 
    // countries or <given name family name>.
    public override string ToString()
    {
        return $"Date: {_date} - Prompt: {_prompt}\n{_response}\n";
    }

    // A method that displays the person's full name as used in western 
    // countries or <given name family name>.
    public string ToText()
    {
        return $"{_date}#{_prompt}#{_response}";
    }
}