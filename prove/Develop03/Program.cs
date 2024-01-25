using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        // Testing Word
        // Word myWord = new Word("test");
        // Console.WriteLine(myWord.GetDisplayText());
        // myWord.Hide();
        // Console.WriteLine(myWord.IsHidden());
        // Console.WriteLine(myWord.GetDisplayText());

        // Testing Reference
        Reference myReference = new Reference("James", 1, 5);
        Reference myReference2 = new Reference ("Matthew", 5, 14, 16);
        Reference myReference3 = new Reference ("James", 1, 5, 6);

        Console.WriteLine(myReference.GetDisplayText());
        Console.WriteLine(myReference2.GetDisplayText());
        Console.WriteLine(myReference3.GetDisplayText());

    }
}