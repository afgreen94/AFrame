using AFrame.Base.Contracts.Graphing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFrame.Base.Graphing
{
    //create abstract implementations for interfaces in AFrame.Base.Contracts\Graphing\IGraph.cs

    public abstract class Graph<TVertex> : IGraph<TVertex>
    {
        protected readonly ISet<TVertex> _vertices; 
        protected readonly ISet<IEdge<TVertex>> _edges;

        public Graph() { }
        public Graph(ISet<TVertex> vertices, ISet<IEdge<TVertex>> edges) { this._vertices = vertices; this._edges = edges; }

        protected virtual ISet<TVertex> vertices => this._vertices;
        protected virtual ISet<IEdge<TVertex>> edges => this._edges;

        public virtual ISet<TVertex> Vertices => this.vertices;
        public virtual ISet<IEdge<TVertex>> Edges => this.edges;
    }

    public class GraphDescription { }
}
