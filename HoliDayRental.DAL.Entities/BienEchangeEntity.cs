using HoliDayRental.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.DAL.Entities
{
    public  class BienEchangeEntity :IEntity<int>
    {
        private int _idbien;
        private string _titre;
        private string _desccourte;
        private string _desclong;
        private int _nombreperson;
        private int _pays;
        private string _ville;
        private string _rue;
        private string _numero;
        private string _codepostal;
        private string _photo;
        private bool _assuranceobligatoire;
        private bool _isenabled;
        private DateTime? _disableddate;
        private string _latitude;
        private string _longitude;
        private int _idmembre;
        private DateTime _datecreation;

        public int Idbien { get => _idbien; set => _idbien = value; }
        public string Titre { get => _titre; set => _titre = value; }
        public string Desccourte { get => _desccourte; set => _desccourte = value; }
        public string Desclong { get => _desclong; set => _desclong = value; }
        public int Nombreperson { get => _nombreperson; set => _nombreperson = value; }
        public int Pays { get => _pays; set => _pays = value; }
        public string Ville { get => _ville; set => _ville = value; }
        public string Rue { get => _rue; set => _rue = value; }
        public string Numero { get => _numero; set => _numero = value; }
        public string Codepostal { get => _codepostal; set => _codepostal = value; }
        public string Photo { get => _photo; set => _photo = value; }
        public bool Assuranceobligatoire { get => _assuranceobligatoire; set => _assuranceobligatoire = value; }
        public bool Isenabled { get => _isenabled; set => _isenabled = value; }
        public DateTime? Disableddate { get => _disableddate; set => _disableddate = value; }
        public string Latitude { get => _latitude; set => _latitude = value; }
        public string Longitude { get => _longitude; set => _longitude = value; }
        public int Idmembre { get => _idmembre; set => _idmembre = value; }
        public DateTime Datecreation { get => _datecreation; set => _datecreation = value; }

        public int ID => Idbien;
    }
}
