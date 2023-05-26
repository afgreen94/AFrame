using Abstractions.Contracts;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Contracts
{
    public interface IInitializable { IResult Initialize(IConfiguration configuration); }
    public interface IAsyncInitializable { ValueTask<IResult> InitializeAsync(IConfiguration configuration); }

    public interface IStartable { IResult Start(); }
    public interface IStartupInitializable : IInitializable, IStartable { }
    public interface IAsyncStartupInitializable : IAsyncInitializable, IStartable { }
}
