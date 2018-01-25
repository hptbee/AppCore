﻿using System;
using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class FlexDepartment
    {
        public FlexDepartment()
        {
            FlexUsers = new HashSet<FlexUsers>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsActived { get; set; }

        public ICollection<FlexUsers> FlexUsers { get; set; }
    }
}