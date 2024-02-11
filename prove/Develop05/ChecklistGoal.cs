using System.Runtime;

public class ChecklistGoal : Goal
{
    private string _shortName;
    private string _description;
    private int _points;
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int amountCompleted, int target, int bonus) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        int points = _points;
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            points += _bonus;
            System.Console.WriteLine("You achieved your meta goal, good job!");
        }
        return points;
    }

    public override string GetDetailsString()
    {
        string checkbox = "[ ]";
        if (_amountCompleted >= _target)
        {
            checkbox = "[X]";
        }
        string oldString = base.GetDetailsString();
        return $"{checkbox} {oldString} ({_amountCompleted}/{_target}) Bonus: {_bonus}";
    }
    public override string GetStringRepresentation()
    {
        
        return $"{this.GetType()}|{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
    }
}