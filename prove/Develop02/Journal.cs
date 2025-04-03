// A code template for the category of things known as Journal. The responsibility of a Journal is to manage a collection of entries, allowing users to add, display, save, and load journal
// entries.
public class Journal
{
    // The C# convention is to start member variables with an underscore _
    private List<Entry> _entries = new List<Entry>();

    // A special method, called a constructor that is invoked using the new keyword followed by the class name and parentheses.
    public Journal()
    {
    }

    // A method that adds a new entry to the journal with the given prompt and response.
    public void AddEntry(string prompt, string response)
    {
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        Entry entry = new Entry(date, prompt, response);
        _entries.Add(entry);
    }

    // A method that saves all journal entries to a specified file.
    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName, false))
        {
            foreach (Entry entry in _entries)
                writer.WriteLine(entry.ToText());
        }
    }

    // A method that displays all journal entries to the console.
    public void DisplayEntries()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    // A method that reads journal entries from a specified file and adds them to the journal.
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
            _entries.Add(entry);
        }
    }
}