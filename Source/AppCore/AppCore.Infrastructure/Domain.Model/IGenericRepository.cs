using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AppCore.Infrastructure.Domain.Model
{
    public interface IGenericRepository<T> where T : Entity
    {
        IQueryable<T> GetAll();

        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);

        Task<IQueryable<T>> FindByAsync(Expression<Func<T, bool>> predicate);

        void Add(T entity);

        void Delete(T entity);

        void Edit(T entity);

        T Get(Guid id);

        Task<T> GetAsync(Guid id);

        T Get(Expression<Func<T, bool>> predicate);

        Task<T> GetAsync(Expression<Func<T, bool>> predicate);

        Task<bool> IsExistsAsync(Expression<Func<T, bool>> predicate);

        Task<bool> IsExistsAsync(Guid id);
    }
}