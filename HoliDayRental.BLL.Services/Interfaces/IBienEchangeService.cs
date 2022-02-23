using HoliDayRental.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.BLL.Services.Interfaces
{
    public interface IBienEchangeService
    {

        IEnumerable<BienEchangeModel> Get3Last();
        IEnumerable<BienEchangeModel> GetTop10();
        IEnumerable<BienEchangeModel> GetAll();

        IEnumerable<BienEchangeModel> Search(string critere);

    }
}
