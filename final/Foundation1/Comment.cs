public class Comment
{
    // Stores the information about a comment on a YouTube Video

    string _name;
    string _text;

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public string GetName()
    {
        return _name;
    }
    public string GetText()
    {
        return _text;
    }
}