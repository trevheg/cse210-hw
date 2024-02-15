using System.IO;

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
        do
        {
            DisplayPlayerInfo();
            
            Console.WriteLine(
                "\n" +
                "Menu Options:\n" +
                " 1. Create New Goal\n" +
                " 2. List Goals\n" +
                " 3. Save Goals\n" +
                " 4. Load Goals\n" +
                " 5. Record Event\n" +
                " 6. Delete Goal\n" +
                " 7. Quit"
            );
            Console.Write("Select a choice from the menu: ");
            int userAnswer = int.Parse(Console.ReadLine());
            Console.Clear();
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
                    DeleteGoal();
                    break;
                case 7:
                    userQuit = true;
                    System.Console.WriteLine("Good luck with your goals!");
                    System.Console.WriteLine("Good Bye!");
                    break;
            }
        } while  (!userQuit);
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }
    public void ListGoals()
    {
        System.Console.WriteLine("Your goals: ");
        int index = 1;
        foreach (Goal goal in _goals)
        {
            System.Console.WriteLine($"{index}. {goal.GetDetailsString()}");
            index++;
            System.Console.WriteLine("");
        }
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have zero goals.");
        }
    }
    public void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine(
            "What kind of goal do you want to make?\n" +
            " 1. One-time Goal\n" +
            " 2. Repeating Goal\n" +
            " 3. Number-of-times Goal\n" +
            " 4. Daily Goal\n"
        );
        Console.Write("Select a choice from the menu: ");
        int userAnswer = int.Parse(Console.ReadLine());
        Console.WriteLine("Please write the name of this goal:");
        string name = Console.ReadLine();
        Console.WriteLine("Please write a short description of this goal:");
        string description = Console.ReadLine();
        Console.WriteLine("Please input how many points this goal is worth:");
        int points = int.Parse(Console.ReadLine());
        switch (userAnswer)
        {
            case 1:
                _goals.Add(new SimpleGoal(name, description, points, false));
                break;
            case 2:
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case 3:
                Console.WriteLine("Please enter how many times you want to complete this goal:");
                int target = int.Parse(Console.ReadLine());
                int complete = 0;
                Console.WriteLine("Please enter your bonus points if you manage to do it that many times:");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, complete, target, bonus));
                break;
            case 4:
                _goals.Add(new DailyGoal(name, description, points, false));

                break;
        }
        Console.Clear();
        System.Console.WriteLine("Goal Created:");
        System.Console.WriteLine($"{_goals.Last().GetDetailsString()}");
    }
    public void RecordEvent()
    {
        ListGoals();
        Console.Write("Which goal did you accomplish? ");
        int userChoice = int.Parse(Console.ReadLine()) - 1;
        Console.Clear();
        int points = _goals[userChoice].RecordEvent();
        _score += points;
        System.Console.WriteLine("Good Job!");
        Console.WriteLine($"You earned {points} points.");
    }

    public void SaveGoals()
    {
        string fileName = "goals.txt";
        using (StreamWriter goalsFile = new StreamWriter(fileName))
        {
            goalsFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                goalsFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        System.Console.WriteLine($"Goals saved to {fileName}");
    }
    public void LoadGoals()
    {
        _goals.Clear();
        string filename = "goals.txt";
        string[] fileLines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(fileLines[0]);

        for (int i = 1; i < fileLines.Length; i++)
        {
            string[] goalParts = fileLines[i].Split("|");
            switch (goalParts[0])
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(goalParts[1], goalParts[2], int.Parse(goalParts[3]), bool.Parse(goalParts[4])));
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(goalParts[1], goalParts[2], int.Parse(goalParts[3])));
                    break;
                case "ChecklistGoal":
                    _goals.Add(new ChecklistGoal(goalParts[1], goalParts[2], int.Parse(goalParts[3]), int.Parse(goalParts[4]), int.Parse(goalParts[5]), int.Parse(goalParts[6])));
                    break;
                case "DailyGoal":
                    _goals.Add(new DailyGoal(goalParts[1], goalParts[2], int.Parse(goalParts[3]), bool.Parse(goalParts[4]), DateTime.Parse(goalParts[5]).Date));
                    break;
            }
        }
        System.Console.WriteLine($"Goals loaded from {filename}");


    }

    public void DeleteGoal()
    {
        ListGoals();
        System.Console.Write("Which goal would you like to delete? ");
        int userAnswer = int.Parse(Console.ReadLine()) - 1;
        Console.Clear();
        System.Console.WriteLine($"This is the goal you selected:");
        System.Console.WriteLine($"{_goals[userAnswer].GetDetailsString()}");
        System.Console.Write("Are you sure you want to delete this goal? (y/n) ");
        string userResponse = Console.ReadLine().ToLower();
        _goals.RemoveAt(userAnswer);
        Console.Clear();
        System.Console.WriteLine("Goal Deleted");

    }   
}
