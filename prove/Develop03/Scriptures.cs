using System.Net.Quic;

public class Scriptures
{
    private List<Scripture> _scriptures;

    public Scriptures()
    {
        _scriptures = new List<Scripture>();
    }

    public void Load(string fileName)
    {   
        // pulls the scriptures saved in the file.      
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            string book = parts[0];
            int chapter = int.Parse(parts [1]);
            int verse = int.Parse(parts[2]);
            int lastVerse = int.Parse(parts[3]);
            string text = parts[4];
            Reference reference;
            if (verse == lastVerse)
            {
                reference = new Reference(book, chapter, verse);
            } else {
                reference = new Reference(book, chapter, verse, lastVerse);
            }
            
            Scripture scripture = new Scripture(reference, text);
            _scriptures.Add(scripture);
        }
    }

    public void Add(string fileName)
    {
        // Adds a new scripture to the saved file and makes it available to study. 
        Console.Clear();
        Console.WriteLine("Please enter the book name:");
        string book = Console.ReadLine();
        Console.WriteLine("Please enter the chapter number:");
        int chapter = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the first verse number:");
        int verse = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the last verse number (if there is only one verse, enter the first verse again):");
        int lastVerse = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the text of the scripture:");
        string text = Console.ReadLine();
        Console.Clear();

        // Save to the file
        using (StreamWriter outputFile = new StreamWriter(fileName, append: true))
        {
            outputFile.WriteLine(
                book + "|" +
                chapter + "|" +
                verse + "|" +
                lastVerse + "|" +
                text
            );
        }

        // add the scripture to the scripture list
        Reference reference;
        if (verse == lastVerse)
        {
            reference = new Reference(book, chapter, verse);
        } else 
        {
            reference = new Reference(book, chapter, verse, lastVerse);
        }
        Scripture scripture = new Scripture(reference, text);
        _scriptures.Add(scripture);
    }

    public void Choose()
    {
        // The user chooses which scripture to practice and practices it.

        // Shows the user the saved scriptures.
        Console.Clear();
        Console.WriteLine("Here are your saved scriptures:\n");
        int scripNum = 1;
        foreach (Scripture script in _scriptures)
        {
            Console.Write(scripNum + ". ");
            scripNum++;
            Console.WriteLine(script.GetReference().GetDisplayText());            
        }

        // The user chooses which scripture
        Console.WriteLine("\nWhich will you practice?\n"
        + "(Type '0' to cancel.)");
        int userChoice = int.Parse(Console.ReadLine());
        if (userChoice == 0)
        {
            Console.Clear();
            Console.WriteLine("Good bye!");
            return;
        }
        Scripture scripture = _scriptures[userChoice - 1];

        // The user decides how many words to clear each time
        Console.WriteLine("How many words would you like to hide each time?");
        int hidden = int.Parse(Console.ReadLine());
        
        // The scripture is printed out and has words removed each loop. 
        // The user may quit by typing "quit"
        Console.Clear();
        scripture.DisplayScripture();
        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine(
                "\nPress ENTER to remove words," +  "\nor Type 'quit' to quit.");
            string userQuit = Console.ReadLine();
            if (userQuit == "quit")
            {
                break;
            }
            scripture.HideWords(hidden);
            Console.Clear();
            scripture.DisplayScripture();
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Good Bye!");
            }

        }

    }
}