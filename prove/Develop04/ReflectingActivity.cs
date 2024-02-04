public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    private List<int> _alreadyUsedQuestion;
    private List<int> _alreadyUsedPrompt;


    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts = new List<string>{
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _questions = new List<string>{
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        _alreadyUsedQuestion = new List<int>();
        _alreadyUsedPrompt = new List<int>();
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random r = new Random();
        int newPrompt;
        bool containsPrompt;

        do
        {
            newPrompt = r.Next(_prompts.Count);
            if (!_alreadyUsedPrompt.Contains(newPrompt))
            {
                _alreadyUsedPrompt.Add(newPrompt);
                containsPrompt = false;
            }
            else
            {
                containsPrompt = true;
            }
            if (_alreadyUsedPrompt.Count == _prompts.Count)
            {
                _alreadyUsedPrompt.Clear();
            }
        } while (!containsPrompt);

        newPrompt = r.Next(_prompts.Count);
        return _prompts[newPrompt];
    }

    public string GetRandomQuestion()
    {
        Random r = new Random();
        int newPrompt;
        bool containsPrompt;
        do
        {
            newPrompt = r.Next(_questions.Count);
            if (!_alreadyUsedQuestion.Contains(newPrompt))
            {
                _alreadyUsedQuestion.Add(newPrompt);
                containsPrompt = false;
            }
            else
            {
                containsPrompt = true;
            }
            if (_alreadyUsedQuestion.Count == _prompts.Count)
            {
                _alreadyUsedQuestion.Clear();
            }

        } while (containsPrompt);
        return _questions[newPrompt];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        ShowCountDown(9);
        Console.Clear();
        Console.WriteLine(prompt);


    }
    public void DisplayQuestions()
    {

        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);
        do
        {
            System.Console.WriteLine(GetRandomQuestion());
            ShowSpinner(5);
        } while (DateTime.Now < stopTime);
    }
}