using AutoMapper;
using HoliDayRental.BLL.Models;
using HoliDayRental.DAL.Entities;
using System;

namespace HolidayRental.BLL.Mappers.Profiles
{
    public class OptionsBienProfile : Profile
    {
        public OptionsBienProfile()
        {
            CreateMap<OptionsBienModel, OptionsBienEntity>();
        }
    }
}
