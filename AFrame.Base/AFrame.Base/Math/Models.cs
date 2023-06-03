using AFrame.Base.Contracts.Abstractions;
using AFrame.Base.Contracts.Graphing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFrame.Base.Math.Models
{


    public class Pair1D : Abstractions.Pair<IPoint1D>
    {
    }
    public class Pair : Pair1D { }

    public class Pair2D : Abstractions.Pair<IPoint2D>
    {
    }

    public class Pair3D : Abstractions.Pair<IPoint3D>, IPair<IPoint3D>
    {
    }

    public class PairND { }


    public class Space
    {

    }

    public class NSpace
    {

    }

    public class PointSpace : Space
    {
    }

    public class NPointSpace : PointSpace
    {

    }

    public class Surface
    {

    }

    public class OneSurface : Surface
    {

    }

    public class TwoSurface : Surface
    {

    }

    public class ThreeSurface : Surface
    {

    }

    public class FourSurface : Surface
    {

    }

    public class NSurface : Surface
    {

    }

    public class TwoNSurface : NSurface
    {

    }

    public class ThreeNSurface : NSurface
    {

    }

    public class FourNSurface : NSurface
    {

    }

    public class MNSurface : NSurface { }
}
