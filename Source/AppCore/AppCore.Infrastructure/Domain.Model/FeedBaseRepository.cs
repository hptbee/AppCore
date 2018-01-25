using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AppCore.Infrastructure.Domain.Model
{
    public abstract class FeedBaseRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : Entity
    {
        private IFeedUnitOfWork _context;

        public FeedBaseRepository(IFeedUnitOfWork unitOfWork)

        {
            //Check.NotNull(unitOfWork, "unitOfWork");

            _context = unitOfWork;
        }

        public IUnitOfWork DbContext
        {
            get
            {
                return _context;
            }
        }

        public virtual void Add(TEntity item)
        {
            if (item != null)
            {
                GetSet().Add(item);
                _context.Commit();
            }
        }

        public virtual TEntity Get(Guid id)
        {
            if (id != Guid.Empty)
            {
                return GetSet().Find(id);
            }
            return null;
        }

        public virtual async Task<TEntity> GetAsync(Guid id)
        {
            if (id != Guid.Empty)
            {
                return await GetSet().FindAsync(id);
            }
            return null;
        }

        public virtual TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            return GetSet().FirstOrDefault(predicate);
        }

        public virtual async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await GetSet().FirstOrDefaultAsync(predicate);
        }

        IQueryable<TEntity> IGenericRepository<TEntity>.GetAll()
        {
            return GetSet().AsQueryable();
        }

        public IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            return GetSet().Where(predicate).AsQueryable();
        }

        public async Task<IQueryable<TEntity>> FindByAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await Task.Run(() => GetSet().Where(predicate).AsQueryable());
        }

        public void Delete(TEntity entity)
        {
            if (entity != null)
            {
                _context.Attach(entity);
                GetSet().Remove(entity);
                _context.Commit();
            }
        }

        public void Edit(TEntity entity)
        {
            if (entity != null)
            {
                _context.SetModified(entity);
                _context.Commit();
            }
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private DbSet<TEntity> GetSet()
        {
            return _context.CreateSet<TEntity>();
        }

        protected virtual Guid ParseGuid(string guidStr)
        {
            try
            {
                return Guid.Parse(guidStr);
            }
            catch { return Guid.Empty; }
        }

       

        public async Task<bool> IsExistsAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await GetSet().AnyAsync(predicate);
        }

        public async Task<bool> IsExistsAsync(Guid id)
        {
            return await IsExistsAsync(p => p.Id == id);
        }
    }
}