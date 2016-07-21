using DapperORM.Core.Entities;
using DapperORM.Core.Repositories;

namespace DapperORM.Core.Services
{
    public class UserService : BaseService<User>, IUserService
    {
        public UserService(IBaseRepository<User> iBaseRepository, DbContext dbContext) 
            : base(iBaseRepository, dbContext)
        {
        }
    }

    public interface IUserService : IBaseService<User>
    {
    }
}
