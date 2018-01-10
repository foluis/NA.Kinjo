using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace NA.Kinjo.DataAccess.Interfaces
{
    public interface IBaseRepository
    {
        string ConnectionString { get; }

        IDbConnection GetConnection();
    }

}
