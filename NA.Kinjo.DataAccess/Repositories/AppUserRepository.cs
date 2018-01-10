using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using NA.Kinjo.DataAccess.Interfaces;
using NA.Kinjo.Entities;

namespace NA.Kinjo.DataAccess.Repositories
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly IBaseRepository _base;

        public AppUserRepository(IBaseRepository baseRepo)
        {
            _base = baseRepo;
        }

        public async Task<IEnumerable<AppUser>> GetAppUsers(int pageNum, int pageSize, string sortColumnName, string sortOrder)
        {
            IEnumerable<AppUser> appUser = new List<AppUser>();

            try
            {
                using (var connection = _base.GetConnection())
                {
                    appUser = await connection.QueryAsync<AppUser>("SELECT * FROM AppUser", CommandType.Text);
                    //appUser = await connection.QueryAsync<AppUser>("[dbo].[GetAllUsers]", CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                var error = e.ToString();
            }

            return appUser;
        }
    }
}
