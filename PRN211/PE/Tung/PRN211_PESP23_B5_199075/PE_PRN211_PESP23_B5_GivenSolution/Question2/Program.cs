var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseRouting();


app.UseEndpoints(endpoints =>
{
    app.MapGet("/", () => "Hello World!");
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Orders}/{action=Index}/{id?}");
});

app.Run();
