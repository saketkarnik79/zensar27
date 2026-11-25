using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using CookieAuthDemo.Models;

namespace CookieAuthDemo.Controllers;

public class AccountController : Controller
{
    [AllowAnonymous]
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [AllowAnonymous]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(
        LoginViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        // Hardcoded credentials for classroom demo only.

        bool isAdmin =
            model.Username == "admin" &&
            model.Password == "Admin@123";

        bool isCustomer =
            model.Username == "customer" &&
            model.Password == "Customer@123";

        if (!isAdmin && !isCustomer)
        {
            ModelState.AddModelError(
                "",
                "Invalid username or password"
            );

            return View(model);
        }

        string role = isAdmin
            ? "Admin"
            : "Customer";

        var claims = new List<Claim>
        {
            new Claim(
                ClaimTypes.Name,
                model.Username
            ),

            new Claim(
                ClaimTypes.Role,
                role
            ),

            new Claim(
                "Department",
                isAdmin ? "Management" : "Retail"
            )
        };

        var identity = new ClaimsIdentity(
            claims,
            CookieAuthenticationDefaults.AuthenticationScheme
        );

        var principal = new ClaimsPrincipal(identity);

        var properties = new AuthenticationProperties
        {
            IsPersistent = model.RememberMe
        };

        await HttpContext.SignInAsync(
            CookieAuthenticationDefaults.AuthenticationScheme,
            principal,
            properties
        );

        return RedirectToAction(
            "Index",
            "Dashboard"
        );
    }

    [Authorize]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Logout()
    {
        await HttpContext.SignOutAsync(
            CookieAuthenticationDefaults.AuthenticationScheme
        );

        return RedirectToAction("Login");
    }

    [AllowAnonymous]
    public IActionResult AccessDenied()
    {
        return View();
    }
}