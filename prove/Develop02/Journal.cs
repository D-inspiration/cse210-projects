using System;
using System.Collections.Generic;
using System.ComponentModel;
public class Journal
{
    // Added creativity
    public enum Mood
{
    Happy,
    Sad,
    Neutral,
    Angry,
    Surprised
}
    
    public List<Entry> _journalEntries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _journalEntries.Add(newEntry);
    }

    public void RemoveEntry(Entry deleteEntry)
    {
        _journalEntries.Remove(deleteEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _journalEntries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in _journalEntries)
            {
                writer.WriteLine(entry.Prompt);
                writer.WriteLine(entry.EntryTest);
                writer.WriteLine(entry.Date);
                writer.WriteLine(entry.Mood);
            }
        }
    }

    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            using (StreamReader reader = new StreamReader(file))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string prompt = line;
                    string entryTest = reader.ReadLine();
                    string date = reader.ReadLine();
                    string mood = reader.ReadLine();
                    Entry entry = new Entry(prompt, entryTest, date, mood);
                    _journalEntries.Add(entry);
                }
            }
        }
    }

    
}
