public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    // public void AddEntry(Entry newEntry)
    public void AddEntry()
    {
        Entry newEntry = new Entry();
        // Get the date
        DateTime timeNow = DateTime.Now;
        newEntry._date = timeNow.ToShortDateString();
        Console.WriteLine(newEntry._date);
        // Get the prompt
        PromptGenerator prompt = new PromptGenerator();
        newEntry._promptText = prompt.GetRandomPrompt();
        Console.WriteLine(newEntry._promptText);
        // Get the entry
        newEntry._entryText = Console.ReadLine();
        // Add the new entry to the List of entries
        _entries.Add(newEntry);

    }

    public void DisplayAll()
    {
        Console.WriteLine();
        foreach(Entry dayEntry in _entries)
        {
            dayEntry.DisplayEntry();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(
                    entry._date + "|" +
                    entry._promptText + "|" +
                    entry._entryText);

            }
        }
        
    }

    public void LoadFromFile(string fileName)
    {
        // This method takes all the journal entries from the given file and puts them as Entrys in a List

        // Open the file and get each journal entry as a string in an array
        string[] lines = System.IO.File.ReadAllLines(fileName);
        // now separate the strings into the parts of the journal entries
        foreach (string line in lines)
        {
            Entry entry = new Entry();
            string[] entryParts = line.Split("|");
            entry._date = entryParts[0];
            entry._promptText = entryParts[1];
            entry._entryText = entryParts[2];
            _entries.Add(entry);
        }
    }
}