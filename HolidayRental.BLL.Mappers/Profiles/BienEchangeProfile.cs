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
            CreateMap<BienEchangeModel, BienEchangeEntity>();
        }
    }
}
