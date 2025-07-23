using AFrame.Base.Contracts.Graphing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFrame.Base.Contracts.Math.Graphing
{
    public interface IEuclideanCoordinateSystem { }

    public interface IEuclideanCoordinateSystem1D : IEuclideanCoordinateSystem { }
    public interface IEuclideanCoordinateSystem2D : IEuclideanCoordinateSystem { }
    public interface IEuclideanCoordinateSystem3D : IEuclideanCoordinateSystem { }
    public interface IEuclideanCoordinateSystemND : IEuclideanCoordinateSystem { }

    public interface IEuclideanCoordinateSystemDescription : IGraphDescription { }
}
