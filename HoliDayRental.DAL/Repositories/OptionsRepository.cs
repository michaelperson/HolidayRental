using HoliDayRental.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.DAL.Repositories
{
    public class OptionsRepository : BaseRepository<OptionsEntity, int>
    {
        public OptionsRepository(IDbTransaction transaction) : base(transaction)
        {
        }

        protected override string SelectCommand => "SELECT idOption,Libelle FROM Options";

        protected override string InsertCommand => "INSERT INTO Options(Libelle) VALUES (@Libelle)";

        protected override string UpdateCommand => "UPDATE Options SET Libelle=@Libelle WHERE idOption= @Id";

        protected override string DeleteCommand => "DELETE FROM Options WHERE idOption= @Id";

        protected override string OneCommand => "SELECT idOption,Libelle FROM Options WHERE idOption= @Id";
    }
}
