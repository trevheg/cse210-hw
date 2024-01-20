public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        // Creates a new journal entry from the user and adds it to the list of entries. 

        // Create a new entry object
        Entry newEntry = new Entry();
        // Get the current date 
        // add it to the entry object
        // and display it
        DateTime timeNow = DateTime.Now;
        newEntry._date = timeNow.ToShortDateString();
        Console.WriteLine(newEntry._date);
        // Get the prompt 
        // add it to the entry object
        // and display it
        PromptGenerator prompt = new PromptGenerator();
        newEntry._promptText = prompt.GetRandomPrompt();
        Console.WriteLine(newEntry._promptText);
        // Get the entry from the user
        // and add it to the entry object
        newEntry._entryText = Console.ReadLine();
        // Add the new entry to the List of entries
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        Console.WriteLine();
        for(int i = 0; i < _entries.Count; i++ )
        {
            int entryNumb = i + 1;
            Console.WriteLine(entryNumb);
            _entries[i].DisplayEntry();
            Console.WriteLine();
        }
        // foreach (Entry entry in _entries)
        // {
        //     entry.DisplayEntry();
        //     Console.WriteLine();
        // }
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

    public void EraseEntry()
    {
        // Erases an entry from _entries
        // Ask the user which entry they want to delete
        Console.WriteLine("Which journal entry do you wish to delete?");
        Console.Write("Please enter a number (Enter 0 to cancel): ");
        int userChoice = (int.Parse(Console.ReadLine()) - 1);
        // exit if the user chose 0
        if (userChoice == -1)
        {
            return;
        }
        else
        {
            // ask the user if they are sure
            Console.WriteLine("This is the selected entry:");
            _entries[userChoice].DisplayEntry();
            Console.WriteLine("Do you wish to Delete it? (y/n): ");
            string yesNo = Console.ReadLine();
            if (yesNo == "y")
            {
                Console.WriteLine("Deleting entry...");
                _entries.RemoveAt(userChoice);
                Console.WriteLine("Entry Deleted.");

            }
            else
            {
                return;
            }
        }

    }
}