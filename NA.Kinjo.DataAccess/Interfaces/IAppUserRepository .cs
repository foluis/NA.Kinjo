using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NA.Kinjo.Entities;

namespace NA.Kinjo.DataAccess.Interfaces
{
    public interface IAppUserRepository
    {
        Task<int> CreateAppUsers(AppUser appUser);
        Task<IEnumerable<AppUser>> GetAppUsers(int pageNum, int pageSize, string sortColumnName, string sortOrder);        
    }
}
