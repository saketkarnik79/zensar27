// using System;

// class Program
// {
//     static void Main()
//     {
//         var employeeId = 101;

//         var employeeName = "Amit";

//         var salary = 55000.50m;

//         var isActive = true;

//         var rating = 4.5;

//         Console.WriteLine("Employee Details");
//         Console.WriteLine("----------------");

//         Console.WriteLine($"ID: {employeeId}");
//         Console.WriteLine($"Name: {employeeName}");
//         Console.WriteLine($"Salary: {salary}");
//         Console.WriteLine($"Active: {isActive}");
//         Console.WriteLine($"Rating: {rating}");

//         Console.WriteLine("\nInferred Types:");

//         Console.WriteLine(employeeId.GetType());
//         Console.WriteLine(employeeName.GetType());
//         Console.WriteLine(salary.GetType());
//         Console.WriteLine(isActive.GetType());
//         Console.WriteLine(rating.GetType());
//     }
// }

using System;

class Program
{
    static void Main()
    {
        // Implicitly typed variable
        var value1 = 100;

        // Object type
        object value2 = 100;

        // Dynamic type
        dynamic value3 = 100;

        Console.WriteLine("Initial Values:");

        Console.WriteLine(value1);
        Console.WriteLine(value2);
        Console.WriteLine(value3);

        // var is strongly typed
        // value1 = "Hello"; // Compile-time error

        // object can hold another type
        value2 = "Hello";

        // dynamic can hold another type
        value3 = "Welcome";

        Console.WriteLine("\nAfter Modification:");

        Console.WriteLine("var: " + value1);
        Console.WriteLine("object: " + value2);
        Console.WriteLine("dynamic: " + value3);

        Console.WriteLine("\nRuntime Types:");

        Console.WriteLine(value1.GetType());
        Console.WriteLine(value2.GetType());
        Console.WriteLine(value3.GetType());
    }
}