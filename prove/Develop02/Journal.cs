using System;
using System.Collections.Generic;
public class Journal
{
    
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
                    Entry entry = new Entry(prompt, entryTest, date);
                    _journalEntries.Add(entry);
                }
            }
        }
    }
}
