using ACF.Domain.Entities.Staff;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACF.Domain.Entities.Mappings
{
    public class StaffMap : EntityTypeConfiguration<Staff.Staff>
    {
        public StaffMap()
        {
            this.HasKey(a => a.Id);
        }
    }
}
