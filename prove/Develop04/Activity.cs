public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {

    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to {_name}.");
        Console.WriteLine(_description);
        ShowSpinner(5);
        Console.Write("How many seconds would you like to do this? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();

    }

    public void DisplayEndingMessage()
    {
        // Console.Clear();
        Console.WriteLine($"You did the {_name} for {_duration} seconds. Good job!");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        var aniList = new List<string> { "|", "/", "-", "\\" };
        int aniPlace = 0;
        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(seconds);
        do
        {
            Console.Write(aniList[aniPlace]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            aniPlace++;
            if (aniPlace > 3)
            {
                aniPlace = 0;
            }
        } while (DateTime.Now < stopTime);

    }

    public void ShowCountDown(int seconds)
    {
        Console.Write("Get ready in: ");
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }
        Console.WriteLine();
    }
}