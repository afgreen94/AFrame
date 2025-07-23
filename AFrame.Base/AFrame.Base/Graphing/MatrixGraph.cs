using AFrame.Base.Contracts.Graphing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFrame.Base.Graphing
{
    public abstract class MatrixGraphBase<TVertex> : HashSetGraphBase<TVertex>, IMatrixGraph<TVertex>
    {
        protected MatrixGraphBase(HashSet<TVertex> vertices, HashSet<IEdge<TVertex>> edges) : base(vertices, edges)
        {
        }
    }

    public class MatrixGraph<T> : MatrixGraphBase<T>, IMatrixGraph<T>
    {
        public MatrixGraph(HashSet<T> vertices, HashSet<IEdge<T>> edges) : base(vertices, edges)
        {
        }
    }
}
