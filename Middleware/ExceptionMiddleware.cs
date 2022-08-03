namespace WebApplication1.Middleware;


public class ExceptionMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionMiddleware(RequestDelegate next)
    {
        this._next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try {
            await _next.Invoke(context);
        }
        catch(Exception e) {
            await context.Response.WriteAsync(e.Message);
        }
    }
}
