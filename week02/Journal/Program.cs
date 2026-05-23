using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string filename = "journal.txt";
        
        journal.LoadFromFile(filename);
        
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Load journal from file");
            Console.WriteLine("4. Save journal to file");
            Console.WriteLine("5. Search entries");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");
            
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    
                    if (!string.IsNullOrWhiteSpace(response))
                    {
                        Entry newEntry = new Entry(prompt, response);
                        journal.AddEntry(newEntry);
                        Console.WriteLine("Entry added successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Entry cannot be empty.");
                    }
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter filename to load: ");
                    journal.LoadFromFile(Console.ReadLine());
                    break;
                case "4":
                    Console.Write("Enter filename to save: ");
                    journal.SaveToFile(Console.ReadLine());
                    break;
                case "5":
                    SearchEntries(journal);
                    break;
                case "6":
                    quit = true;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
    
       static void SearchEntries(Journal journal)
    {
        Console.Write("\nEnter search term: ");
        string searchTerm = Console.ReadLine().ToLower();
        if (string.IsNullOrWhiteSpace(searchTerm)) { Console.WriteLine("Search term cannot be empty."); return; }
        
        int matchCount = 0;
        foreach (Entry entry in journal.GetEntries())
        {
            // Utilisation des propriétés publiques au lieu des champs privés
            if (entry.EntryText.ToLower().Contains(searchTerm) || entry.PromptText.ToLower().Contains(searchTerm))
            {
                Console.WriteLine($"\n--- Match Found ---\nDate: {entry.Date}\nPrompt: {entry.PromptText}\nContent: {entry.EntryText}");
                matchCount++;
            }
        }
        Console.WriteLine(matchCount == 0 ? "No matches found." : $"\nTotal matches: {matchCount}");
    }
}