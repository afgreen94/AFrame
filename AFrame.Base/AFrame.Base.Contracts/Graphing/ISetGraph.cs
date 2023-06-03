using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFrame.Base.Contracts.Graphing
{

    public interface ISetGraph<TVertex> : IGraph<TVertex> 
    {
    }

    public interface ISetGraph : IGraph
    {
    }
}
