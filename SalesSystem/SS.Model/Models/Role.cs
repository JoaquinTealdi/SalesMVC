using System;
using System.Collections.Generic;

namespace SS.Model.Models
{
    public partial class Role
    {
        public Role()
        {
            MenuRoles = new HashSet<MenuRole>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreactionDate { get; set; }

        public virtual ICollection<MenuRole> MenuRoles { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
