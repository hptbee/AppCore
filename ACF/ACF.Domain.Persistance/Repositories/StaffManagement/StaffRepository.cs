using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACF.Domain.Entities.Staff;
using ACF.Infrastructure.Core.DomainModel;

namespace ACF.Domain.Persistance.Repositories.StaffManagement
{
    public class StaffRepository : Repository<Staff>, IStaffRepository
    {
        public StaffRepository(IACFUnitOfWork aCFUnitOfWork) : base(aCFUnitOfWork)
        {
        }

        public Staff[] GetByUserName(string userName)
        {
            return this.DbSet.Where(a => a.UserName == userName).ToArray();
        }
    }
}
