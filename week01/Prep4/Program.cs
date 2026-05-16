// C# Prep 4 - Lists
// Allows the user to enter a series of numbers,
// then displays the sum, average, maximum, minimum,
// and the numbers sorted in ascending order.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store the user's numbers
        List<int> numbers = new List<int>();

        Console.WriteLine("=== Number List Analyzer ===");
        Console.WriteLine("Enter numbers one at a time. Type 0 to stop.\n");

        // Collect numbers from the user until they enter 0
        while (true)
        {
            Console.Write("Enter a number (0 to stop): ");
            int input = int.Parse(Console.ReadLine());

            if (input == 0)
                break;

            numbers.Add(input);
        }

        // Handle the case where no numbers were entered
        if (numbers.Count == 0)
        {
            Console.WriteLine("\nNo numbers were entered.");
            return;
        }

        // ─── Compute Statistics ───

        // Sum
        int total = 0;
        foreach (int num in numbers)
            total += num;

        // Average
        double average = (double)total / numbers.Count;

        // Maximum
        int maximum = numbers[0];
        foreach (int num in numbers)
            if (num > maximum)
                maximum = num;

        // Minimum
        int minimum = numbers[0];
        foreach (int num in numbers)
            if (num < minimum)
                minimum = num;

        // Sort the list (ascending)
        List<int> sorted = new List<int>(numbers);
        sorted.Sort();

        // ─── Display Results ───
        Console.WriteLine("\n=== Results ===");
        Console.WriteLine($"Count   : {numbers.Count}");
        Console.WriteLine($"Sum     : {total}");
        Console.WriteLine($"Average : {average:F2}");
        Console.WriteLine($"Maximum : {maximum}");
        Console.WriteLine($"Minimum : {minimum}");

        Console.Write("Sorted  : ");
        Console.WriteLine(string.Join(", ", sorted));
    }
}
