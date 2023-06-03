using AFrame.Base.Contracts.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AFrame.Base.Contracts.Graphing;

namespace AFrame.Base.Graphing
{
    public abstract class SetGraph<T> : ISetGraph
    {
        public HashSet<T> Vertices { get; set; }
        public HashSet<IEdge<T>> Edges { get; set; }
        public bool Directed { get; set; }

        ISet<IVertex> Vertices => throw new NotImplementedException();

        ISet<IEdge<IVertex>> Edges => throw new NotImplementedException();

        protected SetGraph(HashSet<T> vertices, HashSet<IEdge<T>> edges, bool directed = false)
        {
            Vertices = vertices;
            Edges = edges;
            Directed = directed;
        }

        protected SetGraph() { }
    }

    public class SetGrapht2D : SetGraph<IPoint2D>
    {
    }
}
