using System;
// Exceeding requirements
// ReflectingActivity.GetRandomQuestions ensures that no duplicate questions are asked
// BreathingActivity has a function called Breathe which shows an expanding and retracting bar that guides users through breathing. 
class Program
{
    static void Main(string[] args)
    {
        BreathingActivity ba = new BreathingActivity();
        ReflectingActivity ra = new ReflectingActivity();
        ListingActivity la = new ListingActivity();
        Console.Clear();
        bool userQuit = false;
        do
        {
            Console.WriteLine(
                "Welcome to Mindfulness Master!\n" +
                "Pick one:\n" +
                " 1. Breathing Activity\n" +
                " 2. Reflecting Activity\n" +
                " 3. Listing Activity\n" +
                " 4. Quit");
            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    ba.Run();
                    break;
                case 2:
                    ra.Run();
                    break;
                case 3:
                    la.Run();
                    break;
                case 4:
                    Console.WriteLine("GoodBye!");
                    userQuit = true;
                    break;

            }


        } while (!userQuit);


        // // activity.ShowSpinner() test
        // Activity activity = new Activity();
        // activity.ShowSpinner(8);


    }

}