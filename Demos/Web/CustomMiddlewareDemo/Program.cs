var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

//app.UseMiddleware<RequestLoggingMiddleware>();
app.UseRequestLogging();

app.MapGet("/", () => "Welcome to ASP.NET Core");

app.MapGet("/products", () =>
{
    return new[]
    {
        new { Id = 1, Name = "Laptop" },
        new { Id = 2, Name = "Mouse" }
    };
});

app.Run();