using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using VueCineApi.Models;
using VueCineApi.Services;
using VueCineApi.Data;
using VueCineApi.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Registra servicios con el contenedor de inyección de dependencias
builder.Services.AddScoped<IMovieService, MovieService>();

// Añade otros servicios al contenedor.
builder.Services.AddControllers();

// Configuración de CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("MyPolicy",
        builder =>
        {
            builder.WithOrigins("http://localhost:8080", "http://localhost:8001") 
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configuración de la base de datos
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<MovieData>();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Usar CORS con la política definida
app.UseCors("MyPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
