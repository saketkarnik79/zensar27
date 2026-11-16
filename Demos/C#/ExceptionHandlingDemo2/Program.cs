
using System;

class BankAccount
{
    public decimal Balance { get; private set; } = 10000;

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(amount),
                "Withdrawal amount must be positive.");
        }

        if (amount > Balance)
        {
            throw new InvalidOperationException(
                "Insufficient balance.");
        }

        Balance -= amount;

        Console.WriteLine($"Withdrawn: ₹{amount}");
        Console.WriteLine($"Remaining Balance: ₹{Balance}");
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();

        try
        {
            Console.Write("Enter withdrawal amount: ");
            decimal amount = decimal.Parse(Console.ReadLine()!);

            account.Withdraw(amount);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid amount format.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Transaction processing completed.");
        }
    }
}
