using System;
using System.Collections.Generic;

namespace SS.Model.Models
{
    public partial class Menu
    {
        public Menu()
        {
            InverseFatherMenu = new HashSet<Menu>();
            MenuRoles = new HashSet<MenuRole>();
        }

        public int Id { get; set; }
        public string? Description { get; set; }
        public int? FatherMenuId { get; set; }
        public string? Icon { get; set; }
        public string? Controller { get; set; }
        public string? PageAction { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual Menu? FatherMenu { get; set; }
        public virtual ICollection<Menu> InverseFatherMenu { get; set; }
        public virtual ICollection<MenuRole> MenuRoles { get; set; }
    }
}
