var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.WebHost.UseUrls("http://*:5000", "https://*:5001");

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

Console.WriteLine("Hello, Pluralsight!);

app.Run();
