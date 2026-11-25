using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;

namespace CookieAuthDemo.Controllers;

[AllowAnonymous]
public class ErrorController : Controller
{
    [Route("Error/Status/{statusCode:int}")]
    public IActionResult Status(int statusCode)
    {
        var feature = HttpContext.Features
            .Get<IStatusCodeReExecuteFeature>();

        ViewBag.OriginalPath =
            feature?.OriginalPath;

        ViewBag.StatusCode = statusCode;

        ViewBag.ErrorMessage = statusCode switch
        {
            400 => "Invalid request.",

            401 => "Authentication is required.",

            403 => "You do not have permission.",

            404 => "The requested page was not found.",

            500 => "An internal server error occurred.",

            503 => "Service temporarily unavailable.",

            _ => "An unexpected error occurred."
        };

        Response.StatusCode = statusCode;

        return View("Status");
    }
}