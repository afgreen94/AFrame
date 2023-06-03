using AFrame.Base.Abstractions;
using AFrame.Base.Contracts.Graphing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFrame.Base.Graphing
{
    public abstract class GraphSetBuilder<T> : GSS_Description
    {
        protected readonly HashSet<T> vertices = new();
        protected readonly HashSet<Pair<T>> edges = new();

        public bool AddVertex(T vertex) => AddVertexCore(vertex);
        public bool RemoveVertex(T vertex) => RemoveVertexCore(vertex);
        public bool AddEdge(T vertex0, T vertex1) => AddEdgeCore(new Pair<T> { Item1 = vertex0, Item2 = vertex1 });
        public bool AddEdge(Pair<T> edge) => AddEdgeCore(edge);

        protected virtual bool AddVertexCore(T vertex) => vertices.Add(vertex);
        protected virtual bool RemoveVertexCore(T vertex) => vertices.Remove(vertex);

        protected virtual bool AddEdgeCore(Pair<T> edge)
        {
            ValidateKnownVertices(edge);

            return edges.Add(edge);
        }

        protected virtual bool RemoveEdgeCore(Pair<T> edge) => edges.Remove(edge);

        protected void ValidateKnownVertices(Pair<T> edge)
        {
            if (!vertices.Contains(edge.Item1) || !vertices.Contains(edge.Item2))
                throw new Exception("-ag-");
        }
    }

    public abstract class GraphSetBuilder2D : GraphSetBuilder<IPoint2D>
    {

    }

    public class DefaultGraphSetBuilder : GraphSetBuilder2D
    {

    }
}
