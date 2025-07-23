using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFrame.Base.Contracts.Abstractions
{
    public interface ICallResult
    {
        bool Success { get; }
        string ErrorMessage { get; }
    }

    public interface ICallResult<T> : ICallResult
    {
        T Value { get; }
    }
}
