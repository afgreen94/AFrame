using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AFrame.Base.Contracts.Abstractions;

namespace AFrame.Base.Contracts
{
    public interface IInitializable { ICallResult Initialize(IConfiguration configuration); }
    public interface IAsyncInitializable { ValueTask<ICallResult> InitializeAsync(IConfiguration configuration); }

    public interface IStartable { ICallResult Start(); }
    public interface IStartupInitializable : IInitializable, IStartable { }
    public interface IAsyncStartupInitializable : IAsyncInitializable, IStartable { }
}
