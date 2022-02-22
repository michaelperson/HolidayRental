using HoliDayRental.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.DAL.Repositories
{
    public class MembreBienEchangeRepository : BaseRepository<MembreBienEchangeEntity, (int, int, DateTime, DateTime)>
    {
        public MembreBienEchangeRepository(IDbTransaction transaction) : base(transaction)
        {
        }

        protected override string SelectCommand => "SELECT idMembre,idBien,DateDebEchange,DateFinEchange,Assurance,Valide FROM MembreBienEchange";

        protected override string InsertCommand => "INSERT INTO MembreBienEchange(idMembre,idBien,DateDebEchange,DateFinEchange,Assurance,Valide) VALUES (@idMembre,@idBien,@DateDebEchange,@DateFinEchange,@Assurance,@Valide);";

        protected override string UpdateCommand => "UPDATE MembreBienEchange SET Assurance=@Assurance,Valide=@Valide WHERE idMembre=@idMembre AND idBien=@idBien AND DateDebEchange=@DateDebEchange AND DateFinEchange=@DateFinEchange";

        protected override string DeleteCommand => "DELETE FROM MembreBienEchange WHERE idMembre=@idMembre AND idBien=@idBien AND DateDebEchange=@DateDebEchange AND DateFinEchange=@DateFinEchange";

        protected override string OneCommand => "SELECT idMembre,idBien,DateDebEchange,DateFinEchange,Assurance,Valide FROM MembreBienEchange WHERE idMembre=@idMembre AND idBien=@idBien AND DateDebEchange=@DateDebEchange AND DateFinEchange=@DateFinEchange";
    }
}
