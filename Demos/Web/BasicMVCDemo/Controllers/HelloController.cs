using Microsoft.AspNetCore.Mvc;

public class HelloController : Controller
{
    // [HttpGet] // Attribute indicating that this action responds to HTTP GET requests
    // public string SayHello() // Action method that returns a string
    // {
    //     return "Hello from the HelloController!"; // Creates a dynamic View with the message "Hello from the HelloController!"
    // }

    // [HttpGet] // Attribute indicating that this action responds to HTTP GET requests
    // public ViewResult SayHello() // Action method that returns a ViewResult
    // {
    //     return View();
    // }

    [HttpGet] // Attribute indicating that this action responds to HTTP GET requests
    public ViewResult SayHello() // Action method that returns a ViewResult
    {
        ViewData.Add("Message1", "Hello from MVC controller! This is shared using ViewData object!"); // Sending data dynamically to View using ViewData object.
        ViewBag.Message2 = "Hello from MVC controller! This is shared using ViewBag object!"; // Sending data dynamically to View using ViewBag object.
        
        return View();
    }
}