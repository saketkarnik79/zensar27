
using System;

namespace AbstractClassDemo
{
    // Abstract Base Class
    abstract class BankAccount
    {
        public string AccountHolder { get; set; }
        public decimal Balance { get; protected set; }

        public BankAccount(string name, decimal balance)
        {
            AccountHolder = name;
            Balance = balance;
        }

        // Concrete Method
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid deposit amount");
                return;
            }

            Balance += amount;
            Console.WriteLine("Deposited: " + amount);
        }

        // Concrete Method
        public void Withdraw(decimal amount)
        {
            if (amount <= 0 || amount > Balance)
            {
                Console.WriteLine("Invalid withdrawal amount");
                return;
            }

            Balance -= amount;
            Console.WriteLine("Withdrawn: " + amount);
        }

        // Abstract Method
        public abstract decimal CalculateInterest();

        // Concrete Method
        public void DisplayDetails()
        {
            Console.WriteLine("Account Holder: " + AccountHolder);
            Console.WriteLine("Balance: " + Balance);
            Console.WriteLine("Interest: " + CalculateInterest());
        }
    }

    // Savings Account
    class SavingsAccount : BankAccount
    {
        public SavingsAccount(string name, decimal balance)
            : base(name, balance)
        {
        }

        public override decimal CalculateInterest()
        {
            return Balance * 0.04m;
        }
    }

    // Current Account
    class CurrentAccount : BankAccount
    {
        public CurrentAccount(string name, decimal balance)
            : base(name, balance)
        {
        }

        public override decimal CalculateInterest()
        {
            return 0m;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount savings =
                new SavingsAccount("Amit", 50000m);

            BankAccount current =
                new CurrentAccount("Rahul", 100000m);

            Console.WriteLine("Savings Account");
            savings.Deposit(10000m);
            savings.Withdraw(5000m);
            savings.DisplayDetails();

            Console.WriteLine();

            Console.WriteLine("Current Account");
            current.Deposit(20000m);
            current.Withdraw(10000m);
            current.DisplayDetails();
        }
    }
}
