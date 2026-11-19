// var builder = WebApplication.CreateBuilder(args);

// var app = builder.Build();

// app.Use(async (context, next) =>
// {
//     Console.WriteLine("Before Middleware");

//     await next();

//     Console.WriteLine("After Middleware");
// });

// app.MapGet("/", () => 
// {
//     Console.WriteLine("Within Endpoint");
//     return "Hello ASP.NET Core!";
// });

// app.Run();

// var builder = WebApplication.CreateBuilder(args);

// var app = builder.Build();

// app.Run(async context =>
// {
//     await context.Response.WriteAsync(
//         "Request handled by terminal middleware"
//     );
// });

// app.Run();

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.Map("/admin", adminApp =>
{
    adminApp.Run(async context =>
    {
        await context.Response.WriteAsync(
            "Welcome to Admin Section"
        );
    });
});

app.Run(async context =>
{
    await context.Response.WriteAsync(
        "Welcome to Main Application"
    );
});

app.Run();