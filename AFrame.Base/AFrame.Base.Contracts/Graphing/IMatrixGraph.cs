using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFrame.Base.Contracts.Graphing
{

    public interface IMatrixGraph<TVertex> : ISetGraph<TVertex> 
    {

    }
    public interface IMatrixGraph : ISetGraph
    {
    }
}
