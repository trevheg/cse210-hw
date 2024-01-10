using System;
using System.Collections.Concurrent;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        // Start by asking the user for the magic number. (In future steps, we will change this to have the computer generate a random number, but to get started, we'll just let the user decide what it is.)
        // Console.Write("What is the Magic Number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        // After the game is over, ask the user if they want to play again. Then, loop back and play the whole game again and continue this loop as long as they keep saying "yes".
        string playAgain = "yes";
        while (playAgain.Equals("yes"))
        {

        
            // Instead of having the user supply the magic number, generate a random number from 1 to 100.
            Random myRandom = new Random();
            int magicNumber = myRandom.Next(1, 101);

            // Add a loop that keeps looping as long as the guess does not match the magic number.
            // At this point, the user should be able to keep playing until they get the correct answer.
            int userGuess = -1;
            // Keep track of how many guesses the user has made and inform them of it at the end of the game.
            int userGuesses = 0;
            while(userGuess != magicNumber)
            {
                // Ask the user for a guess.
                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());

                // Using an if statement, determine if the user needs to guess higher or lower next time, or tell them if they guessed it.
                if (magicNumber < userGuess)
                {
                    Console.WriteLine("Lower");
                }
                else if (magicNumber > userGuess)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }

                userGuesses++;          
    
            }

            Console.WriteLine($"You made {userGuesses} guesses.");
            Console.Write("Do you want to play again? Write 'yes' or 'no': ");
            playAgain = Console.ReadLine();
            

        }
    }
}