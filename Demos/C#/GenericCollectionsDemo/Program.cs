// Generic Collection Types in C#
// 1. List<T> - Represents a strongly typed list of objects that can be accessed by index. Provides methods to search, sort, and manipulate lists.
// 2. Dictionary<TKey, TValue> - Represents a collection of key/value pairs that are organized based on the key. Provides fast lookups and retrieval of values based on keys.
// 3. HashSet<T> - Represents a set of values that contains no duplicate elements. Provides methods for set operations like union, intersection, and difference.
// 4. Queue<T> - Represents a first-in, first-out (FIFO) collection of objects. Provides methods to enqueue and dequeue elements.
// 5. Stack<T> - Represents a last-in, first-out (LIFO) collection of objects. Provides methods to push and pop elements.
// 6. SortedList<TKey, TValue> - Represents a collection of key/value pairs that are sorted by the keys and are accessible by key and by index. Provides fast lookups and retrieval of values based on keys.


using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public decimal Salary { get; set; }

    public override string ToString()
    {
        return $"{Id} - {Name} - Rs.{Salary:N2}";
    }
}

class Program
{
    static void Main()
    {
        ListDemo();
    }

    private static void ListDemo()
    {
        List<Employee> employees = new List<Employee>();

        // 1. Add employees
        employees.Add(new Employee
        {
            Id = 101,
            Name = "Amit",
            Salary = 50000
        });

        employees.Add(new Employee
        {
            Id = 102,
            Name = "Neha",
            Salary = 65000
        });

        // 2. Add multiple employees
        employees.AddRange(new[]
        {
            new Employee
            {
                Id = 103,
                Name = "Rahul",
                Salary = 45000
            },
            new Employee
            {
                Id = 104,
                Name = "Priya",
                Salary = 75000
            }
        });

        Display(employees, "Initial Employees");

        // 3. Insert employee at index 1
        employees.Insert(1, new Employee
        {
            Id = 105,
            Name = "Kiran",
            Salary = 55000
        });

        Display(employees, "After Insert");

        // 4. Search employee
        Employee? employee = employees.Find(e => e.Id == 102);

        if (employee != null)
        {
            Console.WriteLine($"Found: {employee}");
        }

        // 5. Update salary
        if (employee != null)
        {
            employee.Salary = 70000;
        }

        // 6. Filter employees
        List<Employee> highSalaryEmployees =
            employees.FindAll(e => e.Salary >= 60000);

        Display(highSalaryEmployees, "High Salary Employees");

        // 7. Sort by salary descending
        employees.Sort((a, b) =>
            b.Salary.CompareTo(a.Salary));

        Display(employees, "Sorted by Salary");

        // 8. Remove by ID
        employees.RemoveAll(e => e.Id == 103);

        // 9. Count
        Console.WriteLine($"Total Employees: {employees.Count}");

        // 10. Calculate total salary using LINQ
        decimal totalSalary = employees.Sum(e => e.Salary);

        Console.WriteLine($"Total Salary: Rs.{totalSalary:N2}");

        Display(employees, "Final Employees");
    }

    static void Display(List<Employee> employees, string title)
    {
        Console.WriteLine($"\n--- {title} ---");

        foreach (Employee employee in employees)
        {
            Console.WriteLine(employee);
        }
    }
}
