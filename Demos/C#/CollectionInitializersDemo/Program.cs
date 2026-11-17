
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> cities = new()
        {
            "Mumbai",
            "Pune",
            "Ahmedabad",
            "Vadodara"
        };

        Dictionary<int, string> employees = new()
        {
            { 101, "Amit" },
            { 102, "Rahul" },
            { 103, "Priya" }
        };

        Console.WriteLine("Cities:");

        foreach (string city in cities)
        {
            Console.WriteLine(city);
        }

        Console.WriteLine("\nEmployees:");

        foreach (var emp in employees)
        {
            Console.WriteLine($"{emp.Key}: {emp.Value}");
        }
    }
}
