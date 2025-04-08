using System;
using System.Collections.Generic;

namespace SS.Model.Models
{
    public partial class Sale
    {
        public Sale()
        {
            SaleDetails = new HashSet<SaleDetail>();
        }

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

        public virtual SalesDocumentType? SalesDocumentType { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<SaleDetail> SaleDetails { get; set; }
    }
}
