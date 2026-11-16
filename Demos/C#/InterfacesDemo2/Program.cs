
using System;

interface IPayment
{
    void Pay(decimal amount);
}

class CreditCardPayment : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid ₹{amount} using Credit Card");
    }
}

class UPIPayment : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid ₹{amount} using UPI");
    }
}

class PaymentProcessor
{
    private readonly IPayment _payment;

    public PaymentProcessor(IPayment payment)
    {
        _payment = payment;
    }

    public void ProcessPayment(decimal amount)
    {
        _payment.Pay(amount);
    }
}

class Program
{
    static void Main()
    {
        IPayment creditCard = new CreditCardPayment();
        PaymentProcessor processor1 =
            new PaymentProcessor(creditCard);

        processor1.ProcessPayment(2500);

        IPayment upi = new UPIPayment();
        PaymentProcessor processor2 =
            new PaymentProcessor(upi);

        processor2.ProcessPayment(1500);
    }
}
