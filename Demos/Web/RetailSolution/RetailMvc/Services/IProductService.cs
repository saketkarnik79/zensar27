using RetailMvc.Models;

namespace RetailMvc.Services;

public interface IProductService
{
    IEnumerable<Product> GetAll();

    Product? GetById(int id);

    void Add(Product product);
}