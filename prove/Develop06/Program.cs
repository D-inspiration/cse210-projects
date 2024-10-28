using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Goal> goals = new List<Goal>();

    public static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("1. Add Simple Goal");
            Console.WriteLine("2. Add Eternal Goal");
            Console.WriteLine("3. Add Checklist Goal");
            Console.WriteLine("4. Display Goals");
            Console.WriteLine("5. Record Goal Event");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Exit");
            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddSimpleGoal();
                    break;
                case 2:
                    AddEternalGoal();
                    break;
                case 3:
                    AddCheckListGoal();
                    break;
                case 4:
                    DisplayGoals();
                    break;
                case 5:
                    RecordGoalEvent();
                    break;
                case 6:
                    SaveAllGoals();
                    break;
                case 7:
                    LoadAllGoals();
                    break;
                case 8:
                    exit = true;
                    break;
            }
        }
    }

    static void AddSimpleGoal()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        goals.Add(new SimpleGoal(name, description, points));
    }

    static void AddEternalGoal()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        goals.Add(new EternalGoal(name, description, points));
    }

    static void AddCheckListGoal()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());
        Console.Write("Enter target count: ");
        int targetCount = int.Parse(Console.ReadLine());
        Console.Write("Enter bonus points: ");
        int bonus = int.Parse(Console.ReadLine());

        goals.Add(new CheckList(name, description, points, targetCount, bonus));
    }

    static void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            goal.Display();
        }
    }

    static void RecordGoalEvent()
    {
        Console.Write("Enter goal index: ");
        int index = int.Parse(Console.ReadLine());

        if (index >= 0 && index < goals.Count)
        {
            int pointsEarned = goals[index].RecordEvent();
            Console.WriteLine($"You earned {pointsEarned} points!");
        }
    }

    static void SaveAllGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.SaveGoal());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    static void LoadAllGoals()
    {
        goals.Clear();
        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    switch (parts[0])
                    {
                        case "Goal":
                            goals.Add(Goal.LoadGoal(parts));
                            break;
                        case "SimpleGoal":
                            goals.Add(SimpleGoal.LoadGoal(parts));
                            break;
                        case "EternalGoal":
                            goals.Add(EternalGoal.LoadGoal(parts));
                            break;
                        case "CheckList":
                            goals.Add(CheckList.LoadGoal(parts));
                            break;
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
    }
}