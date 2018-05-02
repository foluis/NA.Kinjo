using DataAccess.Interfaces;
using Models;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Repositories
{
    public class BaseRepository : IBaseRepository
    {
        public string ConnectionString { get; }

        public BaseRepository(CustomSettings customConfig)
        {           
            ConnectionString = customConfig.ConnectionString;
        }

        public IDbConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

    }
}
