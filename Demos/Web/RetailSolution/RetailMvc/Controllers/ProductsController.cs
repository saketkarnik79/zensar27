using Microsoft.AspNetCore.Mvc;
using RetailMvc.Models;
using RetailMvc.Services;

namespace RetailMvc.Controllers;

public class ProductsController : Controller
{
    private readonly IProductService _service;

    private readonly ILogger<ProductsController> _logger;

    public ProductsController(
        IProductService service,
        ILogger<ProductsController> logger)
    {
        _service = service;
        _logger = logger;
    }

    public IActionResult Index()
    {
        _logger.LogInformation(
            "Retrieving all products");

        var products = _service.GetAll();

        return View(products);
    }

    public IActionResult Details(int id)
    {
        _logger.LogInformation(
            "Retrieving product {ProductId}", id);

        var product = _service.GetById(id);

        if (product == null)
        {
            _logger.LogWarning(
                "Product {ProductId} not found", id);

            return NotFound();
        }

        return View(product);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Product product)
    {
        if (!ModelState.IsValid)
        {
            _logger.LogWarning(
                "Product validation failed");

            return View(product);
        }

        _service.Add(product);

        _logger.LogInformation(
            "Product {ProductId} created successfully",
            product.Id);

        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult GetProducts()
    {
        return Json(_service.GetAll());
    }
}