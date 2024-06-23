using Microsoft.EntityFrameworkCore;
using ArticulosOficinaApp.Server.Context;

var builder = WebApplication.CreateBuilder(args);

// Se añaden conexion a Base de datos 

var connectionString = builder.Configuration.GetConnectionString("Connection");

// Registrar servicio para la conexion
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseSqlServer(connectionString)
);


// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
