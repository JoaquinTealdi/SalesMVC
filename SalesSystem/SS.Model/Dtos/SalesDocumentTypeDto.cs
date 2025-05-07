using SS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.Model.Dtos
{
    public class SalesDocumentTypeDto : BaseResponse
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }

        public List<SaleDto> Sales { get; set; }
    }
}
