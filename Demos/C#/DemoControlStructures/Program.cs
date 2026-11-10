// Console.Write("Enter your age: ");

// int age = Convert.ToInt32(Console.ReadLine());

// if (age >= 18)
// {
//     Console.WriteLine("You are eligible to vote.");
// }
// else
// {
//     Console.WriteLine("You are not eligible to vote.");
// }
// Console.WriteLine("Program completed.");

// Console.Write("Enter student marks: ");

// int marks = Convert.ToInt32(Console.ReadLine());

// if (marks < 0 || marks > 100)
// {
//     Console.WriteLine("Invalid Marks");
// }
// else if (marks >= 90)
// {
//     Console.WriteLine("Grade A+");
// }
// else if (marks >= 75)
// {
//     Console.WriteLine("Grade A");
// }
// else if (marks >= 60)
// {
//     Console.WriteLine("Grade B");
// }
// else if (marks >= 40)
// {
//     Console.WriteLine("Grade C");
// }
// else
// {
//     Console.WriteLine("Fail");
// }


// Console.Write("Enter employee salary: ");
// decimal salary = Convert.ToDecimal(Console.ReadLine());

// Console.Write("Enter years of experience: ");
// int experience = Convert.ToInt32(Console.ReadLine());

// if (salary >= 30000)
// {
//     if (experience >= 3)
//     {
//         Console.WriteLine("Loan Approved");
//     }
//     else
//     {
//         Console.WriteLine(
//             "Loan Rejected: Insufficient Experience"
//         );
//     }
// }
// else
// {
//     Console.WriteLine(
//         "Loan Rejected: Insufficient Salary"
//     );
// }

// int marks = 65;
// string result = marks >= 40 ? "Pass" : "Fail";
// Console.WriteLine(result);

// Loops
// for(int i=1; i<=10; i++)
// {
//     Console.WriteLine($"5 X {i} = {5*i}");
// }

// Console.Write("Enter N: ");

// int n = int.Parse(Console.ReadLine());

// int i = 1;
// int sum = 0;

// while (i <= n)
// {
//     sum += i;
//     i++;
// }

// Console.WriteLine("Sum = " + sum);

// int choice;

// do
// {
//     Console.WriteLine("\nCALCULATOR MENU");
//     Console.WriteLine("1. Addition");
//     Console.WriteLine("2. Subtraction");
//     Console.WriteLine("3. Multiplication");
//     Console.WriteLine("4. Exit");

//     Console.Write("Enter choice: ");
//     choice = Convert.ToInt32(Console.ReadLine());

//     if (choice >= 1 && choice <= 3)
//     {
//         Console.Write("Enter first number: ");
//         double a = Convert.ToDouble(Console.ReadLine());

//         Console.Write("Enter second number: ");
//         double b = Convert.ToDouble(Console.ReadLine());

//         if (choice == 1)
//             Console.WriteLine("Result: " + (a + b));
//         else if (choice == 2)
//             Console.WriteLine("Result: " + (a - b));
//         else
//             Console.WriteLine("Result: " + (a * b));
//     }
//     else if (choice != 4)
//     {
//         Console.WriteLine("Invalid Choice");
//     }

// } while (choice != 4);

// Console.WriteLine("Calculator Closed");

// Nested Loops

for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("* ");
    }

    Console.WriteLine();
}