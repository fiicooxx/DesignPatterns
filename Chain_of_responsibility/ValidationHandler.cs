using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility
{
    public class ValidationHandler : BaseHandler
    {
        public ValidationHandler(IHandler next) : base(next)
        {
        }

        public override void Handle(RequestContext requestContext)
        {
            if (requestContext.request.EntityId > 100)
            {
                _next.Handle(requestContext);
                return;
            }

            requestContext.respone.IsSuccess = false;
            requestContext.respone.Message = "Validation error";
        }
    }
}
