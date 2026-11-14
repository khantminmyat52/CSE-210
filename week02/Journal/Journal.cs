using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    // Method to add a new entry to the journal list
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Method to display all entries in the journal
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Method to save journal entries to a file
    public void SaveToFile(string file)
    {
        // CREATIVITY REQUIREMENT: Saves both standard fields and the custom Mood field using a secure delimiter (~|~).
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~|~{entry._promptText}~|~{entry._entryText}~|~{entry._mood}");
            }
        }
        Console.WriteLine("Journal saved successfully!");
    }

    // Method to load journal entries from a file
    public void LoadFromFile(string file)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            // Splitting by custom delimiter to properly parse the 4 fields including Mood
            string[] parts = line.Split("~|~");

            if (parts.Length >= 4)
            {
                Entry entry = new Entry();
                entry._date = parts[0];
                entry._promptText = parts[1];
                entry._entryText = parts[2];
                entry._mood = parts[3]; // Loading the creative mood field

                _entries.Add(entry);
            }
        }
        Console.WriteLine("Journal loaded successfully!");
    }
}