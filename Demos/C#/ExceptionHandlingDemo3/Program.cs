
using System;

class InsufficientBalanceException : ApplicationException
{
    public InsufficientBalanceException(string message)
        : base(message)
    {
    }   
}

class BankAccount
{
    public decimal Balance { get; private set; } = 5000;

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(amount));
        }

        if (amount > Balance)
        {
            throw new InsufficientBalanceException(
                $"Insufficient funds. Available: ₹{Balance}");
        }

        Balance -= amount;
        Console.WriteLine($"Withdrawal successful: ₹{amount}");
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();

        try
        {
            account.Withdraw(8000);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine($"Bank Error: {ex.Message}");
        }
    }
}
