
// using System;

// class Employee
// {
//     public string Name;
//     public double BasicSalary;

//     // Constructor
//     public Employee(string name, double salary)
//     {
//         Name = name;
//         BasicSalary = salary;
//     }

//     // Instance method without return value
//     public void DisplayEmployee()
//     {
//         Console.WriteLine("Employee Name: " + Name);
//         Console.WriteLine("Basic Salary: " + BasicSalary);
//     }

//     // Method with return value
//     public double CalculateAnnualSalary()
//     {
//         return BasicSalary * 12;
//     }

//     // Method with parameters
//     public double CalculateBonus(double percentage)
//     {
//         return BasicSalary * percentage / 100;
//     }

//     // Method overloading - one parameter
//     public double CalculateTax(double salary)
//     {
//         return salary * 0.10;
//     }

//     // Method overloading - two parameters
//     public double CalculateTax(double salary, double taxRate)
//     {
//         return salary * taxRate / 100;
//     }

//     // Static method
//     public static void CompanyInformation()
//     {
//         Console.WriteLine("Company: ABC Technologies");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // Calling static method
//         Employee.CompanyInformation();

//         // Creating object
//         Employee emp = new Employee("Amit", 50000);

//         // Calling instance method
//         emp.DisplayEmployee();

//         // Calling method with return value
//         double annualSalary = emp.CalculateAnnualSalary();
//         Console.WriteLine("Annual Salary: " + annualSalary);

//         // Calling method with parameter
//         double bonus = emp.CalculateBonus(15);
//         Console.WriteLine("Bonus: " + bonus);

//         // Method overloading
//         Console.WriteLine("Default Tax: " +
//             emp.CalculateTax(50000));

//         Console.WriteLine("Custom Tax: " +
//             emp.CalculateTax(50000, 20));
//     }
// }


// using System;

// class BankingService
// {
//     // Pass by value
//     public void UpdateBalanceByValue(decimal balance)
//     {
//         balance += 1000;
//         Console.WriteLine("Inside Value Method: " + balance);
//     }

//     // Pass by reference
//     public void Deposit(ref decimal balance, decimal amount)
//     {
//         balance += amount;
//     }

//     // Output parameter
//     public bool Withdraw(
//         decimal balance,
//         decimal amount,
//         out decimal remainingBalance)
//     {
//         if (amount <= balance && amount > 0)
//         {
//             remainingBalance = balance - amount;
//             return true;
//         }

//         remainingBalance = balance;
//         return false;
//     }

//     // Read-only reference parameter
//     public void DisplayBalance(in decimal balance)
//     {
//         Console.WriteLine("Current Balance: " + balance);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         BankingService bank = new BankingService();

//         decimal balance = 10000;

//         Console.WriteLine("Initial Balance: " + balance);

//         // Pass by value
//         bank.UpdateBalanceByValue(balance);

//         Console.WriteLine("After Value Method: " + balance);

//         // Pass by reference
//         bank.Deposit(ref balance, 5000);

//         Console.WriteLine("After Deposit: " + balance);

//         // Output parameter
//         decimal remainingBalance;

//         bool success = bank.Withdraw(
//             balance,
//             3000,
//             out remainingBalance);

//         if (success)
//         {
//             balance = remainingBalance;
//             Console.WriteLine("Withdrawal Successful");
//         }
//         else
//         {
//             Console.WriteLine("Withdrawal Failed");
//         }

//         // Read-only reference
//         bank.DisplayBalance(in balance);
//     }
// }



// using System;

// class StudentResult
// {
//     // Method using params
//     public int CalculateTotal(params int[] marks)
//     {
//         int total = 0;

//         foreach (int mark in marks)
//         {
//             total += mark;
//         }

//         return total;
//     }

//     // Method with regular parameter and params
//     public void DisplayResult(
//         string studentName,
//         params int[] marks)
//     {
//         int total = CalculateTotal(marks);

//         if (marks.Length == 0)
//         {
//             Console.WriteLine(studentName + ": No marks available");
//             return;
//         }

//         double average = (double)total / marks.Length;

//         Console.WriteLine("Student: " + studentName);
//         Console.WriteLine("Subjects: " + marks.Length);
//         Console.WriteLine("Total Marks: " + total);
//         Console.WriteLine("Average Marks: " + average);
//         Console.WriteLine("-----------------------");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         StudentResult result = new StudentResult();

//         // Three arguments
//         result.DisplayResult("Amit", 80, 85, 90);

//         // Five arguments
//         result.DisplayResult("Priya", 75, 80, 85, 90, 95);

//         // Two arguments
//         result.DisplayResult("Rahul", 70, 80);

//         // No marks
//         result.DisplayResult("Neha");
//     }
// }


