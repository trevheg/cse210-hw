public class Entry
{
    public Entry()
    {
        
    }
    public string _date;
    public string _promptText;
    public string _entryText;

    public void DisplayEntry()
    {
        Console.WriteLine(_date);       
        Console.WriteLine(_promptText);
        Console.WriteLine(_entryText);
    }
}