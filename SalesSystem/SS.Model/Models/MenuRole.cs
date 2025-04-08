using System;
using System.Collections.Generic;

namespace SS.Model.Models
{
    public partial class MenuRole
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public int? MenuId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual Menu? Menu { get; set; }
        public virtual Role? Role { get; set; }
    }
}
