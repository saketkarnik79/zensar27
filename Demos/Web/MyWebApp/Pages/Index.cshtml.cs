using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    private readonly IGreetingService _greetingService;

    public string Message { get; set; } = "";

    public IndexModel(IGreetingService greetingService)
    {
        _greetingService = greetingService;
    }

    public void OnGet()
    {
        Message = $"Welcome to our website made using ASP.NET Core! {_greetingService.Greet("Saket Karnik")}";
    }

    public void OnPost()
    {
        Message = $"Thank you for submitting the form! { Message }";
    }
}