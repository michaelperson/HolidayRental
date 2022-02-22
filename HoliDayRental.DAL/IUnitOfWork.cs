using HoliDayRental.DAL.Repositories;
using System;

namespace HoliDayRental.DAL
{
    /// <summary>
    /// Interface qui conditionne l'implementation de notre UnitOfWork
    /// Chaque Repository sera ajouté ici pour qu'il puisse y avoir accès 
    /// et ainsi l'implementer
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        public AvisMembreBienRepository AvisMembreBienRepository { get; }
        public BienEchangeRepository BienEchangeRepository { get; }
        public MembreBienEchangeRepository MembreBienEchangeRepository { get;}

        public MembreRepository MembreRepository { get; }

        public OptionsBienRepository OptionsBienRepository { get; }

        public OptionsRepository OptionsRepository { get; }

        public PaysRepository PaysRepository { get; }

        bool Commit();
    }
}

