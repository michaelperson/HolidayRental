using AutoMapper;
using HoliDayRental.BLL.Models;
using HoliDayRental.DAL.Entities;
using System;

namespace HolidayRental.BLL.Mappers.Profiles
{
    public class MembreProfile : Profile
    {
        public MembreProfile()
        {
            CreateMap<MembreModel, MembreEntity>();
        }
    }
}
