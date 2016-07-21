using System.Data;
using System.Data.SqlClient;

namespace DapperORM.Core.Repositories
{
    public interface IDbContext
    {
        SqlConnection SqlConnection { get; set; }
    }
}
