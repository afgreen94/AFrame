using AFrame.Base.Contracts.Abstractions;
using AFrame.Base.Contracts.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFrame.Base.Contracts.Graphing        //appropriately level of generality for dimensionality of graph is unclear
                                                //isnt actually an intrinsic notion of dim in the strictest sense... 
                                                //the question remains... -ag  IDimensionedGraph ??? could just end up further down the chain 
{

    public interface IVertexSet<TVertex>
    {
        ISet<TVertex> Vertices { get; }
    }

    public interface IVertexSet : IVertexSet<IVertex>
    {
    }

    public interface IGraph<TVertex> : IVertexSet<TVertex>
    {    
        ISet<IEdge<TVertex>> Edges { get; }
    }
    public interface IGraph : IGraph<IVertex>
    {
    }

    public interface IWeightableGraph<TWeight, TVertex> : IVertexSet<TVertex>
    {
        ISet<IWeightableEdge<TWeight, TVertex>> Edges { get; }
    }

    public interface IWeightableGraph<TWeight> : IVertexSet
    {
        ISet<IWeightableEdge<TWeight>> Edges { get; }
    }

    public interface IWeightableGraph : IVertexSet
    {
        ISet<IWeightableEdge> Edges { get; }
    }

    public interface IDescribableGraph<TVertex>
    {
        IGraphDescription Description { get; }
        IGraph<TVertex> Graph { get; }
    }

    public interface IDescribableGraph : IDescribableGraph<IVertex> { }

    public interface IGraphDescription : IDescribable
    {

    }
}
