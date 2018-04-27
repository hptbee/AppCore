using System;
using System.Collections.Generic;
using System.Text;

namespace ACF.Infrastructure.Core.DomainModel
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Commit all changes made in  a container.
        /// </summary>
        ///<remarks>
        /// If entity have fixed properties and optimistic concurrency problem exists 
        /// exception is thrown
        ///</remarks>
        void Commit();

        /// <summary>
        /// Commit all changes made in  a container.
        /// </summary>
        ///<remarks>
        /// If entity have fixed properties and optimistic concurrency problem exists 
        /// client changes are refereshed
        ///</remarks>
        void CommitAndRefreshChanges();

        /// <summary>
        /// Rollback changes not stored in databse at 
        /// this moment. See references of UnitOfWork pattern
        /// </summary>
        void RollbackChanges();
    }
}
