var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IGreetingService, GreetingService>();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/greet", (IGreetingService greetingService) =>
{
    return greetingService.Greet("Saket Karnik");
} );

app.Run();
