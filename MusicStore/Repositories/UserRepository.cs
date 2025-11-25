using BooksApi.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MusicStore.Data;
using MusicStore.Dto;
using MusicStore.Models;
using System.Reflection.Metadata;

namespace MusicStore.Repositories
{
    public class UserRepository
    {
        StoreContext context = StoreContextFactory.CreateContext();
        //get
        public List<UserDto> GetUsers()
        {
            return context.Users.Select(
                                        x=>new UserDto() { Name=x.Name,Username=x.Username}
                                        ).ToList();
        }
        //post
        public int CreateUser(CreateUserDto user)
        {
            using var transaction = context.Database.BeginTransaction();
            try
            {
                var outputParam = new SqlParameter
                {
                    ParameterName = "@id",
                    SqlDbType = System.Data.SqlDbType.Int,
                    Direction = System.Data.ParameterDirection.Output
                };

                var parameters = new[]
                {
                    new SqlParameter("@Name", user.Name),
                    new SqlParameter("@UserName",user.UserName),
                    new SqlParameter("@Password",user.Password),
                    outputParam
                 };
                context.Database.
                    ExecuteSqlRaw("EXEC createUser @Name ,@UserName, @Password,@id OUTPUT", parameters);
                int UserId = (int)outputParam.Value;

                context.Database.ExecuteSqlInterpolated($@"EXEC updateUser @id={UserId},@Password={user.Password + '!'}");
                transaction.Commit();
                return UserId;
            }
            catch
            {
                transaction.Rollback();
            }
            return 0;
        }
        //put
        //delete

    }
}
