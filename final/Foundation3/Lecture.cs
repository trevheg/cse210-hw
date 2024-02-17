
public class Lecture : Event
{
    private string _speakerName;
    private int _capacity;
    public Lecture(string title, string description, string dateTime, Address address, string speaker, int capacity) : base(title, description, dateTime, address)
    {
        _speakerName = speaker;
        _capacity = capacity;
    }
    public override void ListFullDetails()
    {
        ListStandardDetails();
        System.Console.WriteLine($"Lecturer: {_speakerName}");
        System.Console.WriteLine($"Room capacity: {_capacity}");

    }
}