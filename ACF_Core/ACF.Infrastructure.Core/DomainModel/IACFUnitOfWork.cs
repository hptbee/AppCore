using Microsoft.EntityFrameworkCore;

namespace ACF.Infrastructure.Core.DomainModel
{
    public interface IACFUnitOfWork : IUnitOfWork
    {
        DbSet<TEntity> CreateSet<TEntity>() where TEntity : class;

        void Attach<TEntity>(TEntity item) where TEntity : class;

        void SetModified<TEntity>(TEntity item) where TEntity : class;
    }
}
