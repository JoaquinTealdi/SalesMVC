using System;
using System.Collections.Generic;

namespace SS.Model.Models
{
    public partial class User
    {
        public User()
        {
            Sales = new HashSet<Sale>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? EmailAddress { get; set; }
        public string? PhoneNumber { get; set; }
        public int? RoleId { get; set; }
        public string? PhotoUrl { get; set; }
        public string? PhotoName { get; set; }
        public string? Password { get; set; }
        public bool? IdActive { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual Role? Role { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
