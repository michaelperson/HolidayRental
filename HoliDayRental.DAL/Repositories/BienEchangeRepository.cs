using HoliDayRental.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.DAL.Repositories
{
    public class BienEchangeRepository : BaseRepository<BienEchangeEntity, int>
    {
        public BienEchangeRepository(IDbTransaction transaction) : base(transaction)
        {
        }

        protected override string SelectCommand => "SELECT [idBien],[titre],[DescCourte],[DescLong],[NombrePerson],[Pays],[Ville],[Rue],[Numero],[CodePostal],[Photo],[AssuranceObligatoire],[isEnabled],[DisabledDate],[Latitude],[Longitude],[idMembre],[DateCreation]  FROM [dbo].[BienEchange]";

        protected override string InsertCommand => "INSERT INTO BienEchange(titre,DescCourte,DescLong,NombrePerson,Pays,Ville,Rue,Numero,CodePostal,Photo,AssuranceObligatoire,isEnabled,DisabledDate,Latitude,Longitude,idMembre,DateCreation) VALUES (@titre,@DescCourte,@DescLong,@NombrePerson,@Pays,@Ville,@Rue,@Numero,@CodePostal,@Photo,@AssuranceObligatoire,@isEnabled,@DisabledDate,@Latitude,@Longitude,@idMembre,@DateCreation);";

        protected override string UpdateCommand => "UPDATE BienEchange SET titre=@titre,DescCourte=@DescCourte,DescLong=@DescLong,NombrePerson=@NombrePerson,Pays=@Pays,Ville=@Ville,Rue=@Rue,Numero=@Numero,CodePostal=@CodePostal,Photo=@Photo,AssuranceObligatoire=@AssuranceObligatoire,isEnabled=@isEnabled,DisabledDate=@DisabledDate,Latitude=@Latitude,Longitude=@Longitude,idMembre=@idMembre,DateCreation=@DateCreation WHERE idBien= @Id;";

        protected override string DeleteCommand => "DELETE FROM [dbo].[BienEchange] WHERE idBien= @Id;";

        protected override string OneCommand => "SELECT[idBien],[titre],[DescCourte],[DescLong],[NombrePerson],[Pays],[Ville],[Rue],[Numero],[CodePostal],[Photo],[AssuranceObligatoire],[isEnabled],[DisabledDate],[Latitude],[Longitude],[idMembre],[DateCreation] FROM[dbo].[BienEchange] WHERE idBien= @Id;";
    }
}
