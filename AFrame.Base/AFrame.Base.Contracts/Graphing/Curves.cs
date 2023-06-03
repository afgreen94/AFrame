using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFrame.Base.Contracts.Graphing
{
    public interface ICurve { }

    public interface ICurve2D : ICurve { }
    public interface ICurve3D : ICurve { }

    public interface ICurveND : ICurve { }
}
