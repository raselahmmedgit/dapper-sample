using DapperORM.Core.Entities;

namespace DapperORM.Core.Repositories
{
    public class UserRepository : BaseRepository<User>,IUserRepository
    {
        public UserRepository(DbContext dbContext) 
            : base(dbContext)
        {
        }
    }

    public interface IUserRepository : IBaseRepository<User>
    {
    }


}

