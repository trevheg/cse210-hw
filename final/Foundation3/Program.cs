using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>
        {
            new Lecture("A History of Object-Oriented Programming", "Professor Demetris Huel, noted computers historian, will tell us about the history of OOP.", "Mar 4, 2024 2:00 PM", new Address("6073 Olson Mews", "North Manley", "New York", 13722), "Professor Demetris Huel", 45),

            new Reception("Bill and Becky Smith's Wedding", "Bill and Becky Smith are getting married and are celebrating with us.", "Apr 30, 2024 7:00 PM", new Address("2215 Dicki Plaza", "New Mariane", "Minnesota", 15280), "adaline.pagac@gmail.com"),

            new OutdoorGathering("Ultimate Frisbee in the Park", "Come have fun, get some exercise, and make friends at the park.", "Mar 5, 2024 10:00 AM", new Address("McKenzie Park, 27025 Bednar Meadows", "Feeneymouth", "Minnesota", 70259), "sunny")
        };
        
        Console.Clear();
        foreach (Event e in events)
        {
            e.ListFullDetails();
            System.Console.WriteLine();
        }
    }
}