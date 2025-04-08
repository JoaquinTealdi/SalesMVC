using System;
using System.Collections.Generic;

namespace SS.Model.Models
{
    public partial class Shop
    {
        public int Id { get; set; }
        public string? LogoUrl { get; set; }
        public string? LogoName { get; set; }
        public string? DocumentNumber { get; set; }
        public string? Name { get; set; }
        public string? EmailAddress { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public decimal? Tax { get; set; }
        public string? CurrencySymbol { get; set; }
    }
}
