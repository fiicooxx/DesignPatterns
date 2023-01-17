using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility
{
    public class AuthorizationHandler : BaseHandler
    {
        private Dictionary<int, int> _entityOwners = new Dictionary<int, int>()
        {
            {100, 13},
            {101, 14}
        };
        public AuthorizationHandler(IHandler next) : base(next) 
        {
        
        }

        public override void Handle(RequestContext requestContext)
        {
            if (requestContext.request.UserRole == "Admin")
            {
                _next.Handle(requestContext);
                return;
            }

            if (_entityOwners.TryGetValue(requestContext.request.EntityId, out int ownerId))
            {
                if (ownerId == requestContext.request.UserId)
                {
                    _next.Handle(requestContext);
                    return;
                }
            }

            requestContext.respone.IsSuccess = false;
            requestContext.respone.Message = "User is not authorized";
        }
    }
}
