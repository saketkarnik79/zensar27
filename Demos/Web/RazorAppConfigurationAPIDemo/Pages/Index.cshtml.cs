using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorAppConfigurationAPIDemo.Pages;

public class IndexModel : PageModel
{
    private readonly EmailService _emailService;

    public IndexModel(EmailService emailService)
    {
        _emailService = emailService;
    }

    public void OnGet()
    {
        _emailService.ShowSettings();
    }
}
