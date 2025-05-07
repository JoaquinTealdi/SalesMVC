using SS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.Model.Dtos
{
    public class ProductDto : BaseResponse
    {
        public int Id { get; set; }
        public string? Barcode { get; set; }
        public string? Manufacturer { get; set; }
        public string? Description { get; set; }
        public int? CategoryId { get; set; }
        public int? Stock { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageName { get; set; }
        public decimal? Price { get; set; }
        public bool? IsActive { get; set; }
        public virtual Category? Category { get; set; }

    }
}
