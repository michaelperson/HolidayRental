using HoliDayRental.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.DAL.Repositories
{
    public class PaysRepository : BaseRepository<PaysEntity, int>
    {
        public PaysRepository(IDbTransaction transaction) : base(transaction)
        {
        }

        protected override string SelectCommand => "SELECT idPays,Libelle FROM pays";

        protected override string InsertCommand => "INSERT INTO pays(Libelle) VALUES (@Libelle);";

        protected override string UpdateCommand => "UPDATE pays SET Libelle=@Libelle WHERE idPays= @Id";

        protected override string DeleteCommand => "DELETE FROM pays  WHERE idPays= @Id";

        protected override string OneCommand => "SELECT idPays,Libelle FROM pays WHERE idPays= @Id";

    }
}
