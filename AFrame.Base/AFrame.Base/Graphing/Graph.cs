using AFrame.Base.Contracts.Graphing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFrame.Base.Graphing
{

    public abstract class Graph<TVertex> : IGraph<TVertex>
    {

        protected abstract ISet<TVertex> vertices { get; }
        protected abstract ISet<IEdge<TVertex>> edges { get; }

        public virtual ISet<TVertex> Vertices => this.vertices;
        public virtual ISet<IEdge<TVertex>> Edges => this.edges;
    }

    public abstract class Graph : Graph<IVertex>, IGraph { }
}
