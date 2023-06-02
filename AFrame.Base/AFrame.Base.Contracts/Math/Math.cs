using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFrame.Base.Contracts.Math
{
    /// <summary>
    /// start with specific dims and generalize
    /// </summary>


    public interface IPoint { }

    public interface IPoint2D : IPoint { }
    public interface IPoint3D : IPoint { }


    public interface ICurve { }

    public interface ICurve2D : ICurve { }
    public interface ICurve3D : ICurve { }
}
