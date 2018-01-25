using System;

namespace AppCore.Infrastructure.Domain.Model
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}