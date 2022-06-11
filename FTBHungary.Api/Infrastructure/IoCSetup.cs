namespace FTBHungary.Api.Infrastructure;

using Common.Logging;
using EnergyStorageSystem.Infrastructure.ContainerInitialize;
using ContainerInitialize;

public static class IoCSetup
{
    public static void Init(IServiceCollection services, IConfiguration config,ILoggingBuilder logger)
    {
        ContainerInitializeServices.Init(services);

        ContainerInitializeDataBase.Init(services, config);
        
        ContainerInitializeAuth.Init(services, config);
        
        LogHelper.Init(config);
    }
}