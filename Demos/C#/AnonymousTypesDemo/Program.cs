
using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public decimal Salary { get; set; }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new()
        {
            new Employee
            {
                Id = 101,
                Name = "Amit",
                Salary = 50000
            },
            new Employee
            {
                Id = 102,
                Name = "Priya",
                Salary = 70000
            },
            new Employee
            {
                Id = 103,
                Name = "Rahul",
                Salary = 40000
            }
        };

        var result = employees
            .Where(e => e.Salary > 45000)
            .Select(e => new
            {
                EmployeeName = e.Name,
                AnnualSalary = e.Salary * 12
            });

        foreach (var emp in result)
        {
            Console.WriteLine(
                $"{emp.EmployeeName}: ₹{emp.AnnualSalary}");
        }
    }
}
