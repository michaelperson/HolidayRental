using System;

namespace HoliDayRental.DAL.Interfaces
{
    /// <summary>
    /// Permet de definir quelle est la  proprieté pour la Primary Key dans la DB
    /// </summary>
    /// <typeparam name="TKey">Le type de l'identifiant</typeparam>
    public interface IEntity<TKey>
        where TKey : struct
    {
        /// <summary>
        /// Represente la PK dans la DB
        /// </summary>
        TKey ID { get; }
    }
}

