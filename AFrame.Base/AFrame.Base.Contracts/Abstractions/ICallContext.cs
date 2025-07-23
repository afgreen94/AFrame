using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace AFrame.Base.Contracts.Abstractions
{
    public interface ICallContext
    {
        DateTime ContextCreateTimeUtc { get; }
        void SetClaimsPrincipal(ClaimsPrincipal claimsPrincipal);
        ClaimsPrincipal ClaimsPrincipal { get; }
        Guid? ExternalUserId { get; }
        ILogger LoggerBase { get; }
        IList<object> CallOwners { get; }
        IServiceProvider ServiceProvider { get; }
        ICallContext ChildContext { get; }
        ICallContext ParentContext { get; }
    }

    public interface ICallContext<out TCategoryName> : ICallContext
    {
        ILogger<TCategoryName> Logger { get; }
    }
}
