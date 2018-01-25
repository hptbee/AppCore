using System;

namespace AppCore.Entity.Models
{
    public partial class SaleResumes
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public bool Sex { get; set; }
        public DateTime? Birthday { get; set; }
        public string Position { get; set; }
        public string Qualification { get; set; }
        public string Experience { get; set; }
        public string Money { get; set; }
        public string Avatar { get; set; }
        public string Cvattact { get; set; }
        public string FileAttact { get; set; }
        public DateTime? DateSend { get; set; }
        public string Note { get; set; }
    }
}
