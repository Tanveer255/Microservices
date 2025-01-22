using Microsoft.AspNetCore.Mvc.Infrastructure;
using ProductService.BLL.Interface;
using ProductService.BLL.Service;
using ProductService.DAL.Interface;
using ProductService.DAL.Repository;

namespace ProductService;

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
