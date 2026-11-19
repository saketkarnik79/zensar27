public class RequestLoggingMiddleware
{
    private readonly RequestDelegate _next;

    public RequestLoggingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
       if(!context.Request.Headers.ContainsKey("X-API-Key"))
        {
            context.Response.StatusCode = 401; // Unauthorized
            await context.Response.WriteAsync("Missing API Key.");
            return; // Short-circuit the request pipeline
        }
        else
        {
            Console.WriteLine(
                $"Request: {context.Request.Method} " +
                $"{context.Request.Path}"
            );
            await _next(context);
            Console.WriteLine(
                $"Response Status: {context.Response.StatusCode}"
            );
        }
    }
}

public static class RequestLoggingMiddlewareExtensions
{
    public static IApplicationBuilder UseRequestLogging(
        this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<RequestLoggingMiddleware>();
    }
}