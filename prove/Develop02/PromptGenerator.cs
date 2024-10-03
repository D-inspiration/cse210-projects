using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public string _prompt;
    public List<string> _getRandomPrompt = new List<string>();

    public PromptGenerator()
    {
        _getRandomPrompt.Add("What was the highlight of your day?");
        _getRandomPrompt.Add("What are you grateful for today?");
        _getRandomPrompt.Add("What did you learn today?");
    }

    public string GetRandomPrompt()
    {
        var random = new Random();
        var index = random.Next(_getRandomPrompt.Count);
        return _getRandomPrompt[index];
    }
}
