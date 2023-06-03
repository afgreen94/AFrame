using AFrame.Base.Graphing;
using AFrame.Base.Contracts.Math.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AFrame.Base.Contracts.Graphing;

namespace AFrame.Base.Math.Forms
{

    public abstract class UnitFormGraph : DescribableFormGraph, IUnitFormGraph
    {

    }

    public class UnitFormGraphs
    {
        public class Point : UnitFormGraph, IUnitFormGraphs.IPoint { }
        public class Line : UnitFormGraph, IUnitFormGraphs.ILine { }
        public class Circle : UnitFormGraph, IUnitFormGraphs.ICircle { }
        public class Triangle : UnitFormGraph, IUnitFormGraphs.ITriangle
        {

        }
        public class Square : UnitFormGraph, IUnitFormGraphs.ISquare
        {
            private static readonly IPoint2D[] vertices = new Point2D[]
            {
                new() { X = -1.0f, Y = -1.0f },
                new() { X = 1.0f, Y = -1.0f },
                new() { X = 1.0f, Y = 1.0f },
                new() { X = -1.0f, Y = 1.0f }
            };
            private static readonly IEdge<IPoint2D>[] edges = new Edge2D[]
            {
                new() { Item1 = vertices[0], Item2 = vertices[1] },
                new() { Item1 = vertices[1], Item2 = vertices[2] },
                new() { Item1 = vertices[2], Item2 = vertices[3] },
                new() { Item1 = vertices[3], Item2 = vertices[0] }
            };
            private static readonly IGraph graph = new SetGrapht2D()
            {
                Vertices = new HashSet<IPoint2D>(vertices),
                Edges = new HashSet<IEdge<IPoint2D>>(edges)
            };
        }
    }

    
}
