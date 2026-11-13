using System;

class Employee
{
    public void ShowRole()
    {
        Console.WriteLine("Employee Role");
    }

    public virtual void CalculateBonus()
    {
        Console.WriteLine("Employee Bonus: 10%");
    }
}

class Manager : Employee
{
    // Method Hiding
    public new void ShowRole()
    {
        Console.WriteLine("Manager Role");
    }

    // Method Overriding
    public override void CalculateBonus()
    {
        Console.WriteLine("Manager Bonus: 20%");
    }
}

class Program
{
    static void Main()
    {
        Employee employee = new Manager();

        employee.ShowRole();

        employee.CalculateBonus();
    }
}