
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.BLL.Models
{
    public class OptionsModel
    {
        private int _idoption;
        private string _libelle;

        public int Idoption { get => _idoption; set => _idoption = value; }
        public string Libelle { get => _libelle; set => _libelle = value; }
         
    }
}
