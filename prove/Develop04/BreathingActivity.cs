public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        // you can assign the attributes from the parent constructor values here
    }

    public void Run()
    {
        Console.WriteLine(
            "Welcome to the breathing activity.\n" +
            "How many seconds would you like to practice breathing? ");
        int seconds = int.Parse(Console.ReadLine());

        Console.WriteLine(
            "In a moment I will ask you to breathe in and out with the animation.\n" +
            "Breathe in as the bar expands and breathe out as it contracts. "
        );

        ShowCountDown(5);
        var barList = new List<string>{};

        Console.Write("[        ]\b\b\b\b\b\b\b\b\b");


        

        
    }
}