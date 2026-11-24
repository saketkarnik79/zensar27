using Microsoft.AspNetCore.Mvc;

namespace RetailStoreDemo.ViewComponents;

public class ProductCategoriesViewComponent
    : ViewComponent
{
    // public IViewComponentResult Invoke()
    // {
    //     List<string> categories = new()
    //     {
    //         "Electronics",
    //         "Furniture",
    //         "Clothing",
    //         "Books",
    //         "Sports"
    //     };

    //     return View(categories);
    // }

    public IViewComponentResult Invoke(int count)
    {
        List<string> categories = new()
        {
            "Electronics",
            "Furniture",
            "Clothing",
            "Books",
            "Sports"
        };

        return View(categories.Take(count).ToList());
    }
}