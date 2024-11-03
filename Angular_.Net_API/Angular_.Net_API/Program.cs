var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();


app.MapGet("~/", () => Results.Redirect("api/books"));


app.MapControllers();

app.Run();
