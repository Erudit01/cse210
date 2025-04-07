// A code template for the category of things known as Scripture. The responsibility of a Scripture is to
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

    // A method that hides a specified number of words randomly
    public void HideWords(Random random, int count)
    {
        var visibleWords = _words.Where(w => !w.IsHidden).ToList();

        // Ensure we don't try to hide more words than are visible
        count = Math.Min(count, visibleWords.Count);

        for (int i = 0; i < count; i++)
        {
            var wordToHide = visibleWords[random.Next(visibleWords.Count)];
            wordToHide.Hide();
            visibleWords.Remove(wordToHide); // Remove the word from the list to avoid hiding it again
        }
    }

    // A method that checks if all words are hidden
    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden);
    }
    
    // A method that renders the scripture text
    public string GetRenderedText()
    {
        return $"{_reference} {string.Join(" ", _words)}";
    }
}