using RetailStoreDemo.Models;

namespace RetailStoreDemo.ViewModels;

public class ProductDetailsViewModel
{
    public Product Product { get; set; } = new();

    public Customer Customer { get; set; } = new();

    public decimal DiscountPercentage { get; set; }

    public decimal FinalPrice =>
        Product.Price -
        (Product.Price * DiscountPercentage / 100);

    public bool IsAvailable =>
        Product.StockQuantity > 0;
}