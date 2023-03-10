//Sukhjit Singh s1171953 
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Airbnb.Data;
using Airbnb.Services;
using Airbnb.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AirbnbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AirbnbContext") ?? throw new InvalidOperationException("Connection string 'AirbnbContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ILocationService, LocationService>();
builder.Services.AddScoped<ILocationRepository, LocationsRepository>();

builder.Services.AddScoped<ILandlordService, LandlordService>();
builder.Services.AddScoped<ILandlordRepository, LandlordRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors(options => options.AllowAnyHeader().AllowAnyOrigin());
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
