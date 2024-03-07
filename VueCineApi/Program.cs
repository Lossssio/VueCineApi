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
builder.Services.AddScoped<ISalaServices, SalaServices>(); 
builder.Services.AddScoped<ICineServices, CineServices>(); 
builder.Services.AddScoped<IAsientoService, AsientoServices>(); 
builder.Services.AddScoped<ISesionService, SesionServices>(); 


// Añade otros servicios al contenedor.
builder.Services.AddControllers();

// Configuración de CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigin", builder =>
        {
            builder.WithOrigins("http://localhost:5173") 
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
builder.Services.AddScoped<SalaData>();
builder.Services.AddScoped<CineData>();
builder.Services.AddScoped<AsientoData>();
builder.Services.AddScoped<SesionData>();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Usar CORS con la política definida
app.UseCors("AllowOrigin");

app.UseAuthorization();

app.MapControllers();

app.Run();
