using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        var aniList = new List<string> {"|", "/", "-", "\\"};
        int aniPlace = 0;
        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(5);
        do
        {
            Console.Write(aniList[aniPlace]); 
            Thread.Sleep(200);
            Console.Write("\b \b");
            aniPlace++;
            if (aniPlace > 2)
            {
                aniPlace = 0;
            }
        } while (DateTime.Now < stopTime);

    }
}