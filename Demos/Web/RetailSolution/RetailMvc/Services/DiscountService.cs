namespace RetailMvc.Services;

public class DiscountService
{
    public decimal CalculateDiscount(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException(
                "Amount cannot be negative");
            //return 0;
        }

        if (amount >= 10000)
        {
            return amount * 0.20m;
        }

        if (amount >= 5000)
        {
            return amount * 0.10m;
        }

        return 0;
    }

    public decimal CalculateFinalAmount(decimal amount)
    {
        return amount - CalculateDiscount(amount);
    }
}