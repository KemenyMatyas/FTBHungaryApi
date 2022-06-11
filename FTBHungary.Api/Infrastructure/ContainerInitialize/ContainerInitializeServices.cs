namespace EnergyStorageSystem.Infrastructure.ContainerInitialize;

using Common.Infrastructure;
using Common.Mappers;
using Microsoft.Extensions.DependencyInjection.Extensions;


public static class  ContainerInitializeServices
{
    public static void Init(IServiceCollection services)
    {
        SetupManagers(services);
    }

    private static void SetupManagers(IServiceCollection services)
    {
        services.AddAutoMapper(typeof(AutoMapper));
        services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        services.AddScoped<IAppContext, AppContext>();
    }

}
