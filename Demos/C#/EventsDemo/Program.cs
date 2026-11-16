
using System;

class OrderEventArgs : EventArgs
{
    public int OrderId { get; }

    public OrderEventArgs(int orderId)
    {
        OrderId = orderId;
    }
}

class OrderProcessor
{
    public event EventHandler<OrderEventArgs>? OrderPlaced;

    public void PlaceOrder(int orderId)
    {
        Console.WriteLine($"Processing Order: {orderId}");

        OrderPlaced?.Invoke(
            this, new OrderEventArgs(orderId));
    }
}

class EmailService
{
    public void SendConfirmation(
        object? sender, OrderEventArgs e)
    {
        Console.WriteLine(
            $"Email confirmation sent for Order {e.OrderId}");
    }
}

class SMSService
{
    public void SendNotification(
        object? sender, OrderEventArgs e)
    {
        Console.WriteLine(
            $"SMS notification sent for Order {e.OrderId}");
    }
}

class Program
{
    static void Main()
    {
        OrderProcessor processor = new OrderProcessor();

        EmailService email = new EmailService();
        SMSService sms = new SMSService();

        processor.OrderPlaced += email.SendConfirmation;
        processor.OrderPlaced += sms.SendNotification;

        processor.PlaceOrder(1001);
    }
}
