
using System;

interface IEmployee
{
    void DisplayDetails();
    decimal CalculateSalary();
}

class PermanentEmployee : IEmployee
{
    public string Name { get; set; }
    public decimal BasicSalary { get; set; }

    public void DisplayDetails()
    {
        Console.WriteLine($"Employee: {Name}");
        Console.WriteLine("Type: Permanent");
    }

    public decimal CalculateSalary()
    {
        return BasicSalary + 5000;
    }
}

class ContractEmployee : IEmployee
{
    public string Name { get; set; }
    public decimal HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    public void DisplayDetails()
    {
        Console.WriteLine($"Employee: {Name}");
        Console.WriteLine("Type: Contract");
    }

    public decimal CalculateSalary()
    {
        return HourlyRate * HoursWorked;
    }
}

class Program
{
    static void Main()
    {
        IEmployee emp1 = new PermanentEmployee
        {
            Name = "Amit",
            BasicSalary = 50000
        };

        IEmployee emp2 = new ContractEmployee
        {
            Name = "Rahul",
            HourlyRate = 500,
            HoursWorked = 80
        };

        emp1.DisplayDetails();
        Console.WriteLine($"Salary: {emp1.CalculateSalary()}");

        Console.WriteLine();

        emp2.DisplayDetails();
        Console.WriteLine($"Salary: {emp2.CalculateSalary()}");
    }
}
