using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayRental.BLL.Mappers
{
    public static class MapperConfig
    {

        public static  MapperConfiguration  Configure()
        {
            return new MapperConfiguration(cfg => {
                cfg.AddMaps(typeof(MapperConfig).Assembly) ;
            });
        }
    }
}
