using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Activity> activities = new List<Activity>
        {
            new Running("Feb 2, 2024", 27, 5000),
            new StationaryBicycle("Jan 30, 2024", 36, 24),
            new SwimmingLaps("Jan 31, 2024", 20, 18)
        };

        foreach (Activity activity in activities)
        {
            System.Console.WriteLine(activity.GetSummary());
        }
    }
}