using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility
{
    public class Request
    {
        public string UserRole { get; set; }
        public int UserId { get; set; }
        public int EntityId { get; set; }
    }

    public class Respone
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }

    public class RequestContext
    {
        public Request request { get; set; }
        public Respone respone { get; set; }
    }
}
