// C# Prep 1 - Variables, Input, and Output
// Prompts the user for their name and favorite number,
// then displays a personalized message.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt for and read the user's name
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        // Prompt for and read the user's favorite number
        Console.Write("Please enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());

        // Calculate double the favorite number
        int doubled = favoriteNumber * 2;

        // Display the personalized output message
        Console.WriteLine($"Hello {name}!");
        Console.WriteLine($"Your favorite number doubled is {doubled}.");
    }
}
