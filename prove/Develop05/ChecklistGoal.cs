using System.Runtime;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        int points = 0;
        if (_amountCompleted == _target)
        {
            points += base.RecordEvent();
            points += _bonus;
        }
        else if (_amountCompleted < _target)
        {
        points += base.GetPoints();
        }
        _amountCompleted++;
        return points;
    }
    // public override bool IsComplete()
    // {
    //     return true;
    // }
    public override string GetDetailsString()
    {
        string checkbox = "[ ]";
        if (IsComplete())
        {
            checkbox = "[X]";
        }
        string oldString = base.GetDetailsString();
        return $"{checkbox} {oldString} ({_amountCompleted}/{_target}) Bonus: {_bonus}";
    }
    public override string GetStringRepresentation()
    {
        return "";
    }
}