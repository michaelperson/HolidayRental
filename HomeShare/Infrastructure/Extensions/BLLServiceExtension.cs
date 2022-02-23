using HoliDayRental.BLL.Services;
using HoliDayRental.BLL.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace HoliDayRental.Infrastructure.Extensions
{
    public static class BLLServiceExtension
    {

        public  static void RegisterBLLServices(this IServiceCollection service)
        {
            service.AddScoped<IBienEchangeService, BienEchangeService>();
        }
    }
}
