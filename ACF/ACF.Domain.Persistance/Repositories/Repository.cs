using ACF.Infrastructure.Core;
using ACF.Infrastructure.Core.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ACF.Domain.Persistance.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        IACFUnitOfWork _currentUoW;
        DbSet<TEntity> _dbset;

        public Repository(IACFUnitOfWork aCFUnitOfWork)
        {
            Check.NotNull(aCFUnitOfWork, "aCFUnitOfWork");

            _currentUoW = aCFUnitOfWork;
            _dbset = aCFUnitOfWork.CreateSet<TEntity>();
        }

        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _currentUoW as IUnitOfWork;
            }
        }

        public DbSet<TEntity> DbSet
        {
            get
            {
                return _dbset;
            }
        }

        public void Add(TEntity item)
        {
            Check.NotNull(item, "TEntity");

            _currentUoW.CreateSet<TEntity>().Add(item);
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(Guid Id)
        {
            return _dbset.Find(Id);
        }

        public IEnumerable<TEntity> GetFilteredElements(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetFilteredElements<S>(Expression<Func<TEntity, bool>> filter, int pageIndex, int pageCount, Expression<Func<TEntity, S>> orderByExpression, bool ascending)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetPagedElements<S>(int pageIndex, int pageCount, Expression<Func<TEntity, S>> orderByExpression, bool ascending)
        {
            throw new NotImplementedException();
        }

        public void Modify(TEntity item)
        {
            Check.NotNull(item, "Entity");

            _currentUoW.SetModified<TEntity>(item);
        }

        public void Remove(TEntity item)
        {
            Check.NotNull(item, "Entity");

            var objectSet = _currentUoW.CreateSet<TEntity>();
            objectSet.Attach(item);
            objectSet.Remove(item);
        }
    }
}
