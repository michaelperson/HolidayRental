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
            CreateMap<OptionsBienModel, OptionsBienEntityWithName>()
                .ForMember
                (
                  Entity => Entity.Libelle,
                  Model => Model.MapFrom<string>(m => m.Option)
                )
                .ForMember
                (
                  Entity => Entity.IdOption,
                  Model => Model.MapFrom(m => m.Idoption)
                )
                .ForMember
                (
                  Entity => Entity.IdBien,
                  Model => Model.MapFrom(m => m.Idbien)
                )
                .ReverseMap()
                .ForMember
                (
                  Model => Model.Option,
                  Entity => Entity.MapFrom(m => m.Libelle)
                )
                .ForMember
                (
                  Model => Model.Idoption,
                  Entity => Entity.MapFrom(m => m.IdOption)
                )
                .ForMember
                (
                  Model => Model.Idbien,
                  Entity => Entity.MapFrom(m => m.IdBien)
                );

            CreateMap<OptionsBienModel, OptionsBienEntity>().ForMember
                (
                  Entity => Entity.IdOption,
                  Model => Model.MapFrom(m => m.Idoption)
                )
                .ForMember
                (
                  Entity => Entity.IdBien,
                  Model => Model.MapFrom(m => m.Idbien)
                )
                .ReverseMap()
                .ForMember
                (
                  Model => Model.Option,
                  Entity => Entity.Ignore()
                );
        }
    }
}
