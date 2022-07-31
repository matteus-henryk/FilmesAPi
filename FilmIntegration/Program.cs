using FilmIntegration.Data;
using FilmIntegration.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddAuthentication();
builder.Services.AddAuthorization();

var connectionString = builder.Configuration.GetConnectionString("FilmConnection");

builder.Services.AddDbContext<AppDbContext>(
        opts => opts
        .UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
    );

builder.Services.AddScoped<FilmService, FilmService>();
builder.Services.AddScoped<HttpClient, HttpClient>();
builder.Services.AddScoped<TMDBClientService, TMDBClientService>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
