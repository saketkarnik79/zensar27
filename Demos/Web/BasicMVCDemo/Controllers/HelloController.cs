using Microsoft.AspNetCore.Mvc;

public class HelloController : Controller
{
    [HttpGet] // Attribute indicating that this action responds to HTTP GET requests
    public string SayHello() // Action method that returns a string
    {
        return "Hello from the HelloController!"; // Creates a dynamic View with the message "Hello from the HelloController!"
    }
}