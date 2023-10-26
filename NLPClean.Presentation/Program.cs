using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NLPClean.Infrastructure;
using NLPCleanArchitecture.Application;
using NLPWithCleanArhitecture.Domain;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

ConfigurationManager configurationManager = builder.Configuration;

builder.Services.AddDbContext<Context>(options =>
{
    options.UseSqlServer(configurationManager.GetConnectionString("Development"));
});

builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();



//dependency injection lifetime.........
//builder.Services.AddTransient<IDependencyInjectionService, DependencyInjectionService>();
//builder.Services.AddTransient<IDependencyInjectionRepository, DependencyInjectionRepository>();
builder.Services.AddScoped<IDependencyInjectionService, DependencyInjectionService>();
builder.Services.AddScoped<IDependencyInjectionRepository, DependencyInjectionRepository>();
//builder.Services.AddSingleton<IDependencyInjectionService, DependencyInjectionService>();
//builder.Services.AddSingleton<IDependencyInjectionRepository, DependencyInjectionRepository>();
//dependency injection lifetime.........




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
