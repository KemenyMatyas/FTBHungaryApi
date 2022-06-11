namespace FTBHungary.Api.Infrastructure.ContainerInitialize;

using DataAccess;
using Microsoft.EntityFrameworkCore;

public static class ContainerInitializeDataBase
{
    public static void Init(IServiceCollection services, IConfiguration config)
    {
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 27));
        services.AddDbContext<FTBHungaryContext>(
            dbContextOptions => dbContextOptions
                .UseMySql(config.GetConnectionString("DefaultConnection"), serverVersion));
    }
}


