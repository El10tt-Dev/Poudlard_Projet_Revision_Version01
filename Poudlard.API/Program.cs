using Microsoft.EntityFrameworkCore;
using Poudlard.Infrastructure.Database.Context;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Ajout de la connectionString via l'injection de dépendance
// => L'instance de Poudlard sera fournie dans le constructeur de la classe qui
// a besoin de PoudllardContext avec la configuration de 
builder.Services.AddDbContext<PoudlardContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

// Gestion des Cors
builder.Services.AddCors();

builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseCors(); // Permet d'utiliser les CORS

app.UseAuthorization();

app.MapControllers();
app.MapGet("/", () => "Bonjour");

app.Run();
