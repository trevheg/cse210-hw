public class ChecklistGoal : Goal
{
    public ChecklistGoal(string name, string description, int points) : base(name, description, points)
    {
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
        return "";
    }
    public override string GetStringRepresentation()
    {
        return "";
    }
}