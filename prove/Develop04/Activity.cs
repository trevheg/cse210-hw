public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity()
    {
        
    }

    public void DisplayStartingMessage()
    {

    }

    public void DisplayEndingMessage()
    {

    }

    public void ShowSpinner(int seconds)
    {
        var aniList = new List<string> {"|", "/", "-", "\\"};
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
        
    }
}