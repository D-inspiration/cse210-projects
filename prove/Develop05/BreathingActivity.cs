using System;
using System.Threading.Tasks;


// Derived class for Breathing activity
public class BreathingActivity : Activity
{
    // private int _count;

    

    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        Console.WriteLine($"Welcome to {name}!");
        Console.WriteLine(description);
        Console.WriteLine("Duration: " + duration + " seconds");
    }

    public override void DisplayStartingMessage()
    {
        base.DisplayStartingMessage();
        Console.WriteLine("Get ready to breathe in and out...");
    }

    public override void DisplayEndingMessage()
    {
        base.DisplayEndingMessage();
        Console.WriteLine("You have completed the breathing activity!");
    }

    public bool Run()
    {
        DisplayStartingMessage();
        ShowSpinner(2);
        // int duration = duration;
        while (this.Duration > 1)
        {
            ShowCountDown(3);
            // Duration -= 3;
            Console.WriteLine("Start");
            Console.WriteLine("Breathe in...");
            Parallel.Invoke(
                () => Thread.Sleep(5000),
                () => Console.WriteLine("hold it..."),
                () => ShowCountDown(5)
                );
            Duration -= 5;
            // Thread.Sleep(1000);
            // Duration -= 1;
            // Console.WriteLine("I'm back!!");
            Console.WriteLine("Breathe out...");
            Parallel.Invoke(
                () => Thread.Sleep(5000),
                () => ShowCountDown(5),
                () => Console.Write("\b \b"),
                () => Console.WriteLine("hold it...")
                );
            Duration -= 5;
        }
        Console.WriteLine("Time's up!");
        DisplayEndingMessage();
        return true;
        
    }
}
