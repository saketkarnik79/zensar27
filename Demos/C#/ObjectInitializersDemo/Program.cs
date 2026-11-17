
using System;

class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public decimal Price { get; set; }
}

class Program
{
    static void Main()
    {
        Product product = new Product()
        {
            Id = 101,
            Name = "Laptop",
            Price = 55000
        };

        Console.WriteLine($"ID: {product.Id}");
        Console.WriteLine($"Name: {product.Name}");
        Console.WriteLine($"Price: ₹{product.Price}");
    }
}
