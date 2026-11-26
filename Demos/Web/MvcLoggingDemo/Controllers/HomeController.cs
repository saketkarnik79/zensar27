using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcLoggingDemo.Models;

namespace MvcLoggingDemo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        _logger.LogTrace("Trace message.");

        _logger.LogDebug("Debug message.");

        _logger.LogInformation($"Home page accessed at: {DateTime.Now}.");

        _logger.LogWarning($"Demo warning message.");

        _logger.LogError($"Demo error message.");

        _logger.LogCritical($"Demo critical error message.");

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Details(int id)
    {
        _logger.LogInformation(
            "Product details requested for ProductID {ProductId}", id); // Structured logging example

        return Content($"Product ID: {id}");
    }

    public IActionResult Calculate([FromQuery]int number)
    {
        try
        {
            _logger.LogInformation(
                "Calculation started for {Number}", number);

            int result = 100 / number;

            return Content($"Result: {result}");
        }
        catch (DivideByZeroException ex)
        {
            _logger.LogError(
                ex,
                "Calculation failed for {Number}",
                number);

            return BadRequest(
                "Number cannot be zero");
        }
    }

    public IActionResult ProcessOrder(int id)
    {
        using (_logger.BeginScope(
            "OrderId: {OrderId}", id))
        {
            _logger.LogInformation(
                "Order processing started");

            _logger.LogInformation(
                "Validating order");

            _logger.LogInformation(
                "Order processing completed");
        }

        return Content("Order processed");
    }
}
