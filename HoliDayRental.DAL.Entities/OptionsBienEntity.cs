using HoliDayRental.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.DAL.Entities
{
    public class OptionsBienEntity : IEntity<(int,int)>
    {
        private int _idoption;
        private int _idbien;
        private string _valeur;

       

        public int Idoption { get => _idoption; set => _idoption = value; }
        public int Idbien { get => _idbien; set => _idbien = value; }
        public string Valeur { get => _valeur; set => _valeur = value; }

        public (int, int) ID => (Idoption, Idbien);
    }
}
