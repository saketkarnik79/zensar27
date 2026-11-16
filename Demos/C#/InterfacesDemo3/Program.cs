
using System;

interface INotification
{
    void Send(string message);
}

class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Email Sent: {message}");
    }
}

class SMSNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"SMS Sent: {message}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Select Notification Type:");
        Console.WriteLine("1. Email");
        Console.WriteLine("2. SMS");

        string? choice = Console.ReadLine();

        INotification notification;

        if (choice == "1")
        {
            notification = new EmailNotification();
        }
        else if (choice == "2")
        {
            notification = new SMSNotification();
        }
        else
        {
            Console.WriteLine("Invalid choice");
            return;
        }

        notification.Send("Your order has been confirmed.");
    }
}
