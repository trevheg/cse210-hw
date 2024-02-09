public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    // public override int RecordEvent()
    // {
    // }
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
        return $"{checkbox} {oldString}";
    }
    public override string GetStringRepresentation()
    {
        return "";
    }
}