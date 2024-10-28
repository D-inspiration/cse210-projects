using System;
using System.Collections.Generic;
using System.Threading;

// Base class for all activities
public class Activity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Duration { get; set; }

    
    public Activity(string name, string description, int duration)
    {
        Name = name;
        Description = description;
        Duration = duration;
    }

    public virtual void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {Name} activity...");
        Console.WriteLine(Description);
        Console.WriteLine($"Duration: {Duration} seconds");
    }

    public virtual void DisplayEndingMessage()
    {
        Console.WriteLine($"Ending {Name} activity...");
        Console.WriteLine("You have completed the activity!");
    }

    public void ShowSpinner(int seconds)
    {
        Console.WriteLine("Spinner...");
        var spinnerChars = new[] { '+', 'x' };
        foreach (var _ in Enumerable.Range(0, seconds))
        {
            foreach (var spinnerChar in spinnerChars)
            {
                Console.Write(spinnerChar);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
    }


    public void ShowCountDown(int seconds)
    {
        // Console.WriteLine("Countdown...");
        for (int i = seconds; i > 0; i--)
        {
            Console.Write("\r{0}", i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public int CountDown(int seconds) 
    { 
        Console.WriteLine("Countdown..."); 
        for (int i = seconds; i > 0; i--) 
        { 
            Console.Write("\r{0}", i); 
            Thread.Sleep(1000); 
            Console.Write("\b \b"); 
        } 
        return seconds; // Return the number of seconds 
    }
}
