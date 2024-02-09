using System.Runtime.InteropServices;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        // This function has the main loop with the main menu.
        bool userQuit = false;
        Console.Clear();
        System.Console.WriteLine("Welcome to Goalmaster!");
        while (!userQuit)
        {
            Console.WriteLine(
                $"You have {_score} points.\n\n" +
                "Menu Options:\n" +
                " 1. Create New Goal\n" +
                " 2. List Goals\n" +
                " 3. Save Goals\n" +
                " 4. Load Goals\n" +
                " 5. Record Event\n" +
                " 6. Quit"
            );
            Console.Write("Select a choice from the menu: ");
            int userAnswer = int.Parse(Console.ReadLine());
            switch (userAnswer)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoals();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    userQuit = true;
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {

    }

    public void ListGoals()
    {
        int index = 0;
        foreach (Goal goal in _goals)
        {
            System.Console.WriteLine($"{index}. {goal.GetDetailsString()}");
            index++;
            System.Console.WriteLine("");
        }
    }


    public void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine(
            "What kind of goal do you want to make?\n" +
            " 1. One-time Goal\n" +
            " 2. Repeating Goal\n" +
            " 3. Number-of-times Goal\n"
        );
        Console.Write("Select a choice from the menu: ");
        int userAnswer = int.Parse(Console.ReadLine());
        Console.WriteLine("Please write the name of this goal:");
        string name = Console.ReadLine();
        System.Console.WriteLine("Please write a short description of this goal:");
        string description = Console.ReadLine();
        System.Console.WriteLine("Please input how many points this goal is worth:");
        int points = int.Parse(Console.ReadLine());
        switch (userAnswer)
        {
            case 1:
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case 2:
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case 3:
                System.Console.WriteLine("Please enter how many times you want to complete this goal:");
                int target = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Please enter your bonus points if you manage to do it that many times:");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
        }
    }

    public void RecordEvent()
    {

    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {

    }
}