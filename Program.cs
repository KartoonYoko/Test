using WebApplication1.Services;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/check", async (CheckHttp service, HttpContext ctx) => {
    await ctx.Response.WriteAsync(await service.SendMessage("http://localhost:7010"));
});


app.Run();
