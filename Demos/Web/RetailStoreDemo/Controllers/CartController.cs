using Microsoft.AspNetCore.Mvc;

namespace RetailStoreDemo.Controllers;

public class CartController : Controller
{
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult AddToCart()
    {
        int count =
            HttpContext.Session.GetInt32("CartCount") ?? 0;

        count++;

        HttpContext.Session.SetInt32(
            "CartCount",
            count
        );

        return RedirectToAction("Index");
    }

    public IActionResult Index()
    {
        int count =
            HttpContext.Session.GetInt32("CartCount") ?? 0;

        return View(count);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult ClearCart()
    {
        HttpContext.Session.Remove("CartCount");

        return RedirectToAction("Index");
    }
}