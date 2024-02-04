public class BreathingActivity : Activity
{
   
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "You will follow along with a breathing exercise.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Breathe();
        DisplayEndingMessage();
    }

    public void Breathe()
    {     
        Console.WriteLine(
            "In a moment I will ask you to breathe in and out with the animation.\n" +
            "Breathe in as the bar expands and breathe out as it contracts. "
        );  
        Console.Write("Get ready in: ");

        ShowCountDown(5);   
        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);
        Console.Clear();
        Console.WriteLine("Breath in as the bar expands and breathe out as it contracts.");
        Console.Write("[        ]\b\b\b\b\b\b\b\b\b");
        do
        {
            for (int i = 0; i < 7; i++)
            {
                Thread.Sleep(600);
                Console.Write("*");
            } 
            for (int i = 7; i > 0; i--)
            {
                Thread.Sleep(1200);
                Console.Write("\b \b");
            } 
        } while (DateTime.Now < stopTime);

    }
}