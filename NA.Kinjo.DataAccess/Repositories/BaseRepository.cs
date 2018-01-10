using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using NA.Kinjo.DataAccess.Interfaces;
using NA.Kinjo.Entities;

namespace NA.Kinjo.DataAccess.Repositories
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
