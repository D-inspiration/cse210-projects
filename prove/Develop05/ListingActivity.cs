using System;
using System.Collections.Generic;


// Derived class for Listing activity
public class ListingActivity : Activity
{
    private List<string> _originalPrompts;
    private List<string> _prompts;
    private List<string> _userList;
    private Random _random;

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _originalPrompts = new List<string>
        {
            "List things you are grateful for...",
            "Write about a happy memory...",
            "Describe a place you love...",
            "What are your goals for the day/week/month?",
            "Reflect on a challenging experience..."
        };
        _prompts = new List<string>();
        _random = new Random();
        _userList = new List<string>();
    }

    public override void DisplayStartingMessage()
    {
        base.DisplayStartingMessage();
        Console.WriteLine("Get ready to list...");
    }

    public override void DisplayEndingMessage()
    {
        base.DisplayEndingMessage();
        Console.WriteLine("You have completed the listing activity!");
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(2);
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.WriteLine("press any button when you're ready to start...");
        Console.ReadKey(true); // Wait for Enter key press
        DateTime startTime = DateTime.Now;
        List<string> userList = new List<string>();
        bool timeElapsed = false;
        while (!timeElapsed)
        {
            userList = GetListFromUser(this.Duration);
            timeElapsed = (DateTime.Now - startTime).TotalSeconds >= (this.Duration);
        }
        Console.WriteLine("Time's up!");
        Console.WriteLine("Your list:");
        foreach (string item in userList)
        {
            Console.WriteLine(item);
        }
        DisplayEndingMessage();
    }


    private string GetRandomPrompt() 
    { 
        if (_prompts.Count > 0) 
        { 
            var prompt = _prompts[0]; 
            _prompts.RemoveAt(0); 
            return prompt; 
        } 
        else 
        { 
            _prompts = _originalPrompts.ToList(); 
            return GetRandomPrompt(); 
        } 
    }



    private List<string> GetListFromUser(int duration)
    {
        Console.WriteLine($"Enter your list items (you have {duration} seconds to finish):");
        List<string> userList = new List<string>();
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            string userInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(userInput))
            {
                userList.Add(userInput);
            }
        }


        return userList;
    }


}
