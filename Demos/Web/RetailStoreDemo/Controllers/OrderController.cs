using Microsoft.AspNetCore.Mvc;

namespace RetailStoreDemo.Controllers;

public class OrderController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult PlaceOrder()
    {
        // Order processing logic

        TempData["SuccessMessage"] =
            "Your order has been placed successfully!";

        TempData["OrderId"] = 1001;

        return RedirectToAction("Confirmation");
    }

    public IActionResult Confirmation()
    {
        return View();
    }
}