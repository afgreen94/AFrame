using AFrame.Base.Contracts.Graphing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFrame.Base.Math
{
    //typing! def(f) -ag 

    public class Point : IPoint { }

    public class Point1D : IPoint1D { public float X { get; set; } }

    public class Point2D : Point1D, IPoint2D { public float Y { get; set; } }
    public class Point3D : Point2D, IPoint3D { public float Z { get; set; } }
}
