using ACF.Domain.Entities.Mappings;
using ACF.Infrastructure.Core.DomainModel;
using ACF.Infrastructure.Core.Helpers;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace ACF.Infrastructure.MySQLContext
{
    public sealed class ACFUnitOfWork : IdentityDbContext, IACFUnitOfWork
    {
        private string ConnectionString { get; set; }

        public ACFUnitOfWork(string connString)
            : base()
        {
            ConnectionString = connString;
        }

        public ACFUnitOfWork() : this(ConfigurationHelper.GetDefaultConnectionConfig())
        {
        }

        public void Commit()
        {
            base.SaveChanges();
        }

        public void CommitAndRefreshChanges()
        {
            throw new NotImplementedException();
        }

        public void RollbackChanges()
        {
            throw new NotImplementedException();
        }

        #region DbSet Entities

        #endregion
        #region Mappings

        public IList<IModelMapping> ModelMappings { get; set; }

        #endregion Mappings

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ConnectionString);
            optionsBuilder.EnableSensitiveDataLogging(true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ModelMappings = new List<IModelMapping>();

            foreach (var mapping in ModelMappings) {
                mapping.BuildModelMapping(modelBuilder);
            }
        }

        public DbSet<TEntity> CreateSet<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        public void Attach<TEntity>(TEntity item) where TEntity : class
        {
            base.Entry<TEntity>(item).State = EntityState.Unchanged;
        }

        public void SetModified<TEntity>(TEntity item) where TEntity : class
        {
            base.Entry<TEntity>(item).State = EntityState.Modified;
        }
    }
}
