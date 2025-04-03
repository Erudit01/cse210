// A code template for the category of things known as Reference. The responsibility of a Reference is to represent a scripture reference, including the book, chapter, and verse(s).
class Reference
{
    // The C# convention is to start member variables with an underscore _
    private string _book;
    private int _chapter;
    private int _verse;
    private int? _endVerse;
        // A special method, called a constructor that is invoked using the new keyword followed by the class name and parentheses.
        public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    // A special method, called a constructor that is invoked using the new keyword followed by the class name and parentheses.
        public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }
    // A method that returns the formatted reference as a string. If there is no ending verse, it returns the format "Book Chapter:Verse".
    public string GetReference()
    {
        if (_endVerse == null)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}