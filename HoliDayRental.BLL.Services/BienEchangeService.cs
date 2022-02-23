using AutoMapper;
using HolidayRental.BLL.Mappers;
using HoliDayRental.BLL.Models;
using HoliDayRental.BLL.Services.Interfaces;
using HoliDayRental.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.BLL.Services
{
    public class BienEchangeService : IBienEchangeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper mapper;
        public BienEchangeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            mapper=MapperConfig.Configure().CreateMapper();

        }
        public IEnumerable<BienEchangeModel> Get3Last()
        {
            return mapper.Map<IEnumerable<BienEchangeModel>>(_unitOfWork.BienEchangeRepository.GetWithPays().OrderByDescending(m => m.DateCreation).Take(3));
        }

        public IEnumerable<BienEchangeModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BienEchangeAvisModel> GetBest()
        {
            return mapper.Map<IEnumerable<BienEchangeAvisModel>>(_unitOfWork.BienEchangeRepository.GetTopAvis().OrderByDescending(m => m.DateCreation));

        }

        public IEnumerable<BienEchangeModel> GetTop10()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BienEchangeModel> Search(string critere)
        {
            throw new NotImplementedException();
        }
    }
}
