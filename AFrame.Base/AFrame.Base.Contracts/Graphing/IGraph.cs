using AFrame.Base.Contracts.Abstractions;
using AFrame.Base.Contracts.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFrame.Base.Contracts.Graphing
{
    public interface IVertex
    {
    }

    public interface IEdge : IPair<IPoint> { }

    public interface IEdge<TVertex> : IPair<TVertex> { }

    public interface IWeightableEdge<TWeigth, TVertex> : IEdge<TVertex> { }
    public interface IWeightableEdge<TWeight> : IEdge { }
    public interface IWeightableEdge : IWeightableEdge<IEdgeWeight> { }

    public interface IEdgeWeight { }

    public interface IVertexSet<T>
    {
        ISet<T> Vertices { get; }
    }
    public interface IEdgeSet<TVertex>
    {
        ISet<IEdge<TVertex>> Edges { get; }
    }


    public interface IGraphDefinition { } //for use with coordinate systems ?? 
    public interface IGraphDescription { }

    public interface ISetGraph<T> : IVertexSet<T>, IEdgeSet<T> { }

    public interface IGraph<T> : ISetGraph<T> { }

    public interface IMatrixGraph<T> : IGraph<T> { }


    //public interface IDirectedGraph : IGraph
    //{
    //    bool Directed { get; }
    //}

    //public interface IWeightableGraph : IGraph
    //{
    //    ISet<IWeightableEdge> Edges { get; }
    //}

    //public interface IWeightableGraph<TVertex> : IWeightableGraph
    //{
    //    new ISet<IWeightableEdge<TVertex>> Edges { get; }
    //}

    //public interface IWeightableGraph<TVertex, TEdgeWeight> : IWeightableGraph<TVertex>
    //{
    //    new ISet<IWeightableEdge> Edges { get; }
    //}

}
