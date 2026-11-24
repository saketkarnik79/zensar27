using Microsoft.AspNetCore.Mvc;
using RetailStoreDemo.Models;
using RetailStoreDemo.ViewModels;

namespace RetailStoreDemo.Controllers;

public class ProductController : Controller
{
    public IActionResult Details()
    {
        Product product = new Product
        {
            ProductId = 101,
            ProductName = "Laptop",
            Price = 60000,
            StockQuantity = 15
        };

        Customer customer = new Customer
        {
            CustomerId = 1,
            CustomerName = "Amit Sharma",
            MembershipType = "Premium"
        };

        ProductDetailsViewModel viewModel = new()
        {
            Product = product,
            Customer = customer,
            DiscountPercentage = 10
        };

        return View(viewModel);
    }
}