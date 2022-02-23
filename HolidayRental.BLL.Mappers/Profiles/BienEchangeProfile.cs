using AutoMapper;
using HoliDayRental.BLL.Models;
using HoliDayRental.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayRental.BLL.Mappers.Profiles
{
    public class BienEchangeProfile:Profile
    {
        public BienEchangeProfile()
        {
            CreateMap<BienEchangeModel, BienEchangeEntity>().
                ForMember(
                Entity => Entity.idBien,
                Model => Model.MapFrom(m => m.Idbien)
                ).
                ForMember(
                Entity => Entity.titre,
                Model => Model.MapFrom(m => m.Titre)
                ).
                ForMember(
                Entity => Entity.isEnabled,
                Model => Model.MapFrom(m => m.Isenabled)
                ).
                ForMember(
                Entity => Entity.DescCourte,
                Model => Model.MapFrom(m => m.Desccourte)
                ).
                ForMember(
                Entity => Entity.DescLong,
                Model => Model.MapFrom(m => m.Desclong)
                ).
                ForMember(
                Entity => Entity.NombrePerson,
                Model => Model.MapFrom(m => m.Nombreperson)
                ).
                ForMember(
                Entity => Entity.CodePostal,
                Model => Model.MapFrom(m => m.Codepostal)
                ).
                ForMember(
                Entity => Entity.AssuranceObligatoire,
                Model => Model.MapFrom(m => m.Assuranceobligatoire)
                ).
                ForMember(
                Entity => Entity.DisabledDate,
                Model => Model.MapFrom(m => m.Disableddate)
                ).
                ForMember(
                Entity => Entity.CodePostal,
                Model => Model.MapFrom(m => m.Codepostal)
                ).
                ForMember(
                Entity => Entity.DateCreation,
                Model => Model.MapFrom(m => m.Datecreation)
                ).
                ForMember(
                Entity => Entity.idMembre,
                Model => Model.MapFrom(m => m.Idmembre)
                ).
                ForMember(
                Entity => Entity.LePays,
                Model => Model.MapFrom(m => m.PaysName)
                )
                .ReverseMap()
                .ForMember(
                Model => Model.Idbien,
                Entity => Entity.MapFrom(e => e.idBien)
                )
                .ForMember(
                Model => Model.Titre,
                Entity => Entity.MapFrom(m => m.titre)
                ).
                ForMember(
                Model => Model.Isenabled,
                Entity => Entity.MapFrom(m => m.isEnabled)
                ).
                ForMember(
                Model => Model.Desccourte,
                Entity => Entity.MapFrom(m => m.DescCourte)
                )
                .
                ForMember(
                Model => Model.Desclong,
                Entity => Entity.MapFrom(m => m.DescLong)
                ).
                ForMember(
                Model => Model.Nombreperson,
                Entity => Entity.MapFrom(m => m.NombrePerson)
                ).
                ForMember(
                Model => Model.Codepostal,
                Entity => Entity.MapFrom(m => m.CodePostal)
                ).
                ForMember(
                Model => Model.Assuranceobligatoire,
                Entity => Entity.MapFrom(m => m.AssuranceObligatoire)
                ).
                ForMember(
                Model => Model.Disableddate,
                Entity => Entity.MapFrom(m => m.DisabledDate)
                ).
                ForMember(
                Model => Model.Codepostal,
                Entity => Entity.MapFrom(m => m.CodePostal)
                ).
                ForMember(
                Model => Model.Datecreation,
                Entity => Entity.MapFrom(m => m.DateCreation)
                )
                .
                ForMember(
                Model => Model.Idmembre,
                Entity => Entity.MapFrom(m => m.idMembre)
                ).
                ForMember(
                Model => Model.PaysName,
                Entity => Entity.MapFrom(m => m.LePays)
                )
                ;
        }
    }
}
