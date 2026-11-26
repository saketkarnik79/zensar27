using RetailMvc.Models;

namespace RetailMvc.Services;

public class ProductService : IProductService
{
    private readonly List<Product> _products = new()
    {
        new Product
        {
            Id = 1,
            Name = "Laptop",
            Price = 50000
        },
        new Product
        {
            Id = 2,
            Name = "Mobile",
            Price = 25000
        },
        new Product
        {
            Id = 3,
            Name = "Keyboard",
            Price = 1500
        }
    };

    public IEnumerable<Product> GetAll()
    {
        return _products.ToList();
    }

    public Product? GetById(int id)
    {
        return _products.FirstOrDefault(
            p => p.Id == id);
    }

    public void Add(Product product)
    {
        product.Id = _products.Max(p => p.Id) + 1;

        _products.Add(product);
    }
}