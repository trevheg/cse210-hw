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

    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
    {
        return true;
    }
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