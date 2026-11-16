
// using System;

// delegate int MathOperation(int a, int b);

// static class Calculator
// {
//     public static int Add(int a, int b)
//     {
//         return a + b;
//     }

//     public static int Multiply(int a, int b)
//     {
//         return a * b;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         MathOperation operation;

//         operation = Calculator.Add;
//         Console.WriteLine($"Addition: {operation?.Invoke(10, 5)}");

//         // operation = Calculator.Multiply;
//         // Console.WriteLine($"Multiplication: {operation?.Invoke(10, 5)}");
//         operation += Calculator.Multiply;
//         Console.WriteLine($"Multiplication: {operation?.Invoke(10, 5)}");
//     }
// }


using System;

delegate void NotificationHandler(string message);

class Program
{
    static void SendEmail(string message)
    {
        Console.WriteLine($"Email: {message}");
    }

    static void SendSMS(string message)
    {
        Console.WriteLine($"SMS: {message}");
    }

    static void Main()
    {
        NotificationHandler handler = SendEmail;

        handler += SendSMS;

        handler("Order Confirmed");
    }
}
