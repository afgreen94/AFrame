using AFrame.Base.Contracts.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AFrame.Base.Contracts.Graphing;

namespace AFrame.Base.Graphing
{

    public abstract class HashSetGraphBase<TVertex> : Graph<TVertex>, IHashSetGraph<TVertex>
    {
        public HashSetGraphBase(HashSet<TVertex> vertices, HashSet<IEdge<TVertex>> edges) : base(vertices, edges)
        {
        }
    }

    public class HashSetGraph<T> : HashSetGraphBase<T>, IHashSetGraph<T>
    {
        public HashSetGraph(HashSet<T> vertices, HashSet<IEdge<T>> edges) : base(vertices, edges)
        {
        }
    }

    public interface IHashSetGraph<TVertex> : IGraph<TVertex>
    {
    }
}
