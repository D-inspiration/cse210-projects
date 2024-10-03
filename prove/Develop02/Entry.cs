using System;

public class Entry
{
    public string Prompt { get; set; }
    public string EntryTest { get; set; }
    public string Date { get; internal set; }

    public Entry(string prompt, string entryTest, string date)
    {
        Prompt = prompt;
        EntryTest = entryTest;
        Date = date;
    }

    public Entry()
    {
    }

    public void Display()
    {
        Console.WriteLine($"Prompt: {Prompt}, EntryTest: {EntryTest} Date: {Date}");
    }
}
