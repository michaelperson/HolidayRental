using HoliDayRental.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.DAL.Repositories
{
    public class AvisMembreBienRepository : BaseRepository<AvisMembreBienEntity, int>
    {
        public AvisMembreBienRepository(IDbTransaction transaction) : base(transaction)
        {
        }

        protected override string SelectCommand => "SELECT [idAvis],[note],[message],[idMembre],[idBien],[DateAvis],[Approuve]FROM [dbo].[AvisMembreBien]";
        protected override string OneCommand => "SELECT [idAvis],[note],[message],[idMembre],[idBien],[DateAvis],[Approuve] FROM [dbo].[AvisMembreBien] WHERE idAvis=@Id";

        protected override string InsertCommand => @"INSERT INTO AvisMembreBien(note,message,idMembre,idBien,DateAvis,Approuve) VALUES (@note,@message,@idMembre,@idBien,@DateAvis,@Approuve);";

        protected override string UpdateCommand => @"UPDATE AvisMembreBien SET note=@note,message=@message,idMembre=@idMembre,idBien=@idBien,DateAvis=@DateAvis,Approuve=@Approuve WHERE idAvis= @Id;";

        protected override string DeleteCommand => "DELETE FROM AvisMembreBien WHERE idAvis=@Id ";
    }
}
