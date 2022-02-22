using HoliDayRental.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.DAL.Entities
{
    public class OptionsEntity:IEntity<int>
    {
        private int _idoption;
        private string _libelle;

        public int Idoption { get => _idoption; set => _idoption = value; }
        public string Libelle { get => _libelle; set => _libelle = value; }

        public int ID => Idoption;
    }
}
