using System;
using System.Collections.Generic;

namespace SS.Model.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
