
using System;

namespace HoliDayRental.BLL.Models
{
    public class PaysModel  
    {
        private int _idPays;
        private string _libelle;

        public int ID => IdPays;

        public int IdPays { get => _idPays; set => _idPays = value; }
        public string Libelle { get => _libelle; set => _libelle = value; }
    }
}
