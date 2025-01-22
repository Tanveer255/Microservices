using CRMService.BLL.Interface;
using CRMService.BLL.Service;
using CRMService.DAL.Interface;
using CRMService.DAL.Repository;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace CRMService;

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
