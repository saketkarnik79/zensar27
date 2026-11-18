var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var products = new List<Product>
{
    new Product { Id = 1, Name = "Product 1", Price = 10.0m },
    new Product { Id = 2, Name = "Product 2", Price = 20.0m },
    new Product { Id = 3, Name = "Product 3", Price = 30.0m }
};


app.UseRouting(); // Routing middleware is required for endpoint routing to work

app.MapGet("/", () => "Hello World!");
//app.MapGet("/products", () => products);
app.MapGet("/products", () => Results.Ok(products));
app.MapGet("/products/{id:int}", (int id) =>
{
    var product = products.FirstOrDefault(p => p.Id == id);
    if (product == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(product);
});



app.Run();
