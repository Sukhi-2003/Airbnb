using Airbnb.Repositories;
using Airbnb.Services;
using System.Text.Json.Serialization;

namespace Airbnb.Options;

public static class ConfigureServices
{
    public static IServiceCollection AddAirbnbServices(this IServiceCollection services)
    {
        services.AddScoped<IAirbnbRepository, AirbnbRepository>();
        services.AddScoped<ISearchService, SearchService>();
        services.AddScoped<IReservationService, ReservationService>();

        return services;
    }

    public static IServiceCollection AddApiConfiguration(this IServiceCollection services)
    {
        services.AddControllers().AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        });

        services.AddAutoMapper(typeof(Program));

        services.AddApiVersioning(config =>
        {
            config.AssumeDefaultVersionWhenUnspecified = true;
        });

        services.AddVersionedApiExplorer(setup =>
        {
            setup.SubstituteApiVersionInUrl = true;
        });

        return services;
    }
}