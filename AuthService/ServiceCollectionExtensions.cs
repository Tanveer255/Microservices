using AuthService.BLL.Interface;
using AuthService.DAL.Interface;
using EdgeAuthService.BLL.Service;
using EdgeAuthService.DAL.Repository;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace AuthService;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddAllCustomServices(this IServiceCollection services)
    {
        services.AddTransient<IActionContextAccessor, ActionContextAccessor>();
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped(typeof(ICrudService<>), typeof(CrudService<>));

        return services;
    }
}

