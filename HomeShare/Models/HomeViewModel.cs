using HoliDayRental.BLL.Models;
using HoliDayRental.BLL.Services.Interfaces;
using System.Collections.Generic;

namespace HoliDayRental.Models
{
    public class HomeViewModel
    {
        private readonly IBienEchangeService _bienService;

        public HomeViewModel(IBienEchangeService bienService)
        {
            _bienService = bienService;
        }

        public IEnumerable<BienEchangeModel> Last3
        {
            get { return _bienService.Get3Last(); }
        }

        public IEnumerable<BienEchangeModel> Top10
        {
            get { return _bienService.GetTop10(); }
        }

        public IEnumerable<BienEchangeAvisModel> Best
        {
            get { return _bienService.GetBest(); }
        }
    }
}
