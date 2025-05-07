using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.Model.Dtos
{
    public class ResponseDto
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public BaseResponse Data { get; set; }
    }

    public abstract class BaseResponse { }



}
