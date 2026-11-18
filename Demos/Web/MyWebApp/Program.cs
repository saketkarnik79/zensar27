var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IGreetingService, GreetingService>();
builder.Services.AddRazorPages();
var app = builder.Build();

app.UseHttpsRedirection(); //Https redirection middleware

// app.MapGet("/", () => "Hello World!");
app.MapGet("/greet", (IGreetingService greetingService) =>
{
    return greetingService.Greet("Saket Karnik");
} );
app.MapRazorPages(); //Map Razor Pages

app.Run();
