using System;
using System.Collections.Generic;

namespace SS.Model.Models
{
    public partial class CorrelativeNumber
    {
        public int Id { get; set; }
        public int? LastNumber { get; set; }
        public int? Digits { get; set; }
        public string? Management { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
