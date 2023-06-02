using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AFrame.Base.Contracts;

namespace AFrame.Base
{
    public abstract class DataCacheBase : IDataCache { }

    public class DefaultDataCache : IDefaultDataCache { }

    public static class GlobalDataCache { }

    public interface IDefaultDataCache : IDataCache { }

}
