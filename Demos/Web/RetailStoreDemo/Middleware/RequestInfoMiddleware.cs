namespace RetailStoreDemo.Middleware;

public class RequestInfoMiddleware
{
    private readonly RequestDelegate _next;

    public RequestInfoMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        context.Items["RequestId"] =
            Guid.NewGuid().ToString();

        context.Items["RequestTime"] =
            DateTime.UtcNow;

        context.Items["ApplicationName"] =
            "Retail Store";

        await _next(context);
    }
}