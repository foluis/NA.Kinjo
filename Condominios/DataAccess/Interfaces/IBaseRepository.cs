using System.Data;

namespace DataAccess.Interfaces
{
    public interface IBaseRepository
    {
        string ConnectionString { get; }

        IDbConnection GetConnection();
    }
}
