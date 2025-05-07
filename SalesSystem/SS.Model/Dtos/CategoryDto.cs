using SS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.Model.Dtos
{
    public class CategoryDto : BaseResponse
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public virtual ICollection<ProductDto> Products { get; set; }
    }
}
