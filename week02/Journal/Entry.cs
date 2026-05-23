using System;

public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;

    // Propriétés publiques pour lire les données en respectant l'abstraction
    public string Date => _date;
    public string PromptText => _promptText;
    public string EntryText => _entryText;

    public Entry(string prompt, string text)
    {
        _date = DateTime.Now.ToShortDateString();
        _promptText = prompt;
        _entryText = text;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Content: {_entryText}");
    }

    public string ToFileString()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }

    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split('|', 3);
        if (parts.Length == 3)
        {
            return new Entry(parts[1], parts[2]);
        }
        return null;
    }
}