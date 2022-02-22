using HoliDayRental.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.DAL.Repositories
{
    public class OptionsBienRepository : BaseRepository<OptionsBienEntity, (int, int)>
    {
        public OptionsBienRepository(IDbTransaction transaction) : base(transaction)
        {
        }

        protected override string SelectCommand => "SELECT idOption,idBien,Valeur FROM OptionsBien";

        protected override string InsertCommand => "INSERT INTO OptionsBien(idOption,idBien,Valeur) VALUES (@idOption,@idBien,@Valeur);";

        protected override string UpdateCommand => "UPDATE OptionsBien SET Valeur=@Valeur WHERE @idOption=@Id1 AND @idBien= @Id2";

        protected override string DeleteCommand => "DELETE FROM OptionsBien WHERE @idOption=@Id1 AND @idBien= @Id2";

        protected override string OneCommand => "SELECT idOption,idBien,Valeur FROM OptionsBien WHERE @idOption=@Id1 AND @idBien= @Id2";
    }
}
