using HB.Domain.Repositories;
using HB.Infrastructure.Context;
using HB.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace HB.Infrastructure
{
    public static class InfrastructureExtensions
    {
        public static IServiceCollection AddInfrastructureModule(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContextPool<HbContext>(options => options.UseSqlServer(configuration.GetConnectionString("Default"),
                b => b.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName) ) );
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IStockItemRepository, StockItemRepository>();
            services.AddScoped<IFirmRepository, FirmRepository>();
            return services;
        }
    }
}
