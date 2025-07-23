using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AFrame.Base.Contracts.Abstractions;
using Microsoft.Extensions.Logging;

namespace AFrame.Base.Abstractions
{
    public class CallContext : ICallContext
    {
        public DateTime ContextCreateTimeUtc => throw new NotImplementedException();

        public ClaimsPrincipal ClaimsPrincipal => throw new NotImplementedException();

        public Guid? ExternalUserId => throw new NotImplementedException();

        public ILogger LoggerBase => throw new NotImplementedException();

        public IList<object> CallOwners => throw new NotImplementedException();

        public IServiceProvider ServiceProvider => throw new NotImplementedException();

        public ICallContext ChildContext => throw new NotImplementedException();

        public ICallContext ParentContext => throw new NotImplementedException();

        public void SetClaimsPrincipal(ClaimsPrincipal claimsPrincipal)
        {
            throw new NotImplementedException();
        }
    }
}
