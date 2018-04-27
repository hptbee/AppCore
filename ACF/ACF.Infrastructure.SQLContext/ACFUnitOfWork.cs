using ACF.Domain.Entities.Identity;
using ACF.Domain.Entities.Mappings;
using ACF.Domain.Entities.Staff;
using ACF.Infrastructure.Core.DomainModel;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACF.Infrastructure.SQLContext
{
    public sealed class ACFUnitOfWork : 
        IdentityDbContext<User, 
        GuidIdentityRole, 
        Guid, 
        GuidIdentityUserLogin, 
        GuidIdentityUserRole, 
        GuidIdentityUserClaim> , IACFUnitOfWork
    {
        public ACFUnitOfWork(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
            Initialize();
        }

        private void Initialize()
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public void Commit()
        {
            SaveChanges();
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
        public DbSet<Staff> Users { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new StaffMap());
        }

        public DbSet<TEntity> CreateSet<TEntity>() where TEntity : class
        {
            return Set<TEntity>();
        }

        public void Attach<TEntity>(TEntity item) where TEntity : class
        {
            Entry(item).State = EntityState.Unchanged;
        }

        public void SetModified<TEntity>(TEntity item) where TEntity : class
        {
            Entry(item).State = EntityState.Modified;
        }
    }
}
