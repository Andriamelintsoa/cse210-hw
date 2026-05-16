// C# Prep 3 - Loops
// Demonstrates three loop programs:
//   1. Sum of numbers 1 to N (while loop)
//   2. Multiplication table (for loop)
//   3. Number guessing game (do-while loop)

using System;

class Program
{
    static void Main(string[] args)
    {
        // ─── Part 1: Sum of numbers 1 to N using a while loop ───
        Console.WriteLine("=== Part 1: Sum of 1 to N ===");
        Console.Write("Enter a positive integer N: ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        int i = 1;
        while (i <= n)
        {
            sum += i;
            i++;
        }
        Console.WriteLine($"The sum of numbers from 1 to {n} is: {sum}");
        Console.WriteLine();

        // ─── Part 2: Multiplication table using a for loop ───
        Console.WriteLine("=== Part 2: Multiplication Table ===");
        Console.Write("Enter a number to see its multiplication table: ");
        int tableNum = int.Parse(Console.ReadLine());

        for (int multiplier = 1; multiplier <= 10; multiplier++)
        {
            int product = tableNum * multiplier;
            Console.WriteLine($"{tableNum} x {multiplier} = {product}");
        }
        Console.WriteLine();

        // ─── Part 3: Number guessing game using a do-while loop ───
        Console.WriteLine("=== Part 3: Number Guessing Game ===");
        Random random = new Random();
        int secretNumber = random.Next(1, 101); // 1 to 100 inclusive
        int guess;
        int attempts = 0;

        Console.WriteLine("I'm thinking of a number between 1 and 100.");

        do
        {
            Console.Write("Your guess: ");
            guess = int.Parse(Console.ReadLine());
            attempts++;

            if (guess < secretNumber)
                Console.WriteLine("Too low! Try again.");
            else if (guess > secretNumber)
                Console.WriteLine("Too high! Try again.");
            else
                Console.WriteLine($"Correct! You guessed it in {attempts} attempt(s)!");

        } while (guess != secretNumber);
    }
}
