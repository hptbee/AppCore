using ACF.Domain.Entities.Staff;
using ACF.Infrastructure.Core.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACF.Domain.Persistance.Repositories.StaffManagement
{
    public interface IStaffRepository : IRepository<Staff>
    {
        Staff[] GetByUserName(string userName);
    }
}
