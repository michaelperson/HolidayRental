using HoliDayRental.DAL.Interfaces;
using System;

namespace HoliDayRental.DAL.Entities
{
    public class PaysEntity : IEntity<int>
    {
        private int _idPays;
        private string _libelle;

        public int ID => IdPays;

        public int IdPays { get => _idPays; set => _idPays = value; }
        public string Libelle { get => _libelle; set => _libelle = value; }
    }
}
