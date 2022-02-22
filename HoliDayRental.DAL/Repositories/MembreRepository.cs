using HoliDayRental.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.DAL.Repositories
{
    public class MembreRepository : BaseRepository<MembreEntity, int>
    {
        public MembreRepository(IDbTransaction transaction) : base(transaction)
        {
        }

        protected override string SelectCommand => "SELECT [idMembre],[Nom],[Prenom],[Email],[Pays],[Telephone],[Login],[Password] FROM [dbo].[Membre]";
        protected override string OneCommand => "SELECT [idMembre],[Nom],[Prenom],[Email],[Pays],[Telephone],[Login],[Password] FROM [dbo].[Membre] WHERE IdMembre=@Id";

        protected override string InsertCommand => @"INSERT INTO [dbo].[Membre] ([Nom],[Prenom],[Email],[Pays],[Telephone],[Login],[Password])
                                                     VALUES  (@Nom,@Prenom,@Email,@Pays,@Telephone,@Login,@Password,)";

        protected override string UpdateCommand => @"UPDATE [dbo].[Membre]
                                                       SET [Nom] = @Nom
                                                          ,[Prenom] = @Prenom
                                                          ,[Email] = @Email
                                                          ,[Pays] = @Pays
                                                          ,[Telephone] = @Telephone 
                                                          ,[Login] = @Login 
                                                          ,[Password] = @Password
                                                     WHERE idMembre=@Id";

        protected override string DeleteCommand => "DELETE FROM Membre WHERE idMembre=@Id ";
    }
}
