// A code template for the category of things known as Scripture. The responsibility of a Scritpure is to
class Scripture
{
    // The C# convention is to start member variables with an underscore _
    private Reference _reference;
    private List<Word> _words;

    // A special method, called a constructor that is invoked using the new keyword followed by the class name and parentheses.
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }
    // A method that
    public void HideWords(Random random, int count)
    {
        visibleWords = _words.Where(w => !w.IsHidden).ToList();
        
        for (int i = 0; i < 3; i++)
        {
            visibleWords[random.Next(visibleWords.Count)].Hide();
        }
    }
    // A method that
    public bool IsCompletelyHidden()
    {
        return _words.All((w) => w.IsHidden);
    }
    // A method that
    public string GetRenderedText()
    {
        return $"{_reference} {string.Join(" ", _words)}";
    }
}