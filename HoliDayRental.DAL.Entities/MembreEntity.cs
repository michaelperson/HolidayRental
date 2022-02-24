﻿using HoliDayRental.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.DAL.Entities
{
    public class MembreEntity : IEntity<int>
    {
        private int _idMembre;
        private string _nom;
        private string _prenom;
        private string _email;
        private int _pays;
        private string _telephone;
        private string _login;
        private string _password;

        public int idMembre { get => _idMembre; set => _idMembre = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public string Email { get => _email; set => _email = value; }
        public int Pays { get => _pays; set => _pays = value; }
        public string Telephone { get => _telephone; set => _telephone = value; }
        public string Login { get => _login; set => _login = value; }
        public string Password { get => _password; set => _password = value; }

        public int ID => idMembre;
    }
}
