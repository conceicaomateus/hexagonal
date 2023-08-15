using Application.Services;
using Arquitetura_Hexagonal.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class ApplicationModule
{
    public static void AddApplicationModule(this IServiceCollection services)
    {
        services.AddTransient<IUserService, UserService>();
    }
}
