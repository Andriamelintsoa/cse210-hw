// C# Prep 2 - Conditionals
// Prompts the user for a grade percentage and displays
// the corresponding letter grade with + or - modifier.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt for and read the grade percentage
        Console.Write("Enter your grade percentage (0-100): ");
        int grade = int.Parse(Console.ReadLine());

        // Determine the letter grade
        string letter;

        if (grade >= 90)
            letter = "A";
        else if (grade >= 80)
            letter = "B";
        else if (grade >= 70)
            letter = "C";
        else if (grade >= 60)
            letter = "D";
        else
            letter = "F";

        // Determine the +/- modifier (only for A-D)
        string modifier = "";

        if (letter != "F")
        {
            int lastDigit = grade % 10;

            if (lastDigit >= 7)
                modifier = "+";
            else if (lastDigit < 3)
                modifier = "-";
        }

        // Special case: A+ is not standard; cap at A
        // Also there is no F+ or F-, handled above by the letter != "F" check
        // A+ edge case: 100 / scores >= 97 could be A+, which is acceptable here
        if (letter == "A" && modifier == "+")
            modifier = "+"; // A+ is valid (97-100)

        // Display the result
        Console.WriteLine($"Your grade is: {letter}{modifier}");

        // Display whether the student is passing
        if (grade >= 70)
            Console.WriteLine("Congratulations, you are passing!");
        else
            Console.WriteLine("You are not passing. Keep working hard!");
    }
}
