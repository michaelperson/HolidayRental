using HoliDayRental.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.DAL.Entities
{
    public class OptionsBienEntityWithName  
    {
        private int _idoption;
        private int _idbien;
        private string _valeur;
        private string _libelle;

       

        public int IdOption { get => _idoption; set => _idoption = value; }
        public int IdBien { get => _idbien; set => _idbien = value; }
        public string Valeur { get => _valeur; set => _valeur = value; }

        public (int, int) ID => (IdOption, IdBien);

        public string Libelle { get => _libelle; set => _libelle = value; }
    }
}
