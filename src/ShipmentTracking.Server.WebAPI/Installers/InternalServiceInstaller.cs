
using ShipmentTracking.Server.Application;
using ShipmentTracking.Server.Infrastructure;

namespace ShipmentTracking.Server.WebAPI.Installers;

public static class InternalServiceInstaller
{
    public static IServiceCollection AddInternalServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddApplication();
        services.AddInfrastructure(configuration);
        services.AddCors();
        services.AddExceptionHandler<ExceptionHandler>().AddProblemDetails();
        //services.AddKeycloakWebApiAuthentication(builder.Configuration);
        //services.AddAuthorization().AddKeycloakAuthorization(builder.Configuration);
        return services;
    }
}