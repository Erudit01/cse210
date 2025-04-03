// A code template for the category of things known as Word. The responsibility of a Word is to represent a single word and manage its visibility (hidden or shown).
class Word
{
    // The C# convention is to start member variables with an underscore _
    private string _word;
    private bool _hidden;

    // A special method, called a constructor that is invoked using the new keyword followed by the class name and parentheses.
    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }
    // A method that hides the word by setting the _hidden variable to true.
        public void Hide()
    {
        _hidden = true;
    }
    // A method that returns the rendered text of the word. If the word is hidden, it returns underscores (_) matching the length of the word.
        public string GetRenderedText()
    {
        return _hidden ? new string('_', _word.Length) : _word;
    }
}