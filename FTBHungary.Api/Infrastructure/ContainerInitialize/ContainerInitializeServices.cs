namespace EnergyStorageSystem.Infrastructure.ContainerInitialize;

using Common.Infrastructure;
using Common.Mappers;
using FTBHungary.Data.Models;
using FTBHungary.Logic.IServices;
using FTBHungary.Logic.Services;
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
        services.AddScoped<IUserService, UserService>();
    }

}
