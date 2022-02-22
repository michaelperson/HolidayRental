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
        public MembreRepository MembreRepository { get; }

        bool Commit();
    }
}

