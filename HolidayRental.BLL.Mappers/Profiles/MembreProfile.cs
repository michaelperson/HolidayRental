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
            CreateMap<MembreModel, MembreEntity>()
                .ForMember(
                Entity => Entity.idMembre,
                Model => Model.MapFrom(m=>m.IdMembre)
                )
                .ReverseMap()
                .ForMember(
                Model => Model.IdMembre,
                Entity => Entity.MapFrom(m => m.idMembre)
                )
                ;
            
        }
    }
}
