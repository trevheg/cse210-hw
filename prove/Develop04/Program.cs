using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        // Console.WriteLine(
        //     "Welcome to Mindfulness Master!\n" +
        //     "Pick one:\n" +
        //     " 1. Breathing Activity\n" +
        //     " 2. Reflecting Activity\n" +
        //     " 3. Listing Activity\n" + 
        //     " 4. Quit")\n;

        // BreathingActivity test
        BreathingActivity ba = new BreathingActivity();
        ba.Run();


        // activity.ShowSpinner() test
        // Activity activity = new Activity();
        // activity.ShowSpinner(8);


    }
}