using System;

// Above and Beyond: 
// added a function to remove a goal. 
// Added a DailyGoal class. DailyGoal._isComplete resets to false if it is accessed at least one day after it is completed.
class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();

    }
}