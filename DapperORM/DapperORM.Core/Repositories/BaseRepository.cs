using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Dapper;

namespace DapperORM.Core.Repositories
{
    public  class BaseRepository<T>:IBaseRepository<T> where T : class
    {
        private readonly DbContext _dbContext;
        public BaseRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public virtual int Insert(T entity)
        {
            var query = QueryBuilder<T>.Insert();
            return _dbContext.SqlConnection.Query<int>(query, entity).Single();
        }

        public int InsertWithoutIdentity(T entity)
        {
            var query = QueryBuilder<T>.InsertWithoutIdentityColumn();
            return _dbContext.SqlConnection.Query<int>(query, entity).Single();
        }

        public virtual int Update(T entity)
        {
            var query = QueryBuilder<T>.Update();
            return _dbContext.SqlConnection.Query<int>(query, entity).Single();
        }
        public virtual int Delete(T entity)
        {
            var query = QueryBuilder<T>.Delete();
            return _dbContext.SqlConnection.Query<int>(query, entity).Single();
        }
        public virtual T Get(T entity)
        {
            var query = QueryBuilder<T>.SelectByPrimaryKey();
            return _dbContext.SqlConnection.Query<T>(query, entity).FirstOrDefault();
        }
        public virtual IEnumerable<T> GetAll()
        {
            var query = QueryBuilder<T>.Select();
            return _dbContext.SqlConnection.Query<T>(query).ToList();
        }
        public virtual IEnumerable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            var query = QueryBuilder<T>.Select();
            return _dbContext.SqlConnection.Query<T>(query, includeProperties).ToList();
        }
        public virtual int GetNewId()
        {
            var query = QueryBuilder<T>.GetNewId();
            return _dbContext.SqlConnection.Query<int>(query).Single();
        }
    }

    public interface IBaseRepository<T> where T :class
    {
        int Insert(T entity);
        int InsertWithoutIdentity(T entity);
        int Update(T entity);
        int Delete(T entity);
        T Get(T entity);
        IEnumerable<T> GetAll();
        IEnumerable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties);
        int GetNewId();

    }


}
