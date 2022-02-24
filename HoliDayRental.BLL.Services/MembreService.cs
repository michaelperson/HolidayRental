using AutoMapper;
using HolidayRental.BLL.Mappers;
using HoliDayRental.BLL.Models;
using HoliDayRental.BLL.Services.Interfaces;
using HoliDayRental.DAL;
using HoliDayRental.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.BLL.Services
{
    public  class MembreService : IMembreService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper mapper;
        public MembreService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            mapper = MapperConfig.Configure().CreateMapper();

        }

        public MembreModel Insert(MembreModel m)
        {
            if(_unitOfWork.MembreRepository.Add(mapper.Map<MembreEntity>(m)))
            {
                m.Password = null;
                return m;
            }
            else
            {
                throw new Exception("Unable to save member");
            }

        }
    }
}
