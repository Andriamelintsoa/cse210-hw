using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        Console.WriteLine("\n===== YOUR JOURNAL ENTRIES =====");
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
        }
        else
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
                Console.WriteLine("-----------------------------------");
            }
        }
        Console.WriteLine("===================================\n");
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.ToFileString());
            }
        }
        Console.WriteLine($"Journal saved to {file}");
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        
        if (File.Exists(file))
        {
            string[] lines = File.ReadAllLines(file);
            foreach (string line in lines)
            {
                Entry entry = Entry.FromFileString(line);
                if (entry != null)
                {
                    _entries.Add(entry);
                }
            }
            Console.WriteLine($"Journal loaded from {file} ({_entries.Count} entries)");
        }
        else
        {
            Console.WriteLine("No existing journal found. Starting fresh.");
        }
    }

    public List<Entry> GetEntries()
    {
        return _entries;
    }
}