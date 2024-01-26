using System;
using System.Collections.Generic;
using System.IO;

// Exceeding core requirements:
// I added a class called "Scriptures" (note the 's') that has a list with multiple Scripture objects in it. It has the following methods:
    // Load(): pulls a list of scriptures from a given filename (set in Main() to Scriptures.txt, since I didn't want to give that option to the user yet.)
    // Add(): allows the user to add a scripture to the list of scriptures. It adds the scripture to the list and the file. 
    // Choose(): Allows the user to choose which scripture they want to practice and lets them practice it. 

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;
        Scriptures scriptures = new Scriptures();
        string fileName = "Scriptures.txt";
        scriptures.Load(fileName);
        Console.Clear();
        Console.WriteLine("Welcome to Scripture Master!");

        while (userChoice != 3 && userChoice != 1)
        {
            Console.WriteLine(
                "Please make a selection. \n" +
                "1. Choose a scripture.\n" +
                "2. Add a scripture to the list.\n" +
                "3. Exit.");

            userChoice = int.Parse(Console.ReadLine());
            if (userChoice == 1)
            {
                scriptures.Choose();
            }
            else if (userChoice == 2)
            {
                scriptures.Add(fileName);
            }
            else if (userChoice == 3)
            {
                Console.Clear();
                Console.WriteLine("Good Bye!");
                
            }
            
        }


    }
}