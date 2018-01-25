﻿using System;

namespace AppCore.Entity.Models
{
    public partial class FlexLogs
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public string Thread { get; set; }
        public string Level { get; set; }
        public string Logger { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
        public long? CreatedBy { get; set; }
    }
}
