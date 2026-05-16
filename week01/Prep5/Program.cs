// C# Prep 5 - Functions
// A modular temperature-conversion utility that demonstrates
// creating and calling multiple functions.

using System;

class Program
{
    // ─── Function Definitions ───────────────────────────────────────

    /// <summary>
    /// Converts a temperature in Celsius to Fahrenheit.
    /// </summary>
    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9.0 / 5.0) + 32.0;
    }

    /// <summary>
    /// Converts a temperature in Fahrenheit to Celsius.
    /// </summary>
    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32.0) * 5.0 / 9.0;
    }

    /// <summary>
    /// Converts a temperature in Celsius to Kelvin.
    /// </summary>
    static double CelsiusToKelvin(double celsius)
    {
        return celsius + 273.15;
    }

    /// <summary>
    /// Returns a description of the temperature (e.g., "Freezing", "Cold", "Warm", "Hot").
    /// Based on the Celsius value.
    /// </summary>
    static string DescribeTemperature(double celsius)
    {
        if (celsius < 0)
            return "Freezing";
        else if (celsius < 10)
            return "Cold";
        else if (celsius < 20)
            return "Cool";
        else if (celsius < 30)
            return "Warm";
        else
            return "Hot";
    }

    /// <summary>
    /// Displays a formatted temperature report for a given Celsius value.
    /// </summary>
    static void DisplayTemperatureReport(double celsius)
    {
        double fahrenheit = CelsiusToFahrenheit(celsius);
        double kelvin     = CelsiusToKelvin(celsius);
        string description = DescribeTemperature(celsius);

        Console.WriteLine("\n=== Temperature Report ===");
        Console.WriteLine($"Celsius    : {celsius:F2} °C");
        Console.WriteLine($"Fahrenheit : {fahrenheit:F2} °F");
        Console.WriteLine($"Kelvin     : {kelvin:F2} K");
        Console.WriteLine($"Description: {description}");
    }

    // ─── Entry Point ────────────────────────────────────────────────

    static void Main(string[] args)
    {
        Console.WriteLine("=== Temperature Converter ===\n");

        // Ask the user for a temperature in Celsius
        Console.Write("Enter a temperature in Celsius: ");
        double inputCelsius = double.Parse(Console.ReadLine());

        // Display the full report using our functions
        DisplayTemperatureReport(inputCelsius);

        Console.WriteLine();

        // Ask for a Fahrenheit value and convert it
        Console.Write("Enter a temperature in Fahrenheit to convert to Celsius: ");
        double inputFahrenheit = double.Parse(Console.ReadLine());

        double convertedCelsius = FahrenheitToCelsius(inputFahrenheit);
        Console.WriteLine($"{inputFahrenheit:F2} °F = {convertedCelsius:F2} °C");
        Console.WriteLine($"That feels: {DescribeTemperature(convertedCelsius)}");
    }
}
