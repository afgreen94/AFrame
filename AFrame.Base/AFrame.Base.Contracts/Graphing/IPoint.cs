using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFrame.Base.Contracts.Graphing
{

    public interface IPoint { }
    public interface IPoint1D : IPoint { }

    public interface IPoint2D : IPoint1D { }
    public interface IPoint3D : IPoint2D { }

    public interface IPointND : IPoint { }
}
