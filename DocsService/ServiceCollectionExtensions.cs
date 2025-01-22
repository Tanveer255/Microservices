using DocsService.BLL.Interface;
using DocsService.BLL.Service;
using DocsService.DAL.Interface;
using DocsService.DAL.Repository;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace DocsService;

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
