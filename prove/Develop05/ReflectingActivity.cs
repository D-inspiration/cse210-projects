using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public class ReflectingActivity : Activity
{
    private List<string> _questions;
    private List<string> _originalQuestions;
    private List<string> _userAnswers;
    private Random _random;

    public ReflectingActivity(string name, string description, int duration) 
        : base(name, description, duration)
    {
        _originalQuestions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        };
        _userAnswers = new List<string>();
        _questions = new List<string>();
        _random = new Random();
    }

    public override void DisplayStartingMessage()
    {
        base.DisplayStartingMessage();
        Console.WriteLine("Get ready to reflect...");
    }

    public override void DisplayEndingMessage()
    {
        base.DisplayEndingMessage();
        Console.WriteLine("You have completed the reflecting activity!");
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(2);
        DateTime startTime = DateTime.Now;
        // Show a random prompt
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);

        // Show questions until duration is reached
        while ((DateTime.Now - startTime).TotalSeconds < Duration)
        {
            string question = GetRandomQuestion();
            Console.WriteLine(question);
            // string answer = GetAnswerFromUser();
            // _userAnswers.Add(answer);
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        List<string> prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        };
        return prompts[_random.Next(prompts.Count)];
    }

    
    private string GetRandomQuestion()
    {
        string question = "";
        if (_questions.Count == 0)
        {
            _questions = new List<string>(_originalQuestions);
        }
        question = _questions[_random.Next(_questions.Count)];
        _questions.Remove(question);
        return question;
    }


    // private string GetAnswerFromUser()
    // {
    //     Console.Write("Your answer: ");
    //     return Console.ReadLine();
    // }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
