// A code template for the category of things known as Journal. The
// responsibility of a Journal is to.
using Microsoft.VisualBasic;

public class Journal
{
    // The C# convention is to start member variables with an underscore _
    private List<Entry> entries = new List<Entry>();

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public Journal()
    {
    }

    // A method that displays the person's full name as used in eastern 
    // countries or <family name, given name>.
    public void AddEntry(string prompt, string response)
    {
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        Entry entry = new Entry(date, prompt, response);
        entries.Add(entry);
    }

    // A method that displays the person's full name as used in western 
    // countries or <given name family name>.
    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName, false))
        {
            foreach (Entry entry in entries)
                writer.WriteLine(entry.ToText());
        }
    }

    // A method that displays the person's full name as used in western 
    // countries or <given name family name>.
    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    // A method that displays the person's full name as used in western 
    // countries or <given name family name>.
    public void ReadFromFile(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split('#');
            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];
            Entry entry = new Entry(date, prompt, response);
            entries.Add(entry);
        }
    }
}