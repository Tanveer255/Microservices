using Microsoft.AspNetCore.Mvc.Infrastructure;
using SWANService.BLL.Interface;
using SWANService.BLL.Service;
using SWANService.DAL.Interface;
using SWANService.DAL.Repository;

namespace SWANService;

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
