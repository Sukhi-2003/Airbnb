//Sukhjit Singh s1171953
//Dit is de laatste versie...
using Microsoft.EntityFrameworkCore;
using Airbnb.Data;
using Airbnb.Services;
using Airbnb.Repositories;
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
    // using System.Reflection;
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();

builder.Services.AddScoped<IAirbnbRepository, AirbnbRepository>();
builder.Services.AddScoped<ISearchService, SearchService>();
builder.Services.AddScoped<IReservationService, ReservationService>();
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddApiVersioning(config =>
{
    config.AssumeDefaultVersionWhenUnspecified = true;
});

builder.Services.AddVersionedApiExplorer(setup => 
{
    //setup.GroupNameFormat = "'v'VVV";
    setup.SubstituteApiVersionInUrl = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
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