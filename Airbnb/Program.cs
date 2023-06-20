//Sukhjit Singh s1171953
//Dit is de laatste versie...
using Microsoft.EntityFrameworkCore;
using Airbnb.Data;
using System.Text.Json.Serialization;
using System.Reflection;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Airbnb.Options;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AirbnbContext>(options =>

    options.UseSqlServer(
        builder.Configuration.GetConnectionString("AirbnbContext") 
        ?? throw new InvalidOperationException("Connection string 'AirbnbContext' not found."))
    );

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();

// I learned in my comakership how to use the IServiceCollection methods to simplify my program.cs
// by hiding adding/adjusting services by just calling a method that does that for you
builder.Services.AddAirbnbServices();
builder.Services.AddApiConfiguration();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        var provider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();
        foreach (var description in provider.ApiVersionDescriptions)
        {
            options.SwaggerEndpoint(
                    $"/swagger/{description.GroupName}/swagger.json",
                    description.ApiVersion.ToString()
                );
        }
    });
    app.UseCors(options => options.AllowAnyHeader().AllowAnyOrigin());
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();