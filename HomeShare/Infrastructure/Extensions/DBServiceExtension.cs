using HoliDayRental.DAL;
using Microsoft.Extensions.DependencyInjection;

namespace HoliDayRental.Infrastructure.Extensions
{
    public static class DBServiceExtension
    {
        public static void RegisterDbConfig(this IServiceCollection services, string Connectionstring)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>(u=> new UnitOfWork(Connectionstring));
        }
    }
}
