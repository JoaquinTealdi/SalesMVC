using SS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.Model.Dtos
{
    public class SaleDto : BaseResponse
    {
        public int Id { get; set; }
        public string? SalesNumber { get; set; }
        public int? SalesDocumentTypeId { get; set; }
        public int? UserId { get; set; }
        public string? ClientDocument { get; set; }
        public string? ClientName { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? Tax { get; set; }
        public decimal? Total { get; set; }
        public DateTime? CreationDate { get; set; }
        public virtual SalesDocumentTypeDto? SalesDocumentType { get; set; }
        public virtual User? User { get; set; }
        public virtual List<SaleDetailDto> SaleDetails { get; set; }
    }
}
