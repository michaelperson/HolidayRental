using HoliDayRental.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.DAL.Entities
{
    public class MembreBienEchangeEntity:IEntity<(int,int, DateTime, DateTime)>
    {
        private int _idmembre;
        private int _idbien;
        private DateTime _datedebechange;
        private DateTime _datefinechange;
        private bool? _assurance;
        private bool _valide;

        public int Idmembre { get => _idmembre; set => _idmembre = value; }
        public int Idbien { get => _idbien; set => _idbien = value; }
        public DateTime Datedebechange { get => _datedebechange; set => _datedebechange = value; }
        public DateTime Datefinechange { get => _datefinechange; set => _datefinechange = value; }
        public bool? Assurance { get => _assurance; set => _assurance = value; }
        public bool Valide { get => _valide; set => _valide = value; }

        public (int, int, DateTime,DateTime) ID => (Idmembre,Idbien, Datedebechange,Datefinechange);
    }
}
