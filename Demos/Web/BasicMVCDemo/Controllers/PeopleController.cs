using Microsoft.AspNetCore.Mvc;

public class PeopleController: Controller
{
    Person p;

    public PeopleController()
    {
        p= new Person()
        {
            Id = 101,
            Name = "James",
            Age = 55
        };
    }    

    [HttpGet]
    public ViewResult Index()
    {
        // ViewData.Model = p;
        // return View();
        return View(p);
    }

    [HttpGet]
    public ViewResult Create()
    {
        return View(p);
    }

    // [HttpPost]
    // public ViewResult Create(IFormCollection form)
    // {
    //     Console.WriteLine($"Id: {form["Id"]}, Name: {form["Name"]}, Age: {form["Age"]}");
    //     return View(new Person());
    // }

    [HttpPost]
    public ViewResult Create(Person person) // Model binding
    {
        if(ModelState.IsValid)
        {
            Console.WriteLine($"Id: {person.Id}, Name: {person.Name}, Age: {person.Age}");
            return View();
        }
        ModelState.AddModelError(string.Empty,"Invalid data.");
        return View();
    }
}