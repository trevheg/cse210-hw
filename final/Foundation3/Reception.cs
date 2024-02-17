
public class Reception : Event
{
    string _email;
    public Reception(string title, string description, string dateTime, Address address, string email) : base(title, description, dateTime, address)
    {
        _email = email;
    }

    public override void ListFullDetails()
    {
        ListStandardDetails();
        System.Console.WriteLine($"To RSVP, email: {_email}");

    }
}