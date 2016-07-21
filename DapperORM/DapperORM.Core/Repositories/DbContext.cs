using System.Data.SqlClient;

namespace DapperORM.Core.Repositories
{
    public class DbContext
    {
        public SqlConnection SqlConnection;
        public DbContext()
        {
            SqlConnection = new SqlConnection(@"Data Source=ibaax-pc3;Initial Catalog=Test;user id=sa;password=admin123#@; MultipleActiveResultSets=true");
        }
    }
}
