﻿using System;
using System.Collections.Generic;

namespace SS.Model.Models
{
    public partial class SaleDetail
    {
        public int Id { get; set; }
        public int? SaleId { get; set; }
        public int? ProductId { get; set; }
        public string? ProductManufacturer { get; set; }
        public string? ProductDescription { get; set; }
        public string? ProductCategory { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? Total { get; set; }

        public virtual Sale? Sale { get; set; }
    }
}
