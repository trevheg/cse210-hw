using System;
using System.IO;
using System.IO.Enumeration;


class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");

        Console.WriteLine("Welcome to Journal-matic.");
        

        int userChoice = 0;
        Journal journal = new Journal();
        bool entryMade = false;
        bool fileSaved = false;


        // The loop where the user makes their choices
        while (userChoice != 6)
        {
            // Show user their choices and take their decision.
            Console.WriteLine("Please make a selection:");
            Console.WriteLine("1. Open File.");
            Console.WriteLine("2. Display All Entries.");
            Console.WriteLine("3. Write New Entry.");
            Console.WriteLine("4. Delete an Entry.");
            Console.WriteLine("5. Save Entries To File.");
            Console.WriteLine("6. Quit.");
            Console.Write("What would you like to do? ");
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                // Opens the file
                // Maybe add a warning if they have made some entries and are going to put these out of order or something
                Console.Write("Please enter the name of your journal file: ");
                string fileName = Console.ReadLine();
                Console.WriteLine("Opening File...");
                journal.LoadFromFile(fileName);
                Console.WriteLine("File Opened.");

            }
            else if (userChoice == 2)
            {
                // Displays all the journal entries
                journal.DisplayAll();
            }
            else if (userChoice == 3)
            {
                // Write a new entry
                // Finish this one
                // Entry entry = new Entry();
                // journal.AddEntry(entry);
                journal.AddEntry();
                entryMade = true;
            }
            else if (userChoice == 4)
            {
                // delete an entry
                journal.EraseEntry();
            }
            else if (userChoice == 5)
            {
                // Save entries to file
                // Finish this one
                Console.Write("Please enter the name of the file: ");
                string fileName = Console.ReadLine();
                Console.WriteLine("Saving Entries...");
                journal.SaveToFile(fileName);
                Console.WriteLine("Entries Saved!");
                fileSaved = true;
            }
            else if (userChoice == 6)
            {
                // Exit
                // Finish this one
                // Consider adding a warning if they are exiting without saving
                if (entryMade == true && fileSaved == false)
                {
                    Console.Write("Are you sure you want to exit without saving your new entry? (y/n) ");
                    string yesNo = Console.ReadLine();
                    if (yesNo == "y")
                    {
                        Console.WriteLine("Good Bye!");
                    }
                    else
                    {
                        userChoice = 0;
                    }
                }
                else 
                {
                    Console.WriteLine("Good Bye!");
                }
                
            }
        }
        

    }
}