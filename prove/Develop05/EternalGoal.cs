public class EternalGoal : Goal 
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
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
        string checkbox = "[ ]";
        // if (IsComplete())
        // {
        //     checkbox = "[X]";
        // }
        string oldString = base.GetDetailsString();
        return $"{checkbox} {oldString}";
    }
    public override string GetStringRepresentation()
    {
        return "";
    }
}