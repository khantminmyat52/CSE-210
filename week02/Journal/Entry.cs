using System;

public class Entry
{
    public string _date { get; set; }
    public string _promptText { get; set; }
    public string _entryText { get; set; }
    
    // CREATIVITY REQUIREMENT: Added a Mood property to track the user's emotional state for each entry.
    public string _mood { get; set; }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} | Prompt: {_promptText}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine($"Entry: {_entryText}\n");
    }
}