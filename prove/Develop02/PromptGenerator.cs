public class PromptGenerator
{
    public List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string> {
            "What are you thankful for today?",
            "What made you laugh today?",
            "What was the best conversation you had today?",
            "How did you improve your life today?",
            "Who did you think about today?"
        };
    }
    public string GetRandomPrompt()
    {
        // Pull a random prompt from _prompts and return it.
        Random rand = new Random();
        return _prompts[rand.Next(0, _prompts.Count)];
    }
}