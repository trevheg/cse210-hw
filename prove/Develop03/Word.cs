public class Word
{
    private string _text;
    private bool _display;
    private string _blankText;
    public Word(string text)
    {
        _text = text;
        _display = true;
        for (int i = 0; i < _text.Length; i++)
        {
            _blankText += "_";
        }
    }

    public string GetDisplayText()
    {
        if (_display == true)
        {
            return _text;
        } 
        else 
        {
            return _blankText;
        }       
    }

    public void Hide()
    {
        _display = false;
    }

    public bool IsShown()
    {
        if (_display == true )
        {
            return true;
        } 
        else
        {
            return false;
        }
    }
}