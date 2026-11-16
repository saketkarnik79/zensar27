
using System;

delegate decimal DiscountCalculator(decimal amount);

class Program
{
    static void Main()
    {
        // DiscountCalculator calculateDiscount =
        //     delegate(decimal amount) // Anonymous method to calculate a 10% discount
        //     {
        //         return amount * 0.10m;
        //     };

        DiscountCalculator calculateDiscount = (amount) => amount * 0.10m; // Anonymous method to calculate a 10% discount implemented using lambda expression

        decimal price = 5000;

        decimal? discount = calculateDiscount?.Invoke(price);

        Console.WriteLine($"Original Price: {price}");
        Console.WriteLine($"Discount: {discount ?? decimal.Zero}");
        Console.WriteLine($"Final Price: {price - (discount ?? decimal.Zero)}");
    }
}
