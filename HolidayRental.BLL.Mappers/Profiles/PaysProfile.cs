using AutoMapper;
using HoliDayRental.BLL.Models;
using HoliDayRental.DAL.Entities;
using System;

namespace HolidayRental.BLL.Mappers.Profiles
{
    public class PaysProfile : Profile
    {
        public PaysProfile()
        {
            CreateMap<PaysModel, PaysEntity>();
        }
    }
}
