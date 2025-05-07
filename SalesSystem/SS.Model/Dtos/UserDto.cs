using SS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.Model.Dtos
{
    public class UserDto : BaseResponse
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? EmailAddress { get; set; }
        public string? PhoneNumber { get; set; }
        public int? RoleId { get; set; }
        public string? PhotoUrl { get; set; }
        public string? PhotoName { get; set; }
        public string? Password { get; set; }
        public bool? IdActive { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual Role? Role { get; set; }
        public virtual List<SaleDto> Sales { get; set; }
    }
}
