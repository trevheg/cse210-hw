public class Reference
{
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int _lastVerse;
    public Reference(string book, int chapter, int firstVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
    }

    public Reference(string book, int chapter, int firstVerse, int lastVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
    }

    public string GetDisplayText()
    {
        // Return a string of the reference in the form "James 1: 5-6" if there is a first and last verse, and "James 1: 5" if there is only a first verse.

        if (_lastVerse > 0)
        {
            return (_book + " " + 
            _chapter.ToString() + ": " +
            _firstVerse.ToString() + 
            // I'm pleased with this bit of code. It divides the verses with a comma if there are two verses and with a hyphen if there are more. 
            ((_lastVerse == (_firstVerse + 1)) ? ", " : "-") +
            _lastVerse.ToString());
        }
        else
        {
            return (_book + " " + 
            _chapter.ToString() + ": " +
            _firstVerse.ToString());
        }


        
    }

}