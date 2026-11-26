using System.ComponentModel.DataAnnotations;

namespace RetailMvc.Models;

public class Product
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    [Range(1, 1000000)]
    public decimal Price { get; set; }
}