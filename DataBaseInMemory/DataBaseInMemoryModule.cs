using Arquitetura_Hexagonal.Core.Ports;
using DataBaseInMemory.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DataBaseInMemory;

public static class DataBaseInMemoryModule
{
    public static void AddDataBaseInMemoryModule(this IServiceCollection services)
    {
        services.AddTransient<IUserRepository, UserRepository>();
    }
}


