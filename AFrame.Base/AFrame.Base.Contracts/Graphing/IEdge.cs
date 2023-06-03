using AFrame.Base.Contracts.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFrame.Base.Contracts.Graphing
{
    public interface IEdge : IPair<IPoint> { }

    public interface IEdge<TVertex> : IPair<TVertex> { }

    public interface IWeightableEdge<TWeigth, TVertex> : IEdge<TVertex> { }
    public interface IWeightableEdge<TWeight> : IEdge { }
    public interface IWeightableEdge : IWeightableEdge<IEdgeWeight> { }

    public interface IEdgeWeight { }
}
