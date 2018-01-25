using System;

namespace AppCore.Entity.Models
{
    public partial class SaleContactEmails
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Content { get; set; }
        public string Company { get; set; }
        public DateTime? DateSend { get; set; }
        public string Bussiness { get; set; }
        public string ProductName { get; set; }
    }
}
