using back.Controllers;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// CORS Config
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.WithOrigins(
                "https://localhost:7264",
                "http://127.0.0.1:5500",
                "http://34.206.154.49:80",
                "http://34.206.154.49:8080",
                "http://34.206.154.49")
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configurar el pipeline de solicitud HTTP
// Solo en desarrollo, habilitar Swagger
//if (app.Environment.IsDevelopment())  // Descomenta esta línea para usar Swagger solo en desarrollo
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// apply CORS
app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
