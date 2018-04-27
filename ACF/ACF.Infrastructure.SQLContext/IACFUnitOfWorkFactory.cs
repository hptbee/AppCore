using ACF.Infrastructure.Core.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACF.Infrastructure.SQLContext
{
    public interface IACFUnitOfWorkFactory
    {
        IUnitOfWork Create();
    }
}
