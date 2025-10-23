var builder = WebApplication.CreateBuilder(args);

// Enable CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();
app.UseCors("AllowAll");

app.MapGet("/products", () => new[]{
    new { Id = 1, Name = "Laptop", Price = 1200 },
    new { Id = 2, Name = "Phone", Price = 800 }
});

app.Run();

//FEVM1