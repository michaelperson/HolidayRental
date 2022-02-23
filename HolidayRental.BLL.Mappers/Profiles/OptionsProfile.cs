using AutoMapper;
using HoliDayRental.BLL.Models;
using HoliDayRental.DAL.Entities;
using System;

namespace HolidayRental.BLL.Mappers.Profiles
{
    public class OptionsProfile : Profile
    {
        public OptionsProfile()
        {
            CreateMap<OptionsModel, OptionsEntity>();
        }
    }
}
