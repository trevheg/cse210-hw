public class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<int> _alreadyUsed;


    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = new List<string>{
            "Who are people that you appreciate?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "What are personal strengths of yours?",
            "Who are some of your personal heroes?",
        };
        _alreadyUsed = new List<int>();

    }

    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        ListEndMessage(GetListFromUser().Count);
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random r = new Random();
        int newPrompt;
        bool containsPrompt;

        do 
        {
            newPrompt = r.Next(_prompts.Count);
            if (!_alreadyUsed.Contains(newPrompt))
            {
                _alreadyUsed.Add(newPrompt);
                containsPrompt = false;
            }
            else
            {
                containsPrompt = true;
            }
            
            if (_alreadyUsed.Count == _prompts.Count)
            {
                _alreadyUsed.Clear();
            }
        } while (!containsPrompt);

        System.Console.WriteLine(_prompts[newPrompt]);
        ShowCountDown(5);
        Console.Clear();
        System.Console.WriteLine(_prompts[newPrompt]);

    }

    public List<string> GetListFromUser()
    {
        var userList = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);
        do
        {
            Console.Write("> ");
            userList.Add(Console.ReadLine());
        } while (DateTime.Now < stopTime);

        return userList;
    }
    public void ListEndMessage(int items)
    {
        Console.WriteLine($"You listed {items} items.");
    }
}