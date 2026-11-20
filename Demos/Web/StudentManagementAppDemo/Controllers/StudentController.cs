using Microsoft.AspNetCore.Mvc;
using StudentManagementApp.Models;

namespace StudentManagementApp.Controllers;

public class StudentController : Controller
{
    // public IActionResult Index()
    // {
    //     ViewData["Title"] = "Student List";
    //     ViewBag.Message = "Welcome to Student Management";

    //     return View();
    // }

    public IActionResult Index()
{
    var students = new List<Student>
    {
        new Student { Id = 1, Name = "Amit", Course = "C#" },
        new Student { Id = 2, Name = "Neha", Course = "ASP.NET Core" }
    };

    return View(students);
}
}