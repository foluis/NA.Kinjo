using Dapper;
using DataAccess.Interfaces;
using Models;
using System.Data;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly IBaseRepository _base;

        public AppUserRepository(IBaseRepository baseRepo)
        {
            _base = baseRepo;
        }

        public async Task<AppUser> GetAppUsersByEmail(string email)
        {
            using (var connection = _base.GetConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Email", email);

                var usuario = await connection
                    .QuerySingleOrDefaultAsync<AppUser>("[dbo].[GetAppUsersByEmail]", parameters, null, null, CommandType.StoredProcedure);

                return usuario;

                //return _mapper.Map<Usuario, ApplicationUser>(usuario);
            }
        }
    }
}
