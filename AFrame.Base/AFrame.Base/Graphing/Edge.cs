using AFrame.Base.Abstractions;
using AFrame.Base.Contracts;
using AFrame.Base.Contracts.Graphing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M = AFrame.Base.Math.Models;

namespace AFrame.Base.Graphing
{

    public class Edge<TVertex> : Pair<TVertex>, IEdge<TVertex> { }

    public class Edge : Pair<IPoint>, IEdge { }
}
