// Arithmetic Operators

// Console.Write("Enter First Number: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Enter Second Number: ");
// int b = int.Parse(Console.ReadLine());
// Console.Write("Enter the operator <+, -, *, /, %>: ");
// char op = char.Parse(Console.ReadLine());
// float result = 0;
// switch (op)
// {
//     case '+':
//         result = a + b;
//         break;
//     case '-':
//         result = a - b;
//         break;
//     case '*':
//         result = a * b;
//         break;
//     case '/':
//         result = (float) a / b;
//         break;
//     case '%':
//         result = a % b;
//         break;
//     default:
//         Console.WriteLine("Invalid operator entered.");
//         break;
// }
// Console.WriteLine($"{a} {op} {b} = {result}");

// Relational Operators
// int a = 25;
// int b = 20;

// Console.WriteLine("Relational Operators");

// Console.WriteLine("Equal: " + (a == b));
// Console.WriteLine("Not Equal: " + (a != b));
// Console.WriteLine("Greater Than: " + (a > b));
// Console.WriteLine("Less Than: " + (a < b));
// Console.WriteLine("Greater or Equal: " + (a >= b));
// Console.WriteLine("Less or Equal: " + (a <= b));

// Practical Example: Student Result
// int marks = 75;
// int passingMarks = 40;

// if (marks >= passingMarks)
// {
//     Console.WriteLine("Student Passed");
// }
// else
// {
//     Console.WriteLine("Student Failed");
// }

// Logical Operators
// int age = 25;
// bool hasLicense = true;
// bool hasPassport = false;

// Console.WriteLine("Logical Operators");

// // Logical AND
// if (age >= 18 && hasLicense)
// {
//     Console.WriteLine("Eligible to Drive");
// }
// else
// {
//     Console.WriteLine("Not Eligible to Drive");
// }

// // Logical OR
// if (hasLicense || hasPassport)
// {
//     Console.WriteLine("At least one ID is available");
// }

// // Logical NOT
// if (!hasPassport)
// {
//     Console.WriteLine("Passport is not available");
// }

// // Logical XOR
// bool a = true;
// bool b = false;

// Console.WriteLine("XOR Result: " + (a ^ b));

// Assignment Operators
// int number = 20;

// Console.WriteLine("Assignment Operators");

// Console.WriteLine("Initial Value: " + number);

// number += 10; // number = number + 10 (Known as compound assignment operators)
// Console.WriteLine("After += 10: " + number);

// number -= 5;
// Console.WriteLine("After -= 5: " + number);

// number *= 2;
// Console.WriteLine("After *= 2: " + number);

// number /= 5;
// Console.WriteLine("After /= 5: " + number);

// number %= 4;
// Console.WriteLine("After %= 4: " + number);

// decimal balance = 10000m;

// Console.WriteLine("Initial Balance: " + balance);

// // Deposit
// balance += 5000m;

// Console.WriteLine("After Deposit: " + balance);

// // Withdrawal
// balance -= 3000m;

// Console.WriteLine("After Withdrawal: " + balance);

// // Interest: 5%
// balance += balance * 0.05m;

// Console.WriteLine("After Interest: " + balance);

// checked & unchecked operators
// int x=-2147483648;
// int y=2147483647;
// // int result = x-1;
// // Console.WriteLine(result);
// // result = y+1;
// // Console.WriteLine(result);
// try
// {
//     checked
//     {
//         int result = x-1;
//         Console.WriteLine(result);
//         result = y+1;
//         Console.WriteLine(result);
//     }
// }
// catch(OverflowException ex)
// {
//     Console.WriteLine($"Overflow detected!\n{ex.Message}");
// }


// Operator precedence
int a = 10;
int b = 5;
int c = 2;

int result1 = a + b * c;
int result2 = (a + b) * c;

bool result3 = a > b && b > c;

bool result4 = a < b || b > c;

Console.WriteLine("Result 1: " + result1);
Console.WriteLine("Result 2: " + result2);
Console.WriteLine("Result 3: " + result3);
Console.WriteLine("Result 4: " + result4);