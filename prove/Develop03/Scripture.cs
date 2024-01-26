public class Scripture
{

    private Reference _reference;
    private List<Word> _text;
    private bool _isCompletelyHidden;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = new List<Word>();
        foreach (string word in text.Split(' '))
        {
            _text.Add(new Word(word));
        }       
        _isCompletelyHidden = false;
    }

    public void DisplayScripture()
    {
        Console.WriteLine(_reference.GetDisplayText());
        foreach (Word word in _text)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine();
    }

    public void HideWords (int toHide)
    {
        int shown = 0;
        foreach (Word word in _text)
        {
            if (word.IsShown())
            {
                shown++;
            }
        }
        Random rand = new Random();
        do
        {
            int toCheck = rand.Next(_text.Count);
            if (_text[toCheck].IsShown())
            {
                _text[toCheck].Hide();
                toHide--;
                shown--;
            }
        // Makes the loop stop trying to blank out words when the amount left to hide is 0, and also when there are 0 words left to hide.      
        } while (toHide > 0 && shown > 0);
        if (shown <= 0)
        {
            _isCompletelyHidden = true;
        }
        
    }

    public bool IsCompletelyHidden()
    {
        if (_isCompletelyHidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public Reference GetReference()
    {
        return _reference;
    }
}