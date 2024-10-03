using System;

public class Entry
{
    public string Prompt { get; set; }
    public string EntryTest { get; set; }
    public string Date { get; internal set; }
    public string Mood { get; set; }

    public Entry(string prompt, string entryTest, string date, string mood)
    {
        Prompt = prompt;
        EntryTest = entryTest;
        Date = date;
        Mood = mood;
    }

    public Entry()
    {
    }

    public void Display()
    {
        Console.WriteLine($"Prompt: {Prompt}, EntryTest: {EntryTest} Date: {Date} Mood: {Mood}");
    }
}
