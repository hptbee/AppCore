using Microsoft.EntityFrameworkCore;

namespace AppCore.Infrastructure.Domain.Model
{
    public interface IFeedUnitOfWork : IUnitOfWork
    {
        DbSet<TEntity> CreateSet<TEntity>() where TEntity : class;

        void Attach<TEntity>(TEntity item) where TEntity : class;

        void SetModified<TEntity>(TEntity item) where TEntity : class;
    }
}